using System.Collections.Generic;
namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// represents the list of people on the team
        /// </summary>
        public List<PersonModel> TeamMembers {get;set;} = new List<PersonModel>();

        /// <summary>
        /// name of team
        /// </summary>
        public string TeamName { get; set; }
    
    }
}

