using System;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace BuildingBlocks.Class
{
    public class cHelper
    {
        public static Image C_CONVoBase64ToImage(string base64String)
        {
            // Convert Base64 string to byte array
            byte[] aoImgBytes = Convert.FromBase64String(base64String);

            // Create MemoryStream from byte array
            using (MemoryStream ms = new MemoryStream(aoImgBytes))
            {
                // Create Image from MemoryStream
                Image oImage = Image.FromStream(ms);
                return oImage;
            }
        }
    }
}
