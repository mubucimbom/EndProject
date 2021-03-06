﻿using EndProject.DAL;
using EndProject.Models;
using EndProject.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndProject.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        public HeaderViewComponent(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.ProCount = 0;
           
            if (Request.Cookies["cart"]!=null && Request.Cookies["cart"].Length > 5)
            {
                List<ProducttVM> productts = JsonConvert.DeserializeObject<List<ProducttVM>>(Request.Cookies["cart"]);
                ViewBag.ProCount = productts.Count();
            }
            

            if (User.Identity.IsAuthenticated)
            {
                AppUser loginUser = await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.UserFullName = loginUser.Fullname;
            }
            Bio bio = _db.Bio.FirstOrDefault();
            return View(await Task.FromResult(bio));
        }

    }
}
