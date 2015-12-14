using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winggit.Entities;
using static System.IO.Path;

namespace Winggit.Controls
{
    class FileIO
    {
       
        public FileIO()
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = @"Text Files|*.txt",
                Title = @"Please Select Your Sightings File"
            };
            if (ofd.ShowDialog() != DialogResult.OK) return;
            FileStream sightingsStream = File.OpenRead(ofd.FileName);
            ProcessFile(sightingsStream);
        }

        private void ProcessFile(FileStream fileStream)
        {
            
            
        }

        private void OutputFile()
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
