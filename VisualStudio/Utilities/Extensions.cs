// ---------------------------------------------
// Extensions - by The Illusion
// ---------------------------------------------
// Reusage Rights ------------------------------
// You are free to use this script or portions of it in your own mods, provided you give me credit in your description and maintain this section of comments in any released source code
//
// Warning !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
// Ensure you change the namespace to whatever namespace your mod uses, so it doesnt conflict with other mods
// ---------------------------------------------
using Il2CppTLD.IntBackedUnit;

namespace CommonLib.Utilities
{
	/// <summary>
	/// Class containing all extensions
	/// </summary>
	public static class Extensions
	{
		/// <summary>
		/// Gets every class that is derived from another
		/// </summary>
		/// <typeparam name="T">The typeof for the base class</typeparam>
		/// <param name="constructorArgs">Any extra arguments</param>
		/// <returns>A list of classes that are derived from <typeparamref name="T"/></returns>
		public static System.Collections.Generic.IEnumerable<T>? GetEnumerableOfType<T>(params object[] constructorArgs) where T : class
		{
			if (typeof(T) == null) return null;

			System.Collections.Generic.List<T?> objects = new();

#pragma warning disable CS8602
			foreach (var type in System.Reflection.Assembly.GetAssembly(typeof(T)).GetTypes().Where(
				t => t.IsClass
				&& !t.IsAbstract
				&& t.IsSubclassOf(typeof(T))
				))
			{
				objects.Add(System.Activator.CreateInstance(type, constructorArgs) as T);
			}
#pragma warning restore CS8602

			try
			{
				objects?.Sort();
			}
			catch (System.InvalidOperationException e)
			{
				Main.Logger.Log($"GetEnumerableOfType::Attempting to sort the objects list failed", FlaggedLoggingLevel.Exception, e);
			}

#pragma warning disable CS8619
			// returns null if the list is null or has nothing in it
			return (objects == null) ? null : (objects.Count > 0) ? objects : null;
#pragma warning restore CS8619
		}
		#region ItemWeight and ItemLiquidVolume extensions
		/// <summary>
		/// 
		/// </summary>
		/// <param name="itemWeight"></param>
		/// <returns></returns>
		public static double GetValueFromItemWeight(this ItemWeight itemWeight)
		{
			return itemWeight.ToQuantity(itemWeight.m_Units);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="volume"></param>
		/// <returns></returns>
		public static double GetLiquidLitersFromItemLiquidVolume(this ItemLiquidVolume volume)
		{
			return volume.ToQuantity(ItemLiquidVolume.Liter.m_Units);
		}
		#endregion
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="obj"></param>
		/// <returns></returns>
		public static T DontUnload<T>(this T obj) where T : UnityEngine.Object
		{
			obj.hideFlags |= HideFlags.DontUnloadUnusedAsset;

			return obj;
		}
	}
}
