global using System.Text.Json.Serialization;
using System.ComponentModel;

namespace CommonLib.API
{
	/// <summary>
	/// 
	/// </summary>
	public class Globals : INotifyPropertyChanged
	{
		public Globals() { }

		public object value;

		public event PropertyChangedEventHandler? PropertyChanged;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="global"></param>
		public void RegisterGlobal(object global)
		{
			Main.RegisteredGlobals.Add(global);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="global"></param>
		/// <returns></returns>
		public object GetGlobal(object global)
		{
			return Main.RegisteredGlobals.First(f => f.Equals(global));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="global"></param>
		/// <returns></returns>
		public bool RemoveGlobal(object global)
		{
			try
			{
				Main.RegisteredGlobals.Remove(global);
				return true;
			}
			catch (Exception e)
			{
				Main.Logger.Log($"Attempting to remove global {global.ToString()} failed", FlaggedLoggingLevel.Exception, e);
				return false;
			}
		}
	}
}
