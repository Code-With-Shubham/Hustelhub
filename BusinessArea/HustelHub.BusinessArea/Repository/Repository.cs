using HustelHub.BusinessArea.Interfaces;
using HustelHub.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HustelHub.BusinessArea.Repository
{
    public class Repository : IRepository
    {
        private readonly ApplicationDbContext _dbcontext;
        private readonly HttpClient _httpClient;
        public Repository(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
            _httpClient = new HttpClient();
        }
    }


}
