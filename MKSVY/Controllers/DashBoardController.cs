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
    public class DashBoardController : Controller
    {
        List<string> districtList = new List<string>();
        // GET: DashBoard
        public ActionResult DataPoint(string dist_code, string augmny)
        {
            //string augmny = "N";
            ViewData["dataPoint"] = "";
            ViewData["Dist_Name"] = "";
            //DataPoint dataPoint = new DataPoint();
            List<DataPoint> dataPoints = new List<DataPoint>();
            List<DataPoint> dataPoints1 = new List<DataPoint>();
            List<DataPoint> dataPoints2 = new List<DataPoint>();
            List<DataPoint> dataPoints3 = new List<DataPoint>();
            List<DataPoint> dataPoints4 = new List<DataPoint>();
            //dataPoints = DashBoardService.GetDashBoardData(dist_code);

            //dataPoints1 = DashBoardService.GetDashBoardDataByDisttrict();

            //ViewData["dataPoint"] = dataPoints;

            //ViewBag.titleyavtmal = JsonConvert.SerializeObject(dataPoints[0].DIST_NAME);
            //if (dataPoints.Count() > 0)
            //{
            //    ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);

            //}
            //if (dataPoints1.Count() > 0)
            //{
            //    ViewBag.Datapoint1 = JsonConvert.SerializeObject(dataPoints1);
            //}


            List<DistrictswiseSummary> districDropdown = new List<DistrictswiseSummary>();
            districDropdown = DashBoardService.GetAllDistricts();
            //SelectList DistrictNames = new SelectList(districDropdown, "DIST_CODE", "DIST_NAME", dist_code);
            //ViewBag.DisstrictsList = DistrictNames;
            ViewBag.DisstrictsList = new SelectList(districDropdown, "DIST_CODE", "DIST_NAME", dist_code);//JsonConvert.SerializeObject(districDropdown);
            List<SelectListItem> AugmnYN = new List<SelectListItem> {
                new SelectListItem { Value = "N", Text = "NO" },
                new SelectListItem { Value = "Y", Text = "Yes" },
                 
                };
            ViewBag.AugnYNList = new SelectList(AugmnYN, "Value", "Text", augmny);
            //List<SubStationWiseLandCount> subStationWiseLands = new List<SubStationWiseLandCount>();
            //subStationWiseLands = DashBoardService.GetSubStationWiseLandCount(dist_code);
            //if (subStationWiseLands.Count() > 0)
            //{
            //    ViewData["Dist_Name"] = subStationWiseLands[0].DIST_NAME;
            //    ViewData["Dist_Code"] = subStationWiseLands[0].DIST_CODE;
            //    List<SolarCapacityDataPoint> solarcapacityDataPoint = new List<SolarCapacityDataPoint>();
            //    for (int i = 0; i < subStationWiseLands.Count(); i++)
            //    {
            //        if (i == 0)
            //        {
            //            dataPoints.Add(new DataPoint("Completed", Convert.ToInt32(subStationWiseLands[i].Completed == "" ? "0.0" : subStationWiseLands[i].Completed), "#228B22", "Completed"));
            //            dataPoints.Add(new DataPoint("In Progress", Convert.ToInt32(subStationWiseLands[i].InProgress == "" ? "0.0" : subStationWiseLands[i].InProgress), "#FFD142", "In Progress"));
            //            dataPoints.Add(new DataPoint("Not Yet To Start", Convert.ToInt32(subStationWiseLands[i].Yet_To_Start == "" ? "0.0" : subStationWiseLands[i].Yet_To_Start), "#FF4255", "Yet To Start"));
            //        }
            //        else
            //        {
            //            solarcapacityDataPoint.Add(new SolarCapacityDataPoint("Completed", Convert.ToDouble(subStationWiseLands[i].Completed == "" ? "0.0" : subStationWiseLands[i].Completed), "#228B22", "Completed"));
            //            solarcapacityDataPoint.Add(new SolarCapacityDataPoint("In Progress", Convert.ToDouble(subStationWiseLands[i].InProgress == "" ? "0.0" : subStationWiseLands[i].InProgress), "#FFD142", "In Progress"));
            //            solarcapacityDataPoint.Add(new SolarCapacityDataPoint("Not Yet To Start", Convert.ToDouble(subStationWiseLands[i].Yet_To_Start == "" ? "0.0" : subStationWiseLands[i].Yet_To_Start), "#FF4255", "Yet To Start"));
            //        }
            //    }

            //    ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);
            //    ViewBag.SolarCapacityCount = JsonConvert.SerializeObject(solarcapacityDataPoint);
            //    ViewData["SubStationWiseLand"] = subStationWiseLands;
            //}
            //List<AugmentationWiseCount> augmentationWises = new List<AugmentationWiseCount>();
            ////List<AugmentationWiseCount> augmentations = new List<AugmentationWiseCount>();
            //augmentationWises = DashBoardService.GetSubStationWiseAUGMENTATIONCount(dist_code);
            //if (augmentationWises.Count() > 0)
            //{
            //    List<AugmentationwiseSubstationcount> augmentationwises = new List<AugmentationwiseSubstationcount>();
            //    List<SubStationWiseAUGMENTATION> augmentations = new List<SubStationWiseAUGMENTATION>();
            //    for (int i = 0; i < augmentationWises.Count(); i++)
            //    {
            //        if (i == 0)
            //        {
            //            augmentationwises.Add(new AugmentationwiseSubstationcount("Completed", Convert.ToInt32(augmentationWises[i].Completed == "" ? "0.0" : augmentationWises[i].Completed), "#228B22", "Completed"));
            //            augmentationwises.Add(new AugmentationwiseSubstationcount("In Progress", Convert.ToInt32(augmentationWises[i].InProgress == "" ? "0.0" : augmentationWises[i].InProgress), "#FFD142", "In Progress"));
            //            augmentationwises.Add(new AugmentationwiseSubstationcount("Not Yet To Start", Convert.ToInt32(augmentationWises[i].Yet_To_Start == "" ? "0.0" : augmentationWises[i].Yet_To_Start), "#FF4255", "Yet To Start"));


            //        }
            //        else
            //        {
            //            augmentations.Add(new SubStationWiseAUGMENTATION("Completed", Convert.ToDouble(augmentationWises[i].Completed == "" ? "0.0" : augmentationWises[i].Completed), "#228B22", "Completed"));
            //            augmentations.Add(new SubStationWiseAUGMENTATION("In Progress", Convert.ToDouble(augmentationWises[i].InProgress == "" ? "0.0" : augmentationWises[i].InProgress), "#FFD142", "In Progress"));
            //            augmentations.Add(new SubStationWiseAUGMENTATION("Not Yet To Start", Convert.ToDouble(augmentationWises[i].Yet_To_Start == "" ? "0.0" : augmentationWises[i].Yet_To_Start), "#FF4255", "Yet To Start"));

            //        }
            //    }
            //    ViewBag.augmentationwisesCount = JsonConvert.SerializeObject(augmentationwises);
            //    ViewBag.augmentationsCount = JsonConvert.SerializeObject(augmentations);
            //    ViewData["augmentations"] = augmentationWises;

            //}
            List<SubStationWiseLandCount> subStationWiseData = new List<SubStationWiseLandCount>();
            List<AugmentationwiseSubstationcount> augmentationwises = new List<AugmentationwiseSubstationcount>();
            List<SubStationWiseAUGMENTATION> augmentations = new List<SubStationWiseAUGMENTATION>();

            subStationWiseData = DashBoardService.GetSubStationWiseData(dist_code, augmny);
            if (subStationWiseData.Count() > 0)
            {
                ViewData["Dist_Name"] = subStationWiseData[0].DIST_NAME;
                ViewData["Dist_Code"] = subStationWiseData[0].DIST_CODE;
                List<SolarCapacityDataPoint> solarcapacityDataPoint = new List<SolarCapacityDataPoint>();
                for (int i = 0; i < subStationWiseData.Count(); i++)
                {
                    if (i == 0)
                    {
                        dataPoints.Add(new DataPoint("Completed", Convert.ToInt32(subStationWiseData[i].Completed == "" ? "0.0" : subStationWiseData[i].Completed), "#228B22", "Completed"));
                        dataPoints.Add(new DataPoint("In Progress", Convert.ToInt32(subStationWiseData[i].InProgress == "" ? "0.0" : subStationWiseData[i].InProgress), "#FFD142", "In Progress"));
                        dataPoints.Add(new DataPoint("Not Yet To Start", Convert.ToInt32(subStationWiseData[i].Yet_To_Start == "" ? "0.0" : subStationWiseData[i].Yet_To_Start), "#FF4255", "Yet To Start"));
                    }
                    else if (i == 1)
                    {
                        solarcapacityDataPoint.Add(new SolarCapacityDataPoint("Completed", Convert.ToDouble(subStationWiseData[i].Completed == "" ? "0.0" : subStationWiseData[i].Completed), "#228B22", "Completed"));
                        solarcapacityDataPoint.Add(new SolarCapacityDataPoint("In Progress", Convert.ToDouble(subStationWiseData[i].InProgress == "" ? "0.0" : subStationWiseData[i].InProgress), "#FFD142", "In Progress"));
                        solarcapacityDataPoint.Add(new SolarCapacityDataPoint("Not Yet To Start", Convert.ToDouble(subStationWiseData[i].Yet_To_Start == "" ? "0.0" : subStationWiseData[i].Yet_To_Start), "#FF4255", "Yet To Start"));
                    }
                    else if (i == 2)
                    {
                        augmentationwises.Add(new AugmentationwiseSubstationcount("Completed", Convert.ToInt32(subStationWiseData[i].Completed == "" ? "0.0" : subStationWiseData[i].Completed), "#228B22", "Completed"));
                        augmentationwises.Add(new AugmentationwiseSubstationcount("In Progress", Convert.ToInt32(subStationWiseData[i].InProgress == "" ? "0.0" : subStationWiseData[i].InProgress), "#FFD142", "In Progress"));
                        augmentationwises.Add(new AugmentationwiseSubstationcount("Not Yet To Start", Convert.ToInt32(subStationWiseData[i].Yet_To_Start == "" ? "0.0" : subStationWiseData[i].Yet_To_Start), "#FF4255", "Yet To Start"));


                    }
                    else if (i == 3)
                    {
                        augmentations.Add(new SubStationWiseAUGMENTATION("Completed", Convert.ToDouble(subStationWiseData[i].Completed == "" ? "0.0" : subStationWiseData[i].Completed), "#228B22", "Completed"));
                        augmentations.Add(new SubStationWiseAUGMENTATION("In Progress", Convert.ToDouble(subStationWiseData[i].InProgress == "" ? "0.0" : subStationWiseData[i].InProgress), "#FFD142", "In Progress"));
                        augmentations.Add(new SubStationWiseAUGMENTATION("Not Yet To Start", Convert.ToDouble(subStationWiseData[i].Yet_To_Start == "" ? "0.0" : subStationWiseData[i].Yet_To_Start), "#FF4255", "Yet To Start"));

                    }

                }
                List<SubStationWiseLandCount> subStationsList1 = new List<SubStationWiseLandCount>();
                List<SubStationWiseLandCount> augmList1 = new List<SubStationWiseLandCount>();
                for (int i = 0; i < subStationWiseData.Count; i++)
                {
                    if (i == 0 || i == 1)
                    {
                        subStationsList1.Add(subStationWiseData[i]);
                    }
                    else if (i == 2 || i == 3)
                    {
                        augmList1.Add(subStationWiseData[i]);
                    }
                }

                ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);
                ViewBag.SolarCapacityCount = JsonConvert.SerializeObject(solarcapacityDataPoint);
                ViewData["SubStationWiseLand"] = subStationWiseData;
                ViewBag.SubStationData = subStationsList1;
                ViewBag.augmentationwisesCount = JsonConvert.SerializeObject(augmentationwises);
                ViewBag.augmentationsCount = JsonConvert.SerializeObject(augmentations);
                //List<SubStationWiseLandCount> augmentT
                ViewBag.AugmentationData = augmList1;
                ViewData["augmentations"] = subStationWiseData;
            }


            return View("DashBoard");
        }
        public ActionResult ViewSubStationData(int Dist_Code)
        {


            return RedirectToAction("SubstaionList", "SubstaionList", new { param1 = Dist_Code });
        }

        public ActionResult DistrictswiseSummary()
        {
            List<DistrictswiseSummary> districtswises = new List<DistrictswiseSummary>();
            districtswises = DashBoardService.GetDistrictsWiseSummary();

            ViewData["DistrictWiseCount"] = districtswises;



            return View("DistrictswiseSummary");
        }
    }
}