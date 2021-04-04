using Sinlist.EntityFrameworkCore.EntityFrameworkCore;
using Sinlist.Shared.Lists;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sinlist.Business.Lists
{
    public class ListService : IListService
    {
        private readonly SinlistDbContext _db;

        public ListService(SinlistDbContext db)
        {
            _db = db;
        }
        public async Task<IList<ListDto>> GetAllListAsync()
        {
            throw new NotImplementedException();
        }
        public async Task<IList<ListItemDto>> GetAllListItemAsync()
        {
            throw new NotImplementedException();
        }
    }
}