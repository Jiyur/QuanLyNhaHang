using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    class Globals
    {
        public static int GlobalUserId { get; private set; }
        public static void SetGlobalUserID(int userID)
        {
            GlobalUserId = userID;
        }
        public static string GlobalUserName { get; private set; }
        public static void SetGlobalUserName(string userName)
        {
            GlobalUserName = userName;
        }
    }
}
