using MKSVY.Models;
using MKSVY.Servies;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MKSVY.Controllers
{
    public class LandController : Controller
    {
        // GET: LandClearance
        public ActionResult LandClearance(int Dist_code, string substation_No)
        {
            ViewData["SubstationName"] = "";
            ViewData["Substation_Number"] = "";
            ViewData["Dist_code"] = "";
            ViewData["LandClearance"] = "";
            List<LandClearance> landClearances = new List<LandClearance>();
            landClearances = SubStationListServices.GetLandClearanceByID(Dist_code,substation_No);

            ViewData["SubstationName"] = landClearances[0].SUBSTATION_NAME;
            ViewData["Substation_Number"] = landClearances[0].SUBSTATION_NUMBER;
            string dist_code = Request.QueryString["Dist_code"];
            ViewData["Dist_code"] = Convert.ToInt32(dist_code);

            ViewData["LandClearance"] = landClearances;
            ViewBag.LandClearances = JsonConvert.SerializeObject(landClearances);

            
            return View();
        }
    }
}