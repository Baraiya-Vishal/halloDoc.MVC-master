using DataAccess.Entity;
using Services.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
  

    public interface IAspNetUserServices : IRepository<AspNetUser>
    {
        void Update(AspNetUser aspNetUser);

    }
}
