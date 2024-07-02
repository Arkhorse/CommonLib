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
global using CommonLib.Utilities;
global using CommonLib.Utilities.Enums;
global using CommonLib.Utilities.Exceptions;
global using CommonLib.Utilities.JSON;
global using ComplexLogger;
#endregion

using System.Text.Json.Serialization;

namespace CommonLib
{
    /// <inheritdoc/>
	internal class Main : MelonMod
	{
		/// <summary>
		/// 
		/// </summary>
		internal static ComplexLogger<Main> Logger = new();
		/// <inheritdoc/>
		public override void OnInitializeMelon()
        {

        }
    }
}
