using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSTD.Class
{
    public class cSP
    {
		/// <summary>
		/// Function Check X-Api-Key
		/// </summary>
		/// <param name="poHttpConext"></param>
		/// <param name="ptErr"></param>
		/// <returns></returns>
		public bool C_CHKbKeyApiConfig(HttpContext poHttpConext, out string ptErr)
		{
			IHeaderDictionary oReqHeaders;
			StringValues oClientAPIKey;

			string tClientAPIKey;
			string tConfigAPIKey;
			ptErr = "";

			try
			{
				//Webservice X-Api-Key Value
				tConfigAPIKey = cVB.oVB_AppSettings.tAccess;

				if (!string.IsNullOrEmpty(tConfigAPIKey))
				{
					//Get X-Api-Key Client Request
					oReqHeaders = poHttpConext.Request.Headers;
					if (oReqHeaders.TryGetValue("X-Api-Key", out oClientAPIKey) == false)
					{
						throw new Exception("Key not Allow");
					}
                    else
                    {
						tClientAPIKey = oClientAPIKey.FirstOrDefault();
						if (tClientAPIKey != tConfigAPIKey)
						{
							throw new Exception("Key not Allow");
						}
					}
				}
                else
                {
					//ไม่ต้องเช็ค
                }

				return true;
			}
			catch (Exception oEx)
			{
				ptErr = oEx.Message;
				return false;
			}
			
		}
	}
}
