using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
  public class VendorController : Controller
  {
    [HttpGetAttribute("/vendor")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
  }

}