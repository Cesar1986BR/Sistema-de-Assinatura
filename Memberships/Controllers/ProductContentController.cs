﻿
using Memberships.Extensions;
using Memberships.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Memberships.Controllers
{
    [Authorize]
    public class ProductContentController : Controller
    {
        // GET: ProductContent
        public async Task<ActionResult> Index(int id)
        {
            var userId = Request.IsAuthenticated ? HttpContext.User.Identity.GetUserId() : null;
            var sections = await SectionExtensions.GetProductSectionsAsync(id, userId);
            return View(sections);
        }

        //public async Task<ActionResult> Content(int productId, int itemId)
        //{
        //    var model = await SectionExtensions.GetContentAsync(productId, itemId);
        //    return View("Content", model);
        //}
    }
}