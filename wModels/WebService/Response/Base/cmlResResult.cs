using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingBlocks.Models.WebService.Response.Base
{
    /// <summary>
    /// Response Result String
    /// </summary>
	public class cmlResResult : cmlResBase
    {
        /// <summary>
        /// String Result.
        /// </summary>
        public string rtResult { get; set; }
    }
}
