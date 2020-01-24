﻿using Microsoft.AspNetCore.Mvc;
using AspNetCoreBootstrap4Validation.ViewModels;
using System.Collections.Generic;

namespace AspNetCoreBootstrap4Validation.Controllers
{
    public class AjaxComplexListController : Controller
    {
        public IActionResult Index()
        {
            return View(new AjaxValidationListModel {
                Items = new List<AjaxValidationModel> {
                    new AjaxValidationModel(),
                    new AjaxValidationModel()
                }
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(AjaxValidationModel model)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("_partialComplexAjaxForm", model);
            }

            // the client could validate this, but allowed for testing server errors
            if(model.Name.Length < 3)
            {
                ModelState.AddModelError("name", "Name should be longer than 2 chars");
                return PartialView("_partialComplexAjaxForm", model);
            }

            ModelState.Clear();
            return PartialView("_partialComplexAjaxForm", model);
        }
    }
}
