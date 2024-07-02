using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Utilities
{
	/// <summary>
	/// 
	/// </summary>
	public class SceneHelpers
	{
		#region TryGet
		/// <summary>
		/// Attempt to get the human readable name of a region
		/// </summary>
		/// <param name="name">The internal name of a region</param>
		/// <param name="value">The output of the quary</param>
		/// <returns><see langword="true"/> if the <see cref="Dictionary{TKey, TValue}"/> contains an element with the specific key, otherwise <see langword="false"/></returns>
		/// <remarks>
		/// The <see cref="KeyNotFoundException"/> is properly handled, printing the error to the log rather than throwing an exception. All other possible <see cref="Dictionary{TKey, TValue}.TryGetValue(TKey, out TValue)"/> exceptions are not handled
		/// </remarks>
		public static bool TryGetRegionName(string name, out string? value)
		{
			try
			{
				return RegionNames.TryGetValue(name, out value);
			}
			catch (KeyNotFoundException knfe)
			{
				Main.Logger.Log($"TryGetRegionName({name})::Value requested was not found in RegionNames", FlaggedLoggingLevel.Exception, knfe);
				try
				{
					return RegionNamesDLC01.TryGetValue(name, out value);
				}
				catch (KeyNotFoundException)
				{
					Main.Logger.Log($"TryGetRegionName({name})::Value requested was not found in RegionNamesDLC01", FlaggedLoggingLevel.Exception, knfe);
				}
			}
			value = null;
			return false;
		}
		#endregion

		#region Converters
		/// <summary>
		/// Contains definitions for the scenes in the game
		/// </summary>
		public static Dictionary<string, string> RegionNames = new()
		{
			{ "AshCanyonRegion", "Ash Canyon" },
			{ "BlackrockPrisonSurvivalZone", "Blackrock Prison Buildings" },
			{ "BlackrockRegion", "Blackrock" },
			{ "BlackrockTransitionZone", "KeeperU+2019s Pass North" },
			{ "Cannery", "Bleak Inlet" },
			{ "CanyonRoadTransitionZone", "KeeperU+2019s Pass South" },
			{ "CoastalRegion", "Coastal Highway" },
			{ "CrashMountainRegion", "Timberwolf Mountain" },
			{ "DamCaveTransitionZone", "Cave System" },
			{ "DamRiverTransitionZone", "Winding River" },
			{ "DamTransitionZone", "Lower Dam" },
			{ "HighwayMineTransitionZone", "UNKOWN" },
			{ "HighwayTransitionZone", "Crumbling Highway" },
			{ "LakeRegion", "Mystery Lake" },
			{ "MarshRegion", "Forlorn Muskeg" },
			{ "MineTransitionZone", "No. 3 Coal Mine" },
			{ "MountainTownRegion", "Mountain Town" },
			{ "RavineTransitionZone", "Revine" },
			{ "RiverValleyRegion", "Hushed River Valley" },
			{ "RuralRegion", "Pleasant Valley" },
			{ "TracksRegion", "Broken Railroad" },
			{ "WhalingStationRegion", "Desolation Point" }
		};

		/// <summary>
		/// Contains definitions for the scenes in the game for DLC01 or Tales From The Far Territory (TFTFT)
		/// </summary>
		public static Dictionary<string, string> RegionNamesDLC01 = new()
		{
			{ "AirfieldRegion", "Forsaken Airfield" },
			{ "HubRegion", "Transfer Pass" },
			{ "LongRailTransitionZone", "Far Range Branch Line" },
			{ "MiningRegion", "Zone of Contamination" }
		};

		/// <summary>
		/// 
		/// </summary>
		public static Dictionary<string, string> Interiors = new()
		{
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" },
			{ "", "" }
		};
		#endregion
	}
}
