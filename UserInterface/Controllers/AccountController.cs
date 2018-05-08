﻿using DomainModels.ViewModel;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserInterface.Controllers
{
    public class AccountController : Controller
    {
        IUnitOfWork uow;
        public AccountController(IUnitOfWork _uow)
        {
            uow = _uow;
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            UserModel user = uow.AuthenticateRepo.validateUser(model.userName, model.password);
            if (user != null)
            {
                        
            }
            return View();
        }
    }
}