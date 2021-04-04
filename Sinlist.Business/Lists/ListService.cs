using Sinlist.Shared.Lists;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sinlist.Business.Lists
{
    class ListService : IListService
    {
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