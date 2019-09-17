using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $@"{ConfigurationManager.AppSettings["filePath"]}\{fileName} ";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        

       public static List<PeopleModel> ConvertToPeopleModel(this List<string> lines)
        {
            List<PeopleModel> output = new List<PeopleModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');


                PeopleModel p = new PeopleModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.Phone = cols[3];
                p.EmailAddress = cols[4];

                output.Add(p);
            }

            return output;
        }

        public static void SaveToPeopleFile(this List<PeopleModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PeopleModel p in models)
            {
                lines.Add($"{p.Id },{p.FirstName },{p.LastName},{p.Phone},{p.EmailAddress}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }



        public static List<PrizeModel> ConvertToPrizeModel(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                
                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);

                output.Add(p);
            }

            return output;
        }


        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id },{p.PlaceNumber },{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }


        public static List<TeamModel> ConvertToTeamModels(this List<string> lines,string peopleFileName)
        {
            //id, team name , list of ids seperated by the pipe 
            //3 , tims Team, 1|2|3
            List<TeamModel> output = new List<TeamModel>();
            List<PeopleModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPeopleModel();

            foreach (var line in lines)
            {
                string[] cols = line.Split('/');

                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];

                string[] personIds = cols[2].Split('|');

                foreach (string id in personIds)
                {
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).FirstOrDefault());
                }
            }

            return output;

        }

        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach(TeamModel t in models)
            {
                lines.Add($"{t.Id},{t.TeamName},{ConvertPeopleListToString(t.TeamMembers)}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static string ConvertPeopleListToString(List<PeopleModel> peoples)
        {
            string output = "";
            if (peoples.Count ==0)
            {
                return "";
            }

            foreach (PeopleModel p in peoples)
            {
                output += $"{p.Id}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
            
    }

}
