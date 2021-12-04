using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFL.DAO;
using NFL.Model;

namespace NFL.Controller
{
    public class MatchController
    {
        private readonly IMatchDao dao;

        public MatchController(IMatchDao matchDao)
        {
            dao = matchDao;
        }

        public bool AddMatch(Match match)
        {
            return dao.AddMatch(match);
        }

        public bool UpdateMatch(Match match)
        {
            return dao.UpdateMatch(match);
        }
        public IEnumerable<Match> getMatches()
        {
            return dao.getMatches();
        }

        public Match getMatch()
        {
            return dao.getMatch();
        }
    }
}
