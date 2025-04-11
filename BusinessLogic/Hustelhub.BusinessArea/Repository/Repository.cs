using Hustelhub.BusinessArea.Interface;
using HustelHub.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hustelhub.BusinessArea.Repository
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
