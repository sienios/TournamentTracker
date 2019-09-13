using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        public List<PeopleModel> TeamMembers { get; set; } = new List<PeopleModel>();
        public string TeamName { get; set; }

    
    }
}
