﻿using Clover_Store.Data;
using Clover_Store.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clover_Store.Controllers
{
    
    public class LogingController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LogingController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult logIn()
        {
            return View();
        }
        public IActionResult signUp()
         {
                return View();
         }
        [HttpPost]
        public IActionResult signUp(Cutomer obj)
        {
            _db.Cutomer.Add(obj);
            _db.SaveChanges();
            return View();
        }


    }
}