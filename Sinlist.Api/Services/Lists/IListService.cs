using Sinlist.Shared.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sinlist.Api.Services.Lists
{
    public interface IListService
    {
        Task<IList<ListDto>> GetAllListAsync();
        Task<IList<ListItemDto>> GetAllListItemAsync();
    }
}
