using TrackerLibrary.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "connTournaments";

        public PeopleModel CreatePeople(PeopleModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
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
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
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

        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@TeamName", model.TeamName); 
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                foreach (PeopleModel tm in model.TeamMembers )
                {
                    p = new DynamicParameters();
                    p.Add("@TeamId", model.Id);
                    p.Add("@PersonId", tm.Id);
       
                    connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);

                }

                return model;

            }
        }

        public List<PeopleModel> GetPeople_All()
        {
            List<PeopleModel> output; 
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnString(db)))
            {
                output = connection.Query<PeopleModel>("dbo.spPeople_GetAll").ToList();
            }

            return output;
        }
    }
}
