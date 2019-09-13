﻿using TrackerLibrary.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public PeopleModel CreatePeople(PeopleModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString("connTournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@Phone", model.Phone);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }

        /// <summary>
        /// Saves a new prize to database
        /// </summary>
        /// <param name="model"></param>
        /// <returns> The prize information </returns>
        /// 

        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString("connTournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber",model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0,dbType: DbType.Int32,direction:ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert",p,commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }

               
        }
    }
}
