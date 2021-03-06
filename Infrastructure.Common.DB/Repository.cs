﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Infrastructure.Common.DB
{
    /// <summary>
    /// Implementation of repository pattern
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Infrastructure.Common.DB.IRepository{T}" />
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        #region Private members

        private DbSet<T> dataEntity;
        private DbContext dataContext;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the data entity.
        /// </summary>
        /// <value>
        /// The data entity.
        /// </value>
        public DbSet<T> DataEntity
        {
            get
            {
                if (dataEntity == null)
                {
                    dataEntity = dataContext.Set<T>();
                }

                return dataEntity;
            }

            private set
            {
                dataEntity = value;
            }
        }

        /// <summary>
        /// Gets the data context.
        /// </summary>
        /// <value>
        /// The data context.
        /// </value>
        public DbContext DataContext
        {
            get
            {
                return dataContext;
            }
            private set
            {
                dataContext = value;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository{T}"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public Repository(DbContext context)
        {
            DataContext = context;
        }

        #endregion

        #region Interface methods

        /// <summary>
        /// Finds all (active and inactive entities)
        /// </summary>
        /// <returns>Collection of entites</returns>
        public IQueryable<T> FindAll()
        {
            return DataEntity;
        }

        /// <summary>
        /// Finds the active entity by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Active entity</returns>
        public T FindById(int id)
        {
            return DataEntity.Where(entity => entity.Id == id).FirstOrDefault(entity => entity.IsActive == true);
        }

        /// <summary>
        /// Finds the active entites by predicate.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns>Collection of active entities</returns>
        public IQueryable<T> FindWhere(Expression<Func<T, bool>> predicate)
        {
            return DataEntity.Where(predicate).Where(entity => entity.IsActive == true);
        }
        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="obj">The entity object.</param>
        /// <returns>Added entity</returns>
        public T Add(T obj)
        {
            return DataEntity.Add(obj);
        }

        /// <summary>
        /// Adds the specified entities.
        /// </summary>
        /// <param name="objCollection">The object collection.</param>
        /// <returns>Collection of added entites</returns>
        public IEnumerable<T> AddRange(IEnumerable<T> objCollection)
        {
            return DataEntity.AddRange(objCollection);
        }

        /// <summary>
        /// Sets specified entity to inactive
        /// </summary>
        /// <param name="obj">The entity object.</param>
        public void Delete(T obj)
        {
            obj.IsActive = false;
        }


        #endregion
    }
}
