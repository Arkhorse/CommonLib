// ---------------------------------------------
// AiUtilities - by The Illusion
// ---------------------------------------------
// Reusage Rights ------------------------------
// You are free to use this script or portions of it in your own mods, provided you give me credit in your description and maintain this section of comments in any released source code
//
// Warning !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
// Ensure you change the namespace to whatever namespace your mod uses, so it doesnt conflict with other mods
// ---------------------------------------------

namespace CommonLib.Utilities
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	public static class AiUtilities
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	{
		/// <summary>
		/// Checks if the current BaseAi is a ptarmigan
		/// </summary>
		/// <param name="baseAi">The BaseAi instance</param>
		/// <returns></returns>
		public static bool IsPtarmigan(BaseAi baseAi) => baseAi.Ptarmigan != null;
		/// <summary>
		/// Checks if the current BaseAi is a rabbit
		/// </summary>
		/// <param name="baseAi">The BaseAi instance</param>
		/// <returns></returns>
		public static bool IsRabbit(BaseAi baseAi) => baseAi.Rabbit != null;
		/// <summary>
		/// Gets all Deer
		/// </summary>
		/// <param name="baseAi">The BaseAi instance</param>
		/// <returns></returns>
		public static bool IsBaseDeer(BaseAi baseAi) => baseAi.BaseDeer != null;
		/// <summary>
		/// Checks if the current BaseAi is a doe
		/// </summary>
		/// <param name="baseAi">The BaseAi instance</param>
		/// <returns></returns>
		public static bool IsDoe(BaseAi baseAi) => baseAi.Doe != null;
		/// <summary>
		/// Checks if the current BaseAi is a Normal Stag
		/// </summary>
		/// <param name="baseAi">The BaseAi instance</param>
		/// <returns></returns>
		public static bool IsStag(BaseAi baseAi) => baseAi.Stag != null;
		/// <summary>
		/// Checks if the current BaseAi is a White Stag
		/// </summary>
		/// <param name="baseAi">The BaseAi instance</param>
		/// <returns></returns>
		public static bool IsStagWhite(BaseAi baseAi) => baseAi.StagWhite != null;
		/// <summary>
		/// Checks if the current BaseAi is a Moose
		/// </summary>
		/// <param name="baseAi">The BaseAi instance</param>
		/// <returns></returns>
		public static bool IsMoose(BaseAi baseAi) => baseAi.Moose != null;
		/// <summary>
		/// Gets all wolves
		/// </summary>
		/// <param name="baseAi">The BaseAi instance</param>
		/// <returns></returns>
		public static bool IsBaseWolf(BaseAi baseAi) => baseAi.BaseWolf != null;
		/// <summary>
		/// Checks if the current BaseAi is a normal wolf
		/// </summary>
		/// <param name="baseAi">The BaseAi instance</param>
		/// <returns></returns>
		public static bool IsNormalWolf(BaseAi baseAi) => baseAi.NormalWolf != null;
		/// <summary>
		/// Checks if the current BaseAi is a timberwolf
		/// </summary>
		/// <param name="baseAi">The BaseAi instance</param>
		/// <returns></returns>
		public static bool IsTimberwolf(BaseAi baseAi) => baseAi.Timberwolf != null;
		/// <summary>
		/// Checks if the current BaseAi is a Poisoned Wolf
		/// </summary>
		/// <param name="baseAi"></param>
		/// <returns></returns>
		public static bool IsToxicWolf(BaseAi baseAi) => baseAi.StarvingWolf != null;
		/// <summary>
		/// Checks if the current BaseAi is a bear
		/// </summary>
		/// <param name="baseAi">The BaseAi instance</param>
		/// <returns></returns>
		public static bool IsBear(BaseAi baseAi) => baseAi.Bear != null;
		/// <summary>
		/// Checks if the current BaseAi is a cougar
		/// </summary>
		/// <param name="baseAi">The BaseAi instance</param>
		/// <returns></returns>
		public static bool IsCougar(BaseAi baseAi) => baseAi.Cougar != null;
		/// <summary>
		/// Checks if the current BaseAi is valid
		/// </summary>
		/// <param name="baseAi">The BaseAi instance</param>
		/// <returns><see langword="true"/> if the BaseAi is valid</returns>
		/// <remarks>
		/// <para>Checks if the current BaseAi mode is either <see cref="AiMode.None"/> or <see cref="AiMode.Disabled"/></para>
		/// </remarks>
		public static bool IsValid(BaseAi baseAi) => baseAi.m_CurrentMode != AiMode.None && baseAi.m_CurrentMode != AiMode.Disabled;
		/// <summary>
		/// Checks if the current BaseAi is dead
		/// </summary>
		/// <param name="baseAi">The BaseAi instance</param>
		/// <returns></returns>
		public static bool IsDead(BaseAi baseAi) => baseAi.m_CurrentMode == AiMode.Dead;
		/// <summary>
		/// Gets the WildlifeMode for the given BaseAi
		/// </summary>
		/// <param name="baseAi">The BaseAi instance</param>
		/// <returns>Current BaseAi instance WildlifeMode</returns>
		/// <remarks>
		/// <para>This is useful for when you want to know if its a normal animal or an Aurora animal</para>
		/// </remarks>
		public static WildlifeMode GetWildlifeMode(BaseAi baseAi) => baseAi.m_WildlifeMode;
	}
}
