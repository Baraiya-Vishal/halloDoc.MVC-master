using DataAccess.data;
using Services.Contracts;
using Services.Implementations;
using Services.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private HallodocdbContext _context;

        public UnitOfWork(HallodocdbContext context)
        {

            _context = context;
            AspNetUser = new AspNetUserRepository (_context);
          


        }


        public IAspNetUserServices AspNetUser { get; private set; }



        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
