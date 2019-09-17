using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        public int Id  { get; set; }
        public string TeamName { get; set; }
        public List<PeopleModel> TeamMembers { get; set; } = new List<PeopleModel>();
        

    
    }
}
