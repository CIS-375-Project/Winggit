﻿using System;
using System.Data;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace Winggit.Controls
{
    internal static class FileIO
    {
       
        public static void FileInput()
        {
            // Takes in a file in the format provied by Prof Steiner and added Tags/Sightings into the database
            Hashtable oHash = new Hashtable();
            string sql;
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = @"Text Files|*.txt",
                Title = @"Please Select Your Sightings File"
            };
            if (ofd.ShowDialog() != DialogResult.OK) return;
            string[] file = File.ReadAllLines(ofd.FileName);
            int numRecords = int.Parse(file[file.Length - 1].Substring(3, 6).Trim());
            int fileNum = int.Parse(file[0].Substring(3, 6).Trim());
            sql = "SELECT LastUpload FROM Upload";
            using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
            {
                if (fileNum - int.Parse(oDataSet.Tables[0].Rows[0]["LastUpload"].ToString()) != 1)
                {
                    return;
                }
            }
            if (numRecords == (file.Length - 2))
            {
                for (int i = 1; i < (file.Length - 1); i++)
                {
                    oHash = new Hashtable();
                    while (file[i].Length <= 172)
                    {
                        file[i] += " ";
                    }
                    string type = file[i].Substring(0, 1);
                    string user = file[i].Substring(1, 11).Trim();
                    string date = file[i].Substring(11, 20).Trim();
                    string latlong = file[i].Substring(31, 23);
                    string lat = latlong.Substring(0, 12);
                    string log = latlong.Substring(12, 11);
                    string city = file[i].Substring(54, 30).Trim();
                    string state = file[i].Substring(85, 10).Trim();
                    string country = file[i].Substring(110, 10).Trim();
                    string species = file[i].Substring(145, 17).Trim();
                    string tag = file[i].Substring(162, 9).Trim();
                    if (type == "T")
                    {
                        Random rnd = new Random();
                        int pTag = rnd.Next(999999999);
                        oHash.Add("@Tracker", pTag);
                        sql = "SELECT * FROM Butterflies WHERE Tracker_Num = @Tracker";
                        DataSet check = DBFunctions.GetDataSet(sql, oHash);
                        while (check.Tables[0].Rows.Count != 0)
                        {
                            pTag = rnd.Next(999999999);
                            oHash = new Hashtable();
                            oHash.Add("@Tracker", pTag);
                            sql = "SELECT * FROM Butterflies WHERE Tracker_Num = @Tracker";
                            check = DBFunctions.GetDataSet(sql, oHash);
                        }
                        check.Dispose();
                        oHash.Add(@"Species", species);
                        sql = "INSERT INTO Butterflies OUTPUT Inserted.* VALUES(0,@Species,'Unknown',@Tracker)";
                        using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
                        {
                            sql = "INSERT INTO Tags VALUES(";
                            if (string.IsNullOrEmpty(date))
                            {
                                continue;
                            }
                            oHash.Add("@Date", DateTime.Parse(date));
                            sql += "@Date,";
                            if (string.IsNullOrEmpty(city))
                            {
                                sql += "NULL,";
                            }
                            else
                            {
                                oHash.Add("@City", city);
                                sql += "@City,";
                            }
                            if (string.IsNullOrEmpty(state))
                            {
                                sql += "NULL,";
                            }
                            else
                            {
                                oHash.Add("@State", state);
                                sql += "@State,";
                            }
                            if (string.IsNullOrEmpty(country))
                            {
                                sql += "NULL,";
                            }
                            else
                            {
                                oHash.Add("@Country", country);
                                sql += "@Country,";
                            }
                            sql += "NULL,";
                            if (string.IsNullOrEmpty(user))
                            {
                                continue;
                            }
                            oHash.Add("@UserID", int.Parse(user));
                            sql += "@UserID,1,";
                            decimal temp1 = decimal.Parse(lat);
                            decimal temp2 = decimal.Parse(log);
                            if (temp1 != 0 || temp2 != 0)
                            {
                                oHash.Add("@lat", temp1);
                                oHash.Add("@long", temp2);
                                sql += "@lat,@long,";
                            }
                            else
                            {
                                sql += "NULL,NULL,";
                            }
                            oHash.Add("@ID", oDataSet.Tables[0].Rows[0]["ButterflyID"]);
                            sql += "@ID)";
                            DBFunctions.RunQuery(sql, oHash);
                        }
                    }
                    else if (type == "S" && !string.IsNullOrEmpty(tag))
                    {
                        oHash = new Hashtable();
                        oHash.Add("@Tracker", tag);
                        sql = "SELECT ButterflyID FROM Butterflies WHERE Tracker_Num = @Tracker";
                        using (DataSet oDataSet = DBFunctions.GetDataSet(sql, oHash))
                        {
                            sql = "INSERT INTO Tags VALUES(";
                            if (string.IsNullOrEmpty(date))
                            {
                                continue;
                            }
                            oHash.Add("@Date", DateTime.Parse(date));
                            sql += "@Date,";
                            if (string.IsNullOrEmpty(city))
                            {
                                sql += "NULL,";
                            }
                            else
                            {
                                oHash.Add("@City", city);
                                sql += "@City,";
                            }
                            if (string.IsNullOrEmpty(state))
                            {
                                sql += "NULL,";
                            }
                            else
                            {
                                oHash.Add("@State", state);
                                sql += "@State,";
                            }
                            if (string.IsNullOrEmpty(country))
                            {
                                sql += "NULL,";
                            }
                            else
                            {
                                oHash.Add("@Country", country);
                                sql += "@Country,";
                            }
                            sql += "NULL,";
                            if (string.IsNullOrEmpty(user))
                            {
                                continue;
                            }
                            oHash.Add("@UserID", int.Parse(user));
                            sql += "@UserID,0,";
                            decimal temp1 = decimal.Parse(lat);
                            decimal temp2 = decimal.Parse(log);
                            if (temp1 != 0 || temp2 != 0)
                            {
                                oHash.Add("@lat", temp1);
                                oHash.Add("@long", temp2);
                                sql += "@lat,@long,";
                            }
                            else
                            {
                                sql += "NULL,NULL,";
                            }
                            oHash.Add("@ID", int.Parse(oDataSet.Tables[0].Rows[0]["ButterflyID"].ToString()));
                            sql += "@ID)";
                            DBFunctions.RunQuery(sql, oHash);
                        }   
                    }
                }
            }
            oHash = new Hashtable();
            oHash.Add("@Last", fileNum);
            sql = "UPDATE Upload SET LastUpload = @Last WHERE InUse = 1";
            DBFunctions.RunQuery(sql, oHash);
        }
    }
}
