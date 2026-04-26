using PasteEx.Forms;
using PasteEx.Util;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PasteEx
{
    public class Client
    {
        public static string GUID;

        public static void Start()
        {
            string currentVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            GAHelper.Instance.RequestPageView(String.Format("/main/{0}", currentVersion), String.Format("进入{0}版本主界面", currentVersion));
        }
    }
}
