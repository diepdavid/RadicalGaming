using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadicalGaming.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ITeamRepository Team { get; }

        void Save();
    }
}
