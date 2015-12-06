using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Winggit
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
