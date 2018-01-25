using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Week_08.Controllers
{
    public class WhatController : Controller
    {
        // GET: What
        public ActionResult Index()
        {
            return View();
        }

        // GET: What/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: What/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: What/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: What/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: What/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: What/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: What/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}