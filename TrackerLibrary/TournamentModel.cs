using System.Collections.Generic;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string TournamentName { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<TeamModel> EnteredTeam { get; set; } = new List<TeamModel>();
        
        /// <summary>
        /// 
        /// </summary>
        public List<PrizeModel> Prizes { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}