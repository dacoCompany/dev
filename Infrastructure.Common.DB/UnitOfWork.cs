﻿using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace Infrastructure.Common.DB
{
    /// <summary>
    /// Implementation of Unit of Work
    /// </summary>
    /// <seealso cref="Infrastructure.Common.DB.IUnitOfWork" />
    public class UnitOfWork : IUnitOfWork
    {
        public static EBADODBEntities context = new EBADODBEntities(@"metadata=res://*/EBADOModel.csdl|res://*/EBADOModel.ssdl|res://*/EBADOModel.msl;provider=System.Data.SqlClient;provider connection string='data source=localhost\masterdb;initial catalog=EBADODB;integrated security=False;persist security info=True;user id=sa;password=oracle;MultipleActiveResultSets=True;App=EntityFramework'");
        private bool disposed = false;

        private Repository<AccountTypeDbo> accountTypeRepository;
        private Repository<AddressDbo> addressRepository;
        private Repository<CategoryDbo> categoryRepository;
        private Repository<LocationDbo> locationRepository;
        private Repository<MainCategoryDbo> mainCategoryRepository;
        private Repository<SubCategoryDbo> subCategoryRepository;
        private Repository<UserAccountDbo> userAccountRepository;
        private Repository<UserRoleDbo> userRoleRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
        /// </summary>
        public UnitOfWork()
        {
            context.Configuration.LazyLoadingEnabled = false;
        }

        /// <summary>
        /// Gets the account type repository.
        /// </summary>
        /// <value>
        /// The account type repository.
        /// </value>
        public IRepository<AccountTypeDbo> AccountTypeRepository
        {
            get
            {
                return accountTypeRepository ?? (accountTypeRepository = new Repository<AccountTypeDbo>(context));
            }
        }

        /// <summary>
        /// Gets the address repository.
        /// </summary>
        /// <value>
        /// The address repository.
        /// </value>
        public IRepository<AddressDbo> AddressRepository
        {
            get
            {
                return addressRepository ?? (addressRepository = new Repository<AddressDbo>(context));
            }
        }

        /// <summary>
        /// Gets the category repository.
        /// </summary>
        /// <value>
        /// The category repository.
        /// </value>
        public IRepository<CategoryDbo> CategoryRepository
        {
            get
            {
                return categoryRepository ?? (categoryRepository = new Repository<CategoryDbo>(context));
            }
        }

        /// <summary>
        /// Gets the location repository.
        /// </summary>
        /// <value>
        /// The location repository.
        /// </value>
        public IRepository<LocationDbo> LocationRepository
        {
            get
            {
                return locationRepository ?? (locationRepository = new Repository<LocationDbo>(context));
            }
        }

        /// <summary>
        /// Gets the main category repository.
        /// </summary>
        /// <value>
        /// The main category repository.
        /// </value>
        public IRepository<MainCategoryDbo> MainCategoryRepository
        {
            get
            {
                return mainCategoryRepository ?? (mainCategoryRepository = new Repository<MainCategoryDbo>(context));
            }
        }

        /// <summary>
        /// Gets the sub category repository.
        /// </summary>
        /// <value>
        /// The sub category repository.
        /// </value>
        public IRepository<SubCategoryDbo> SubCategoryRepository
        {
            get
            {
                return subCategoryRepository ?? (subCategoryRepository = new Repository<SubCategoryDbo>(context));
            }
        }

        /// <summary>
        /// Gets the user account repository.
        /// </summary>
        /// <value>
        /// The user account repository.
        /// </value>
        public IRepository<UserAccountDbo> UserAccountRepository
        {
            get
            {
                return userAccountRepository ?? (userAccountRepository = new Repository<UserAccountDbo>(context));
            }
        }

        /// <summary>
        /// Gets the user role repository.
        /// </summary>
        /// <value>
        /// The user role repository.
        /// </value>
        public IRepository<UserRoleDbo> UserRoleRepository
        {
            get
            {
                return userRoleRepository ?? (userRoleRepository = new Repository<UserRoleDbo>(context));
            }
        }

        /// <summary>
        /// Implementation of commit method
        /// </summary>
        public void Commit()
        {
            try
            {
                var ctx = ((IObjectContextAdapter)context).ObjectContext;

                // detect changes in db context and filter modified and added entities
                ctx.DetectChanges();
                var modifiedEntries = ctx.ObjectStateManager.GetObjectStateEntries(EntityState.Modified);
                var addedEntries = ctx.ObjectStateManager.GetObjectStateEntries(EntityState.Added);
                var timestamp = DateTime.Now;

                // set DateModified for modified entities
                foreach (var entry in modifiedEntries)
                {
                    var entity = entry.Entity as IEntity;

                    if (entity != null)
                    {
                        entity.DateModified = timestamp;
                    }
                }

                // set DateCreated and IsActive for new entities
                foreach (var entry in addedEntries)
                {
                    var entity = entry.Entity as IEntity;

                    if (entity != null)
                    {
                        entity.DateCreated = timestamp;
                        entity.IsActive = true;
                    }
                }

                ctx.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                //StringBuilder sb = new StringBuilder();

                //foreach (var failure in ex.EntityValidationErrors)
                //{
                //    sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());

                //    foreach (var error in failure.ValidationErrors)
                //    {
                //        sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                //        sb.AppendLine();
                //    }
                //}

                //throw new DbEntityValidationException("Entity Validation Failed - errors follow:\n" + sb.ToString(), ex); // Add the original exception as the innerException
            }
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
