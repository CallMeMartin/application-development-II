using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFL.Model
{
    public class Match
    {
        public int ID { get; set; }
        public string HomeClubName { get; set; }
        public string AwayClubName { get; set; }
        public int HomeFinalScore { get; set; }
        public int AwayFinalScore { get; set; }
        public int HomeNumberOfTD { get; set; }
        public int AwayNumberOfTD { get; set; }
        public int Week { get; set; }
        public int Year { get; set; }

        public Match() { }

        public Match(int id, string homeClubName, string awayClubName, int homeFinalScore, int awayFinalScore, int homeNumberOfTD, int awayNumberOfTD, int week, int year)
        {
            ID = id;
            HomeClubName = homeClubName;
            AwayClubName = awayClubName;
            HomeFinalScore = homeFinalScore;
            AwayFinalScore = awayFinalScore;
            HomeNumberOfTD = homeNumberOfTD;
            AwayNumberOfTD = awayNumberOfTD;
            Week = week;
            Year = year;
        } 
    }
}
