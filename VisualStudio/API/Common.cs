using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CommonLib.API
{
	/// <summary>
	/// 
	/// </summary>
	public sealed class Common
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonInclude]
		public static List<object> RegisteredGlobals = new();
	}
}
