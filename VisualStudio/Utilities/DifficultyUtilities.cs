
namespace CommonLib.Utilities
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	public class DifficultyUtilities
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	{
		/// <summary>
		/// Gets the current difficulty mode
		/// </summary>
		/// <returns></returns>
		public static Difficulty GetCurrentMode()
		{
			return ExperienceModeManager.GetCurrentExperienceModeType() switch
			{
				// Sandbox 1-9
				ExperienceModeType.Pilgrim					=> Difficulty.Pilgrim,
				ExperienceModeType.Voyageur					=> Difficulty.Voyageur,
				ExperienceModeType.Stalker					=> Difficulty.Stalker,
				ExperienceModeType.Interloper				=> Difficulty.Interloper,

				ExperienceModeType.Custom					=> Difficulty.Custom,

				// Wintermute 10-19
				ExperienceModeType.Story					=> Difficulty.Story,
				ExperienceModeType.StoryFresh				=> Difficulty.Story,
				ExperienceModeType.StoryHardened			=> Difficulty.Story,

				// Challenges 20-39
				ExperienceModeType.ChallengeRescue			=> Difficulty.Challenge,
				ExperienceModeType.ChallengeWhiteout		=> Difficulty.Challenge,
				ExperienceModeType.ChallengeNomad			=> Difficulty.Challenge,
				ExperienceModeType.ChallengeHunted			=> Difficulty.Challenge,
				ExperienceModeType.ChallengeHuntedPart2		=> Difficulty.Challenge,
				ExperienceModeType.ChallengeArchivist		=> Difficulty.Challenge,
				ExperienceModeType.ChallengeDeadManWalking	=> Difficulty.Challenge,
				ExperienceModeType.ChallengeNowhereToHide	=> Difficulty.Challenge,

				// Events 40+
				ExperienceModeType.EventWintersEmbrace		=> Difficulty.Event,
				ExperienceModeType.FourDaysOfNight			=> Difficulty.Event,
				_											=> Difficulty.None,
			};
		}
		/// <summary>
		/// 
		/// </summary>
		public enum Difficulty
		{
			None,
			Pilgrim,
			Voyageur,
			Stalker,
			Interloper,
			Custom,
			Challenge,
			Story,
			Event
		}
	}
}
