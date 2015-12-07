using System.Data;

namespace Winggit.Entities
{
    class Winger
    {
        private int wingerNum;
        private string name;
        private string address;
        private string phoneNum;
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
