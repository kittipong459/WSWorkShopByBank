using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace wModels.Class
{
    public static class cLog
    {

        public static void C_WRTxLog(string ptForm, string ptFunction, bool pbAlwPrn = true) 
        {
            string tPath;

            try
            {
                if (pbAlwPrn == false) return; 
                if (!Directory.Exists(@"D:\Bank\workshop\Logs\Log"))
                    Directory.CreateDirectory(@"D:\Bank\workshop\Logs\Log");

                tPath = @"D:\Bank\workshop\Logs\Log\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";

                if (!File.Exists(tPath))
                    File.Create(tPath).Dispose();

                using (StreamWriter oOutputFile = new StreamWriter(tPath, true))
                {
                    string tVersion = "1.0";   
                    string tMsg = tVersion + " : " + DateTime.Now.ToString("HH:mm:ss.fff") + " : Form (" + ptForm + ") > " + ptFunction;
                    oOutputFile.WriteLine(tMsg);
                    oOutputFile.Dispose();
                }
            }
            catch (Exception oEx) { Debug.WriteLine(oEx.ToString()); }
            finally
            {
                tPath = null;
                ptForm = null;
                ptFunction = null;
            }
        }
    }
}
