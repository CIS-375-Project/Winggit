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
            DateTime testDate;
            int testTag;
            FixedWidthParser parser = new FixedWidthParser
            (
                ofd.FileName,
                new List<dynamic>
                {
                    new FixedWidthColumn<DateTime>
                    (
                        "date",
                        19,
                        DateTime.Parse,
                        date => date.ToString(@"yyyy-MM-dd"),
                        test => DateTime.TryParse(test, out testDate)
                    ),
                    new FixedWidthColumn<string>
                    (
                        "latlong",
                        22, // TODO might be 24
                        latLongString => latLongString,
                        latLong => latLong,
                        test => true
                    ),
                    new FixedWidthColumn<string>
                    (
                        "city",
                        29, // TODO might be 31
                        cityString => cityString.Trim(),
                        city => city,
                        test => true
                    ),
                    new FixedWidthColumn<string>
                    (
                        "stateprov",
                        29, // TODO might be 31
                        stateProvString => stateProvString.Trim(),
                        stateProv => stateProv,
                        test => true
                    ),
                    new FixedWidthColumn<string>
                    (
                        "country",
                        29, // TODO Verify length of country
                        countryString => countryString.Trim(),
                        country => country,
                        test => true
                    ),
                    new FixedWidthColumn<string>
                    (
                        "species",
                        20,
                        speciesString => speciesString.Trim(),
                        species => species,
                        test => true
                    ),
                    new FixedWidthColumn<int>
                    (
                        "tag",
                        11,
                        int.Parse,
                        tagString => tagString.ToString(),
                        test => int.TryParse(test, out testTag)
                    )
                }
            );
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
