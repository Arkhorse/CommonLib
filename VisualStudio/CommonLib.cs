#region System Directives
global using System;
global using System.Text;
global using System.Text.RegularExpressions;
#endregion
#region Unity Directives
global using UnityEngine.UIElements;
global using UnityEngine.AddressableAssets;
#endregion
#region Mod Directives
global using CommonLib.API;
global using CommonLib.Utilities;
global using CommonLib.Utilities.Enums;
global using CommonLib.Utilities.Exceptions;
global using CommonLib.Utilities.JSON;
global using ComplexLogger;
#endregion

namespace CommonLib
{

    /// <inheritdoc/>
	public class Main : MelonMod
	{
        /// <summary>
        /// 
        /// </summary>
        public static ComplexLogger<Main> Logger = new();

		/// <summary>
		/// 
		/// </summary>
		[JsonInclude]
		public static List<object> RegisteredGlobals = new();

		/// <summary>
		/// 
		/// </summary>
		public static Globals Globals = new();

		/// <inheritdoc/>
		public override void OnInitializeMelon()
        {

        }
    }
}
