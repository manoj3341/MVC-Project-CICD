using MKSVY.Common;
using MKSVY.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MKSVY.Servies
{
    public class SubStationListServices
    {
        public static List<SubstaionList> GetSubStationList(int Dist_Code, string status1)
        {
            //MySqlDataReader reader = null;
            MySqlCommand cmd = null;
            MySqlConnection MyCon = null;
            List<SubstaionList> substaionLists = new List<SubstaionList>();
            try
            {
                MyCon = ConnectionOpen.OpenConn();
                cmd = new MySqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetSubStationListData";
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@getdistCode", Dist_Code);
                cmd.Parameters.AddWithValue("@Status1", status1);
                cmd.Connection = MyCon;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SubstaionList substaion = new SubstaionList
                    {
                        DIST_CODE = Convert.ToInt32(reader["DIST_CODE"]),
                        DIST_NAME = reader["DIST_NAME"].ToString(),
                        TALUKA_CODE = Convert.ToInt32(reader["TALUKA_CODE"]),
                        TALUKA_NAME = reader["TALUKA_NAME"].ToString(),
                        SUBDIVISION = reader["SUBDIVISION"].ToString(),
                        SUBSTATION_NAME = reader["SUBSTATION_NAME"].ToString(),
                        SUBSTATION_NO = reader["SUBSTATION_NO"].ToString(),
                        SOLAR_CAPACITY_MW = Convert.ToDecimal(reader["SOLAR_CAPACITY_MW"]),
                        LAND_REQUIRED_IN_ACRE = Convert.ToDecimal(reader["LAND_REQUIRED_IN_ACRE"]),
                        GOVT_FEASIBLE_LANDS = Convert.ToInt32(reader["GOVT_FEASIBLE_LANDS"]),
                        GOVT_FEASIBLE_LANDS_ACRE = Convert.ToDecimal(reader["GOVT_FEASIBLE_LANDS_ACRE"]),
                        PVT_FEASIBLE_LANDS = Convert.ToInt32(reader["PVT_FEASIBLE_LANDS"]),
                        PVT_FEASIBLE_LANDS_ACRE = Convert.ToDecimal(reader["PVT_FEASIBLE_LANDS_ACRE"]),
                        PROPOSAL_SUBMITED_LANDS = Convert.ToInt32(reader["PROPOSAL_SUBMITED_LANDS"]),

                        PROPOSAL_SUBMITED_ARCE = Convert.ToDecimal(reader["PROPOSAL_SUBMITED_ARCE"]),
                        POSSION_RCVD_LAND = Convert.ToInt32(reader["POSSION_RCVD_LAND"]),
                        POSSION_RCVD_AREA = Convert.ToDecimal(reader["POSSION_RCVD_AREA"]),
                        USEFUL_LAND = Convert.ToDecimal(reader["USEFUL_LAND"]),



                    };
                    substaionLists.Add(substaion);
                    //dataPoints.Add(new DataPoint("Completed", Convert.ToInt32(reader["Completed"]), "Green", "Completed"));
                    //dataPoints.Add(new DataPoint("Pending", Convert.ToInt32(reader["Pending"]), "Orange", "Pending"));
                    //dataPoints.Add(new DataPoint("Not Yet To Start", Convert.ToInt32(reader["Not_Yet_To_Start"]), "Red", "Not Yet To Start"));
                }

                //MyCon.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                ConnectionOpen.CloseConn(MyCon);
            }

            return substaionLists;
        }

        public static List<LandClearance> GetLandClearanceByID(int Dist_Code,string substation_No)
        {
            //MySqlDataReader reader = null;
            MySqlCommand cmd = null;
            MySqlConnection MyCon = null;
            List<LandClearance> substaionLists = new List<LandClearance>();
            try
            {
                MyCon = ConnectionOpen.OpenConn();
                cmd = new MySqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetLandClearanceDetails";
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@getdistcode", Dist_Code);
                cmd.Parameters.AddWithValue("@getsubstationno", substation_No);
                cmd.Connection = MyCon;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LandClearance substaion = new LandClearance
                    {
                        Land_Type = reader["PRIV_GOVT_LAND"].ToString(),//Remaining
                        Land_Owner = reader["APPLICANT_NAME"].ToString(),
                        Water_Source = reader["WATER_SRC_AVBL"].ToString(),
                        SUBSTATION_NUMBER = reader["SUBSTATION_NUMBER"].ToString(),
                        SUBSTATION_NAME = reader["SUBSTATION_NAME"].ToString(),
                        Mobile_No = reader["MOBILE_NO"].ToString(),
                        Taluka = reader["TALUKA_NAME"].ToString(),
                        Village = reader["VILLAGE_NAME"].ToString(),
                        Gram_Panchayat = reader["GRAMPANCHAYAT_NAME"].ToString(),
                        Survey_No = reader["LAND_SURVEY_NO"].ToString(),
                        Latitude = reader["LAND_LATITUDE"].ToString(),
                        Longitude = reader["LAND_LONGITUDE"].ToString(),
                        Area_Acres = reader["LAND_AREA_IN_ACRE"].ToString(),
                        Aerial_Dist_KM_ = reader["DISTANCE_FROM_SS_IN_KM"].ToString(),
                        Land_Lease = reader["FINAL_LEASE_Y_N"].ToString(),//remaining
                        TILR_NOC = reader["TILRNOC_Y_N"].ToString(),

                        ZP_NOC = reader["ZPNOC_Y_N"].ToString(),
                        Rehibili_NOC = reader["REHIBALATIONNOC_Y_N"].ToString(),
                        Forest_NOC = reader["FORESTNOC_Y_N"].ToString(),
                        TP_NOC = reader["TPDNOC_Y_N"].ToString(),
                        Irrigation_NOC = reader["IRRDNOC_Y_N"].ToString(),
                        Mining_NOC = reader["MININGNOC_Y_N"].ToString(),
                        PWD_NOC = reader["PWDNOC_Y_N"].ToString(),
                        Proposal_To_Collector = reader["SEND_PROPOSAL_COLLECTOR"].ToString(),
                        JM_Land_Status = reader["JM_LAND_STATUS"].ToString(),
                        possession_done_not = reader["POSSESSION_DONE_NOT"].ToString(),
                       
                    };
                    substaionLists.Add(substaion);
                    //dataPoints.Add(new DataPoint("Completed", Convert.ToInt32(reader["Completed"]), "Green", "Completed"));
                    //dataPoints.Add(new DataPoint("Pending", Convert.ToInt32(reader["Pending"]), "Orange", "Pending"));
                    //dataPoints.Add(new DataPoint("Not Yet To Start", Convert.ToInt32(reader["Not_Yet_To_Start"]), "Red", "Not Yet To Start"));
                }

                //MyCon.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                ConnectionOpen.CloseConn(MyCon);
            }

            return substaionLists;
        }



    }
}