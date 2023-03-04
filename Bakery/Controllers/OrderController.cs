using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
  public class OrdersController : Controller
  {
   
   [HttpGet("/vendors/{vendorId}/orders/new")]
   public ActionResult New(int orderId)
   {
    Vendor vendor = Vendor.Find(orderId);
    return View(vendor);
   }
  }
    // [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    // public ActionResult Show(int vendorId, int orderId)
    // {

    // }
}