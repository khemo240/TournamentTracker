using System.Collections.Generic;

namespace TrackerLibrary
{
    public class MatchupModel
    {

        /// <summary>
        /// represent list of entries in a specific round
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; }

        /// <summary>
        /// Represents the winner of the matchup
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents the round of the matchup
        /// </summary>
        public int MatchupRound { get; set; }

    }
}