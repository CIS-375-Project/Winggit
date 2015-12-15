using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleFixedWidthParser;
using Winggit.Entities;
using Winggit.Enums;
using static System.IO.Path;

namespace Winggit.Controls
{
    internal static class FileIO
    {
       
        public static void FileInput()
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = @"Text Files|*.txt",
                Title = @"Please Select Your Sightings File"
            };
            if (ofd.ShowDialog() != DialogResult.OK) return;
            string[] file = File.ReadAllLines(ofd.FileName);
            for (int i = 1; i < 6; i++)
            {
                List <string> parts = file[i].Split(' ').ToList();
                parts.RemoveAll(isBlank);
                if (parts.Count < 10)
                {
                    MessageBox.Show(@"Not enough info given.", @"Insufficient info", MessageBoxButtons.OK);
                    continue;
                }
                if (parts[1].Any(char.IsLetter)) // IDs don't have letters.
                {
                    MessageBox.Show(@"ID is not a number.", @"Invalid ID", MessageBoxButtons.OK);
                    continue;
                }
                DateTime testDate;
                if (!DateTime.TryParse(parts[2] + " " + parts[3], out testDate))
                {
                    MessageBox.Show(@"Date cannot be parsed.", @"Invalid Date", MessageBoxButtons.OK);
                    continue;
                }
                if (parts[4].Length != 22)
                {
                    MessageBox.Show(@"Latitude and Longitude not valid.", @"Invalid Lat/Long", MessageBoxButtons.OK);
                    continue;
                }
                double lat = double.Parse(parts[4].Substring(1, 10));
                lat *= parts[4][0] == '-' ? -1 : 1;
                double longit = double.Parse(parts[4].Substring(12));
                longit *= parts[4][11] == '-' ? -1 : 1;

                if (parts[7] != "USA" && parts[7] != "Canada")
                {
                    MessageBox.Show(@"Not USA or Canada.", @"Invalid country", MessageBoxButtons.OK);
                    continue;
                }
                List<string> statesProvs = parts[7] == "USA" ? Enum.GetNames(typeof (State)).ToList() : Enum.GetNames(typeof (Province)).ToList();
                if (!statesProvs.Contains(parts[6]))
                {
                    MessageBox.Show(@"State/Province not valid.", @"Invalid state/province", MessageBoxButtons.OK);
                    continue;
                }
                // TODO deal with multiword cities.

                
            }
        }

        private static bool isBlank(String s)
        {
            return s.ToLower().Equals("");
        }

        static void FileOutput()
        {
            

            Hashtable oHash = new Hashtable();
            oHash.Add("@");
            string sqlOnTag =
                "SELECT * FROM Tags AS T JOIN Butterflies AS B ON T.ButterflyID = B.ButterflyID WHERE B.Tracker_Num = @Tracker_Num";
            //if user is downloading after specifying a tag#
            using (DataSet oDataSet = DBFunctions.GetDataSet(sqlOnTag, oHash))
            {
                string[] lines = new string[100];
                

                foreach (DataRow oRow in oDataSet.Tables[0].Rows)
                {
                    
                }

            }

            oHash = new Hashtable();

            string sqlOnLocation = "SELECT * FROM Tags WHERE City = @City, State = @State";
            
            //if user is downloading after specifying a location
            using (DataSet oDataSet = DBFunctions.GetDataSet(sqlOnLocation, oHash))
            {
                string[] lines = {"", ""};

                foreach (DataRow oRow in oDataSet.Tables[0].Rows)
                {
                    
                }

                File.WriteAllLines(@"C:\Users\Public\Test Folder\output.txt", lines);
            }
        }
    }
}
