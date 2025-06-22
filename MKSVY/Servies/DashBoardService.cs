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
    public class DashBoardService
    {
        public static List<DataPoint> GetDashBoardData(string dist_code)
        {
            //MySqlDataReader reader = null;
            MySqlCommand cmd = null;
            MySqlConnection MyCon = null;
            List<DataPoint> dataPoints = new List<DataPoint>();
            try
            {
                MyCon = ConnectionOpen.OpenConn();
                cmd = new MySqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetDahdBoardData";
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@getdistCode", dist_code);
                cmd.Connection = MyCon;
                MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    dataPoints.Add(new DataPoint("Completed", Convert.ToInt32(reader["Completed"]), "#228B22", "Completed"));
                    dataPoints.Add(new DataPoint("In Progress", Convert.ToInt32(reader["InProgress"]), "#FFD142", "In Progress"));
                    dataPoints.Add(new DataPoint("Not Yet To Start", Convert.ToInt32(reader["Yet_To_Start"]), "#FF4255", "Yet To Start"));
                    
                }
                //while(reader.Read())
                //{
                //    DistName distName = new DistName
                //    {
                //        DIST_NAME = reader["DIST_NAME"].ToString()
                //    };
                    
                //}
               
                //MyCon.Close();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                ConnectionOpen.CloseConn(MyCon);
            }
            
            return dataPoints;
        }
        public static List<DataPoint> GetDashBoardDataByDisttrict()
        {
            //MySqlDataReader reader = null;
            MySqlCommand cmd = null;
            MySqlConnection MyCon = null;
            List<DataPoint> dataPoints = new List<DataPoint>();
            try
            {
                MyCon = ConnectionOpen.OpenConn();
                cmd = new MySqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetDahdBoardData";
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@getdistCode", 502);
                cmd.Connection = MyCon;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dataPoints.Add(new DataPoint(" ", 1, " #808080", " "));
                    //dataPoints.Add(new DataPoint("Completed", 0, "#228B22", "Completed")); //Convert.ToInt32(reader["Completed"])
                    //dataPoints.Add(new DataPoint("Pending",0 , "#FFD142", "Pending"));//Convert.ToInt32(reader["Pending"])
                    //dataPoints.Add(new DataPoint("Not Yet To Start",0 , "#FF4255", "Yet To Start"));// Convert.ToInt32(reader["Yet_To_Start"])
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

            return dataPoints;
        }

        public static List<SubStationWiseLandCount> GetSubStationWiseLandCount(string dist_code)
        {
            //MySqlDataReader reader = null;
            MySqlCommand cmd = null;
            MySqlConnection MyCon = null;
            List<SubStationWiseLandCount> subStationWiseLands = new List<SubStationWiseLandCount>();
            try
            {
                MyCon = ConnectionOpen.OpenConn();
                cmd = new MySqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetSubStationWiseLandCount";
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@getdistCode", dist_code);
                cmd.Connection = MyCon;
                MySqlDataReader reader = cmd.ExecuteReader();
                //while (reader.Read())
                //{


                //}
                while (reader.Read())
                {
                    SubStationWiseLandCount subStationWise = new SubStationWiseLandCount
                    {
                        DIST_NAME = reader["DIST_NAME"].ToString(),
                        DIST_CODE = Convert.ToInt32(reader["DIST_CODE"]),
                        Completed = reader["Completed"].ToString(),
                        InProgress = reader["InProgress"].ToString(),
                        Yet_To_Start = reader["Yet_To_Start"].ToString(),
                        TotalSubStation = reader["TotalSubStation"].ToString(),
                        Record_Type = reader["Record_Type"].ToString(),
                        //TOTAL_LAND = Convert.ToDouble(reader["TOTAL_LAND"]),
                        //TOTAL_SOLAR_CAPACITY = Convert.ToDouble(reader["TOTAL_SOLAR_CAPACITY"])
                        
                    };
                    subStationWiseLands.Add(subStationWise);
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

            return subStationWiseLands;
        }


        public static List<AugmentationWiseCount> GetSubStationWiseAUGMENTATIONCount(string dist_code)
        {
            //MySqlDataReader reader = null;
            MySqlCommand cmd = null;
            MySqlConnection MyCon = null;
            List<AugmentationWiseCount> augmentationWiseCounts = new List<AugmentationWiseCount>();
            try
            {
                MyCon = ConnectionOpen.OpenConn();
                cmd = new MySqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetSubStationWise_AUGMENTATION_Y_N";
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@getdistCode", dist_code);
                cmd.Connection = MyCon;
                MySqlDataReader reader = cmd.ExecuteReader();
                //while (reader.Read())
                //{


                //}
                while (reader.Read())
                {
                    AugmentationWiseCount augmentationWise = new AugmentationWiseCount
                    {
                        DIST_NAME = reader["DIST_NAME"].ToString(),
                        DIST_CODE = Convert.ToInt32(reader["DIST_CODE"]),
                        Completed = reader["Completed"].ToString(),
                        InProgress = reader["InProgress"].ToString(),
                        Yet_To_Start = reader["Yet_To_Start"].ToString(),
                        TotalSubStation = reader["TotalSubStation"].ToString(),
                        Record_Type = reader["Record_Type"].ToString(),
                        //TOTAL_LAND = Convert.ToDouble(reader["TOTAL_LAND"]),
                        //TOTAL_SOLAR_CAPACITY = Convert.ToDouble(reader["TOTAL_SOLAR_CAPACITY"])

                    };
                    augmentationWiseCounts.Add(augmentationWise);
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

            return augmentationWiseCounts;
        }

        public static List<DistrictswiseSummary> GetDistrictsWiseSummary()
        {
            //MySqlDataReader reader = null;
            MySqlCommand cmd = null;
            MySqlConnection MyCon = null;
            List<DistrictswiseSummary> districtswiseSummaries = new List<DistrictswiseSummary>();
            try
            {
                MyCon = ConnectionOpen.OpenConn();
                cmd = new MySqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetDistrictWiseSummary";
                cmd.CommandTimeout = 0;
                //cmd.Parameters.AddWithValue("@getdistCode", 510);
                cmd.Connection = MyCon;
                MySqlDataReader reader = cmd.ExecuteReader();
                //while (reader.Read())
                //{


                //}
                while (reader.Read())
                {
                    DistrictswiseSummary districtswise = new DistrictswiseSummary
                    {
                        DIST_NAME = reader["DIST_NAME"].ToString(),
                        DIST_CODE =Convert.ToInt32(reader["DIST_CODE"]),
                        TotalLandRequired = Convert.ToDecimal(reader["TotalLandRequired"]),
                        TotalSolarCapacity = Convert.ToDecimal(reader["TotalSolarCapacity"]),
                        TotalLandRequiredwith_5_tolerance = Convert.ToDecimal(reader["TotalLandRequiredwith_5_tolerance"]),
                        TotalSubStation = reader["TotalSubStation"].ToString(),
                       

                    };
                    districtswiseSummaries.Add(districtswise);
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

            return districtswiseSummaries;
        }
        public static List<DistrictswiseSummary> GetAllDistricts()
        {
            //MySqlDataReader reader = null;
            MySqlCommand cmd = null;
            MySqlConnection MyCon = null;
            List<DistrictswiseSummary> districtswises = new List<DistrictswiseSummary>();
            try
            {
                MyCon = ConnectionOpen.OpenConn();
                cmd = new MySqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetALLDIstricts";
                cmd.CommandTimeout = 0;
                //cmd.Parameters.AddWithValue("@getdistCode", 510);
                cmd.Connection = MyCon;
                MySqlDataReader reader = cmd.ExecuteReader();
                //while (reader.Read())
                //{


                //}
                while (reader.Read())
                {
                    DistrictswiseSummary districts = new DistrictswiseSummary
                    {
                        //DIST_NAME = reader["DIST_NAME"].ToString(),
                        //DIST_CODE = Convert.ToInt32(reader["DIST_CODE"]),
                        //TotalLandRequired = Convert.ToDecimal(reader["TotalLandRequired"]),
                        //TotalSolarCapacity = Convert.ToDecimal(reader["TotalSolarCapacity"]),
                        //TotalLandRequiredwith_5_tolerance = Convert.ToDecimal(reader["TotalLandRequiredwith_5_tolerance"]),
                        //TotalSubStation = reader["TotalSubStation"].ToString(),
                        DIST_CODE = Convert.ToInt32(reader["DIST_CODE"]),
                        DIST_NAME = reader["DIST_NAME"].ToString(),
                        


                    };
                    districtswises.Add(districts);
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

            return districtswises;
        }

        public static List<SubStationWiseLandCount> GetSubStationWiseData(string dist_code,string augmny)
        {
            //MySqlDataReader reader = null;
            MySqlCommand cmd = null;
            MySqlConnection MyCon = null;
            List<SubStationWiseLandCount> subStationWiseLands = new List<SubStationWiseLandCount>();
            try
            {
                MyCon = ConnectionOpen.OpenConn();
                cmd = new MySqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetSubStationWiseData";
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@getdistCode", dist_code);
                cmd.Parameters.AddWithValue("@getAugyn", augmny);
                cmd.Connection = MyCon;
                MySqlDataReader reader = cmd.ExecuteReader();
                //while (reader.Read())
                //{


                //}
                while (reader.Read())
                {
                    SubStationWiseLandCount subStationWise = new SubStationWiseLandCount
                    {
                        DIST_NAME = reader["DIST_NAME"].ToString(),
                        DIST_CODE = Convert.ToInt32(reader["DIST_CODE"]),
                        Completed = reader["Completed"].ToString(),
                        InProgress = reader["InProgress"].ToString(),
                        Yet_To_Start = reader["Yet_To_Start"].ToString(),
                        TotalSubStation = reader["TotalSubStation"].ToString(),
                        Record_Type = reader["Record_Type"].ToString(),
                        //TOTAL_LAND = Convert.ToDouble(reader["TOTAL_LAND"]),
                        //TOTAL_SOLAR_CAPACITY = Convert.ToDouble(reader["TOTAL_SOLAR_CAPACITY"])

                    };
                    subStationWiseLands.Add(subStationWise);
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

            return subStationWiseLands;
        }
    }
}