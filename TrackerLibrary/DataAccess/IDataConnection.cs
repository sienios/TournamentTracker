using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
        PeopleModel CreatePeople(PeopleModel model);

        List<PeopleModel> GetPeople_All();
        
    }
}
