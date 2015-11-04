using MvcIoC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcIoC.Controllers
{
  public class ProteinTrackerController : Controller
  {
    private IProteinTrackingService _proteinTrackingService ;

    public ProteinTrackerController(IProteinTrackingService proteinTrackingService)
    {
      _proteinTrackingService = proteinTrackingService;
    }

    // GET: ProteinTracker
    public ActionResult Index()
    {
      ViewBag.Total = _proteinTrackingService.Total;
      ViewBag.Goal = _proteinTrackingService.Goal;
      return View();
    }

    public ActionResult AddProtein(int amount)
    {
      _proteinTrackingService.AddProtein(amount);
      ViewBag.Total = _proteinTrackingService.Total;
      ViewBag.Goal = _proteinTrackingService.Goal;
      return View("Index");
    }
  }
}