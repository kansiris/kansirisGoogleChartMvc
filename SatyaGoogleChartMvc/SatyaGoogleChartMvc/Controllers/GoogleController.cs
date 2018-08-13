using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SatyaGoogleChartMvc.Models;

namespace SatyaGoogleChartMvc.Controllers
{
    public class GoogleController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "M.S. DHONI GOOGLE SCORE CHART";
            CricketModel objCricketModel = new CricketModel();
            objCricketModel.CricketData = new Cricket();
            objCricketModel.CricketData = CricketChartData();
            objCricketModel.CricketYear = "Year";
            objCricketModel.CenturyTitle = "Century";
            objCricketModel.HalfCenturyTitle = "HalfCentury";
            return View(objCricketModel);
        }
        public Cricket CricketChartData()
        {
            Cricket objcricket = new Cricket();
            objcricket.Year = "2009-03-10,2010-03-10,2011-03-10,2012-03-10,2013-03-10,2014-03-10,2015-03-10,2016-03-10";
            objcricket.Century = "20,28,12,24,14,18,19,27";
            objcricket.HalfCentury = "42,72,22,12,11,34,13,29";
            return objcricket;
        }
    }
}
