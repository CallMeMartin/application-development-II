using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFL.Model;

namespace NFL.DAO
{
    public interface IMatchDao
    {
        bool AddMatch(Match match);
        bool UpdateMatch(Match match);
        IEnumerable<Match> getMatches();
        Match getMatch();
    }
}
