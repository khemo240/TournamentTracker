using System.Collections.Generic;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// represents the name of the tournament
        /// </summary>
        public string TournamentName { get; set; }
        
        /// <summary>
        /// represent cost to enter the tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// represents the list of teams entered into the tournament
        /// </summary>
        public List<TeamModel> EnteredTeam { get; set; } = new List<TeamModel>();
        
        /// <summary>
        /// represent lists of prize offered by placing in the tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; }
        
        /// <summary>
        /// represents the list of rounds in the tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}