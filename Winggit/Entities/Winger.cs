using System.Data;

namespace Winggit.Entities
{
    class Winger
    {
        public int wingerNum;
        public string name;
        public string address;
        public string phoneNum;
        public static Winger currentWinger;

        public Winger(DataRow oRow)
        {
            wingerNum = int.Parse(oRow["WingerNum"].ToString());
            name = oRow["Name"].ToString();
            address = oRow["Address"].ToString();
            phoneNum = oRow["PhoneNum"].ToString();
        }
    }
}
