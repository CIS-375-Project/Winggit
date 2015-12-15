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
                string something = "other";
            }
                }

        private static bool isBlank(String s)
                {
            return s.ToLower().Equals("");
        }

        static void FileOutput()
        {
            

            Hashtable oHash = new Hashtable();
            string sqlOnTag =
                "SELECT * FROM Tags AS T JOIN Butterflies AS B ON T.ButterflyID = B.ButterflyID WHERE B.Tracker_Num = @Tracker_Num";
            //if user is downloading after specifying a tag#
            using (DataSet oDataSet = DBFunctions.GetDataSet(sqlOnTag, oHash))
            {
                string[] lines = {"", ""};

            }

            oHash = new Hashtable();

            string sqlOnLocation = "SELECT * FROM Tags WHERE City = @City, State = @State";
            
            //if user is downloading after specifying a location
            using (DataSet oDataSet = DBFunctions.GetDataSet(sqlOnLocation, oHash))
            {
                string[] lines = {"", ""};

                File.WriteAllLines(@"C:\Users\Public\Test Folder\output.txt", lines);
            }
        }
    }
}
