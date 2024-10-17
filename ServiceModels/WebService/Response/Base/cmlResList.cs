using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingBlocks.Models.WebService.Response.Base
{
    /// <summary>
    /// Response Object by List
    /// </summary>
    /// <typeparam name="T"></typeparam>
	public class cmlResList<T> : cmlResBase
    {
        /// <summary>
        /// Array Obj Item Return.
        /// </summary>
        public List<T> raItems { get; set; }
    }
}
