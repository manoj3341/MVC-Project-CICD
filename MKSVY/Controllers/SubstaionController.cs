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
    public class SubstaionController : Controller
    {
        // GET: SubstaionList
        public ActionResult SubstaionList(int Dist_code , string status1)
        {
            ViewData["substaionLists"] = "";
            ViewData["Dist_Name"] = "";
            List<SubstaionList> substaionLists = new List<SubstaionList>();
            substaionLists = SubStationListServices.GetSubStationList(Dist_code,status1);
            ViewData["Dist_Name"] = substaionLists[0].DIST_NAME;
            ViewData["Dist_code"] = substaionLists[0].DIST_CODE;
            ViewData["substaionLists"] = substaionLists;
            ViewBag.SubstaionList = JsonConvert.SerializeObject(substaionLists);

            return View("");
        }
        //public ActionResult Details(int id)
        //{
        //    List<SubstaionList> substaionLists1 = new List<SubstaionList>();
        //    substaionLists1 = SubStationListServices.GetSubStationList(id,);
        //    if (substaionLists1 == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    ViewData["substaionLists1"] = substaionLists1;

        //    return View();
        //}

        public ActionResult LandClearance(int Dist_code, string substation_No)
        {
            ViewData["SubstationName"] = "";
            ViewData["Substation_Number"] = "";
            ViewData["Dist_code"] = "";
            ViewData["LandClearance"] = "";
            List<LandClearance> landClearances = new List<LandClearance>();
            landClearances = SubStationListServices.GetLandClearanceByID(Dist_code, substation_No);

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