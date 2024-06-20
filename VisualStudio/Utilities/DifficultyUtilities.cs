
namespace CommonLib.Utilities
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	public class DifficultyUtilities
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	{
		/// <summary>
		/// 
		/// </summary>
		public static Dictionary<Mode, Levels> DifficultyLibrary { get; } = new()
		{
			{ Mode.StoryMode, Levels.None },
			{ Mode.Sandbox, Levels.Pilgrim }
		};

		/// <summary>
		/// Gets the current difficulty mode, each with its own int
		/// </summary>
		/// <returns>
		/// </returns>
		public static int GetCurrentMode()
		{
			return ExperienceModeManager.GetCurrentExperienceModeType() switch
			{
				// Sandbox 1-9
				ExperienceModeType.Pilgrim					=> 1,
				ExperienceModeType.Voyageur					=> 2,
				ExperienceModeType.Stalker					=> 3,
				ExperienceModeType.Interloper				=> 4,

				ExperienceModeType.Custom					=> 0,

				// Wintermute 10-19
				ExperienceModeType.Story					=> 10,
				ExperienceModeType.StoryFresh				=> 11,
				ExperienceModeType.StoryHardened			=> 12,

				// Challenges 20-39
				ExperienceModeType.ChallengeRescue			=> 20,
				ExperienceModeType.ChallengeWhiteout		=> 21,
				ExperienceModeType.ChallengeNomad			=> 22,
				ExperienceModeType.ChallengeHunted			=> 23,
				ExperienceModeType.ChallengeHuntedPart2		=> 24,
				ExperienceModeType.ChallengeArchivist		=> 25,
				ExperienceModeType.ChallengeDeadManWalking	=> 26,
				ExperienceModeType.ChallengeNowhereToHide	=> 27,

				// Events 40+
				ExperienceModeType.EventWintersEmbrace		=> 40,
				ExperienceModeType.FourDaysOfNight			=> 41,
				_											=> -1,
			};
		}
	}
}
