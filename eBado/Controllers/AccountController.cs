﻿using Infrastructure.Common;
using Infrastructure.Common.DB;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Web.eBado.Models.Account;

namespace Web.eBado.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                {
                    ModelState.AddModelError("", "Login data is incorrect!");
                }
            }
            return View(model);
        }

        [AllowAnonymous]
        public ActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterUser(RegisterUser model)
        {
            if (ModelState.IsValid)
            {
                if (CheckIfEmailExist(model.Email))
                {
                    var password = GeneratePassword();
                    var salt = GenerateSalt();

                    using (var uow = new UnitOfWork())
                    {
                        var accountLocation = uow.LocationRepository.FindWhere(lr => lr.PostalCode == model.PostalCode).FirstOrDefault();
                        var accountType = uow.AccountTypeRepository.FindWhere(at => at.Name == "").FirstOrDefault();
                        var addressModel = new AddressDbo
                        {
                            Street = model.Street,
                            Number = model.StreetNumber,
                            LocationId = accountLocation.Id,
                            IsBillingAddress = true
                        };

                        var accountModel = new UserAccountDbo
                        {
                            Email = model.Email,
                            PhoneNumber = model.PhoneNumber,
                            Title = model.Title,
                            FirstName = model.FirstName,
                            Surname = model.Surname,
                            CompanyName = model.AccountName,
                            Password = CreateHashPassword(password, salt).ToString(),
                            Salt = salt.ToString(),
                            AccountTypeId = accountType.Id
                        };
                        accountModel.Addresses.Add(addressModel);

                        uow.Commit();
                    }
                }
                else
                {
                    ModelState.AddModelError("Email", "Email is not unique!");
                }
            }
            return View(model);
        }

        [AllowAnonymous]
        public ActionResult RegisterPartTime()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterPartTime(RegisterPartTime model)
        {
            if (ModelState.IsValid)
            {
                if (CheckIfEmailExist(model.Email))
                {
                    var password = GeneratePassword();
                    var salt = GenerateSalt();

                    using (var uow = new UnitOfWork())
                    {
                        var accountLocation = uow.LocationRepository.FindWhere(lr => lr.PostalCode == model.PostalCode).FirstOrDefault();
                        var subCategory = uow.SubCategoryRepository.FindWhere(sc => sc.Name == model.Specialization).FirstOrDefault();
                        var accountType = uow.AccountTypeRepository.FindWhere(at => at.Name == "").FirstOrDefault();
                        var addressModel = new AddressDbo
                        {
                            Street = model.Street,
                            Number = model.StreetNumber,
                            LocationId = accountLocation.Id,
                            IsBillingAddress = true
                        };

                        var accountModel = new UserAccountDbo
                        {
                            Email = model.Email,
                            PhoneNumber = model.PhoneNumber,
                            Title = model.Title,
                            FirstName = model.FirstName,
                            Surname = model.Surname,
                            CompanyName = model.AccountName,
                            SubCategoryId = subCategory.Id,
                            Password = CreateHashPassword(password, salt).ToString(),
                            Salt = salt.ToString(),
                            AccountTypeId = accountType.Id
                        };
                        accountModel.Addresses.Add(addressModel);

                        uow.Commit();
                    }
                }
                else
                {
                    ModelState.AddModelError("Email", "Email is not unique!");
                }
            }
            return View(model);
        }

        [AllowAnonymous]
        public ActionResult RegisterSelfEmployed()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterSelfEmployed(RegisterSelfEmployed model)
        {
            if (ModelState.IsValid)
            {
                if (CheckIfEmailExist(model.Email))
                {
                    var password = GeneratePassword();
                    var salt = GenerateSalt();

                    using (var uow = new UnitOfWork())
                    {
                        var accountLocation = uow.LocationRepository.FindWhere(lr => lr.PostalCode == model.PostalCode).FirstOrDefault();
                        var subCategory = uow.SubCategoryRepository.FindWhere(sc => sc.Name == model.Specialization).FirstOrDefault();
                        var accountType = uow.AccountTypeRepository.FindWhere(at => at.Name == "").FirstOrDefault();
                        var addressModel = new AddressDbo
                        {
                            Street = model.Street,
                            Number = model.StreetNumber,
                            LocationId = accountLocation.Id,
                            IsBillingAddress = true
                        };

                        var accountModel = new UserAccountDbo
                        {
                            Email = model.Email,
                            PhoneNumber = model.PhoneNumber,
                            Title = model.Title,
                            FirstName = model.FirstName,
                            Surname = model.Surname,
                            CompanyName = model.AccountName,
                            Ico = model.Ico,
                            Dic = model.Dic,
                            SubCategoryId = subCategory.Id,
                            Password = CreateHashPassword(password, salt).ToString(),
                            Salt = salt.ToString(),
                            AccountTypeId = accountType.Id
                        };
                        accountModel.Addresses.Add(addressModel);

                        uow.Commit();
                    }
                }
                else
                {
                    ModelState.AddModelError("Email", "Email is not unique!");
                }
            }
            return View(model);
        }

        [AllowAnonymous]
        public ActionResult RegisterCompany()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterCompany(RegisterCompany model)
        {
            if (ModelState.IsValid)
            {
                if (CheckIfEmailExist(model.Email))
                {
                    var password = GeneratePassword();
                    var salt = GenerateSalt();

                    using (var uow = new UnitOfWork())
                    {
                        var accountLocation = uow.LocationRepository.FindWhere(lr => lr.PostalCode == model.PostalCode).FirstOrDefault();
                        var subCategory = uow.SubCategoryRepository.FindWhere(sc => sc.Name == model.Specialization).FirstOrDefault();
                        var accountType = uow.AccountTypeRepository.FindWhere(at => at.Name == "").FirstOrDefault();
                        var addressModel = new AddressDbo
                        {
                            Street = model.Street,
                            Number = model.StreetNumber,
                            LocationId = accountLocation.Id,
                            IsBillingAddress = true
                        };

                        var accountModel = new UserAccountDbo
                        {
                            Email = model.Email,
                            PhoneNumber = model.PhoneNumber,
                            Title = model.Title,
                            FirstName = model.FirstName,
                            Surname = model.Surname,
                            CompanyName = model.AccountName,
                            Ico = model.Ico,
                            Dic = model.Dic,
                            SubCategoryId = subCategory.Id,
                            Password = CreateHashPassword(password, salt).ToString(),
                            Salt = salt.ToString(),
                            AccountTypeId = accountType.Id
                        };
                        accountModel.Addresses.Add(addressModel);

                        uow.Commit();
                    }
                }
                else
                {
                    ModelState.AddModelError("Email", "Email is not unique!");
                }
            }
            return View(model);
        }

        #region Private methods
        private bool CheckIfEmailExist(string email)
        {
            using (var uow = new UnitOfWork())
            {
                var userEmail = uow.UserAccountRepository.FindWhere(ua => ua.Email == email).FirstOrDefault();
                return userEmail == null ? true : false;
            }
        }

        private static byte[] CreateHashPassword(byte[] newPassword, byte[] salt)
        {
            HashAlgorithm algorithm = new SHA256Managed();

            byte[] plainTextWithSaltBytes =
              new byte[newPassword.Length + salt.Length];

            for (int i = 0; i < newPassword.Length; i++)
            {
                plainTextWithSaltBytes[i] = newPassword[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[newPassword.Length + i] = salt[i];
            }

            return algorithm.ComputeHash(plainTextWithSaltBytes);
        }

        private static byte[] GenerateSalt()
        {
            Random random = new Random();
            byte[] salt = Encoding.ASCII.GetBytes(new string(Enumerable.Repeat(Constants.saltChars, 15)
              .Select(s => s[random.Next(s.Length)]).ToArray()));
            return salt;
        }

        private static byte[] GeneratePassword()
        {
            Random random = new Random();
            byte[] hashPassword = Encoding.ASCII.GetBytes(new string(Enumerable.Repeat(Constants.passwordChars, 10)
              .Select(s => s[random.Next(s.Length)]).ToArray()));
            return hashPassword;
        }
        #endregion

    }
}