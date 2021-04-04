using System;
using Sinlist.Shared.Lists;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sinlist.Business.Lists
{
    public interface IListService
    {
        Task<IList<ListDto>> GetAllListAsync();
        Task<IList<ListItemDto>> GetAllListItemAsync();
    }
}