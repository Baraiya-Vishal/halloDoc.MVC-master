using Services.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IAspNetUserServices AspNetUser { get; }


        void Save();

    }
}
