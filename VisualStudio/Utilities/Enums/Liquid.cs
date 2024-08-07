// ---------------------------------------------
// Liquid - by The Illusion
// ---------------------------------------------
// Reusage Rights ------------------------------
// You are free to use this script or portions of it in your own mods, provided you give me credit in your description and maintain this section of comments in any released source code
//
// Warning !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
// Ensure you change the namespace to whatever namespace your mod uses, so it doesnt conflict with other mods
// ---------------------------------------------

namespace CommonLib.Utilities.Enums
{
	/// <summary>
	/// The game used to have this enum, this just recreats it for use in <see cref="LiquidUtilities.TryGetLiquid(Liquid)"/>
	/// </summary>
	public enum Liquid
    {
        /// <summary>Drinkable Water</summary>
        Potable,
		/// <summary>Unsafe Water</summary>
		NonPotable,
		/// <summary>Kerosene</summary>
		Kerosene,
		/// <summary>Antiseptic</summary>
		Antiseptic
	}
}
