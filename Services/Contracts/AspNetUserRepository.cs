using DataAccess.data;
using DataAccess.Entity;
using Services.Implementations;
using Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public class AspNetUserRepository : Repository<AspNetUser>, IAspNetUserServices
    {
        private HallodocdbContext _context;

        public AspNetUserRepository(HallodocdbContext context) : base(context)
        {

            _context = context;
        }

        public void Update(AspNetUser fruit)
        {
            _context.AspNetUsers.Update(fruit);
        }
    }




}
