﻿using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizesModels.csv";
        private const string PeopleFile = "PeopleModels.csv";

        public PeopleModel CreatePeople(PeopleModel model)
        {
            List<PeopleModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPeopleModel();

            int currentId = 1;


            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }


            model.Id = currentId;
            people.Add(model);

            people.SaveToPeopleFile(PeopleFile);

            return model;

        }

        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();

            int currentId = 1;


            if (prizes.Count > 0)
            {
              currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
   

            model.Id = currentId;
            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFile);

            return model;

        }
    }
}
