using System.Data;

namespace Winggit.Entities
{
    class Winger
    {
        private int wingerNum;
        private string name;
        private string address;
        private string city;
        private string state;
        private string country;
        private string phoneNum;
        public static Winger currentWinger;

        public Winger(DataRow oRow)
        {
            wingerNum = int.Parse(oRow["WingerNum"].ToString());
            name = oRow["Name"].ToString();
            address = oRow["Address"].ToString();
            city = oRow["City"].ToString();
            state = oRow["State"].ToString();
            country = oRow["Country"].ToString();
            phoneNum = oRow["PhoneNum"].ToString();
        }

        public int WingerNum
        {
            get
            {
                return wingerNum;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
        }

        public string State
        {
            get
            {
                return state;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }
        }

        public string PhoneNum
        {
            get
            {
                return phoneNum;
            }
        }
    }
}
