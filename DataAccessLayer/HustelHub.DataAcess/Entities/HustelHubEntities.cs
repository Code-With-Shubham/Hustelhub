using HustelHub.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HustelHub.DataAccess.Entities
{
   

    public class HustelHubEntities : ApplicationDbContext
    {
        public HustelHubEntities()
        {

        }
        public HustelHubEntities(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

    }

}
