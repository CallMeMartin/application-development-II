using System;
using System.Collections.Generic;
using System.Data.SQLite;
using NFL.Model;

namespace NFL.DAO
{
    class MatchAdoDao : IMatchDao
    {
        private const string CONN_STRING = @"Data Source=../../../../DB/nfl.db;";

        bool IMatchDao.AddMatch(Match match)
        {
            if (match == null) return false;

            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO GAME "
                + "(HomeClubName, AwayClubName, HomeFinalScore, AwayFinalScore, HomeNumberOfTD, AwayNumberOfTD, Week, Year) VALUES "
                + "(@homeClubName, @awayClubName, @homeFinalScore, @awayFinalScore, @homeNumberOfTD, @awayNumberOfTD, @week, @year);";

            command.Parameters.Add("homeClubName", System.Data.DbType.String).Value = match.HomeClubName;
            command.Parameters.Add("awayClubName", System.Data.DbType.String).Value = match.AwayClubName;
            command.Parameters.Add("homeFinalScore", System.Data.DbType.Int32).Value = match.HomeFinalScore;
            command.Parameters.Add("awayFinalScore", System.Data.DbType.Int32).Value = match.AwayFinalScore;
            command.Parameters.Add("homeNumberOfTD", System.Data.DbType.Int32).Value = match.HomeNumberOfTD;
            command.Parameters.Add("awayNumberOfTD", System.Data.DbType.Int32).Value = match.AwayNumberOfTD;
            command.Parameters.Add("week", System.Data.DbType.Int32).Value = match.Week;
            command.Parameters.Add("year", System.Data.DbType.Int32).Value = match.Year;

            bool returned = true;
            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                returned = false;
            }

            connection.Close();
            return returned;
        }

        Match IMatchDao.getMatch()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Match> IMatchDao.getMatches()
        {
            List<Match> matches = new List<Match>();

            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM GAME ORDER BY Year DESC, Week DESC;";

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                matches.Add(new Match(
                    reader.GetInt32(reader.GetOrdinal("ID")),
                    reader.GetString(reader.GetOrdinal("HomeClubName")),
                    reader.GetString(reader.GetOrdinal("AwayClubName")),
                    reader.GetInt32(reader.GetOrdinal("HomeFinalScore")),
                    reader.GetInt32(reader.GetOrdinal("AwayFinalScore")),
                    reader.GetInt32(reader.GetOrdinal("HomeNumberOfTD")),
                    reader.GetInt32(reader.GetOrdinal("AwayNumberOfTD")),
                    reader.GetInt32(reader.GetOrdinal("Week")),
                    reader.GetInt32(reader.GetOrdinal("Year"))
                ));
            }
            connection.Close();
            return matches;
        }

        bool IMatchDao.UpdateMatch(Match match)
        {
            using SQLiteConnection connection = new SQLiteConnection(CONN_STRING);
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE GAME SET "
                + "HomeClubName=@homeClubName, AwayClubName=@awayClubName, HomeFinalScore=@homeFinalScore, AwayFinalScore=@awayFinalScore, HomeNumberOfTD=@homeNumberOfTD, AwayNumberOfTD=@awayNumberOfTD, Week=@week, Year=@year "
                + "WHERE ID=@id;";

            command.Parameters.Add("homeClubName", System.Data.DbType.String).Value = match.HomeClubName;
            command.Parameters.Add("awayClubName", System.Data.DbType.String).Value = match.AwayClubName;
            command.Parameters.Add("homeFinalScore", System.Data.DbType.Int32).Value = match.HomeFinalScore;
            command.Parameters.Add("awayFinalScore", System.Data.DbType.Int32).Value = match.AwayFinalScore;
            command.Parameters.Add("homeNumberOfTD", System.Data.DbType.Int32).Value = match.HomeNumberOfTD;
            command.Parameters.Add("awayNumberOfTD", System.Data.DbType.Int32).Value = match.AwayNumberOfTD;
            command.Parameters.Add("week", System.Data.DbType.Int32).Value = match.Week;
            command.Parameters.Add("year", System.Data.DbType.Int32).Value = match.Year;
            command.Parameters.Add("id", System.Data.DbType.Int32).Value = match.ID;

            bool ret = true;
            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                ret = false;
            }

            connection.Close();
            return ret;
        }
    }
}
