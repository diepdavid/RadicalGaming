using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RadicalGaming.DataAccess.Data;
using RadicalGaming.DataAccess.Repository.IRepository;
using RadicalGaming.Model;

namespace RadicalGaming.DataAccess.Repository
{
    public class TeamRepository : Repository<Team>, ITeamRepository
    {
        private ApplicationDbContext _db;

        public TeamRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Team obj)
        {
            _db.Team.Update(obj);
        }

    }
}
