using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingBlocks.Models.WebService.Response.Base
{
    /// <summary>
    /// Response an Object
    /// </summary>
    /// <typeparam name="T"></typeparam>
	public class cmlResObject<T> : cmlResBase
    {
        /// <summary>
        /// Obj Item Return.
        /// </summary>
        public T roItem { get; set; }
    }
}
