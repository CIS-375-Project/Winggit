using System.Data;

namespace Winggit.Entities
{
    class Butterfly
    {
        private int butterflyID;
        private int wingspan;
        private string species;
        private string gender;
        private int trackerNumber;
        public static Butterfly currentButterfly;

        public Butterfly(DataRow oRow)
        {
            butterflyID = int.Parse(oRow["ButterflyID"].ToString());
            wingspan = int.Parse(oRow["Wingspan"].ToString());
            species = oRow["Species"].ToString();
            gender = oRow["Gender"].ToString();
            trackerNumber = int.Parse(oRow["Tracker_Num"].ToString());
        }

        public int ButterflyID
        {
            get
            {
                return butterflyID;
            }
        }

        public int Wingspan
        {
            get
            {
                return wingspan;
            }
        }

        public string Species
        {
            get
            {
                return species;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }
        }

        public int TrackerNumber
        {
            get
            {
                return trackerNumber;
            }
        }
    }
}
