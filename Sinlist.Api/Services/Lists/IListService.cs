using Sinlist.Shared.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Sinlist.Api.Services.Lists
{
    public interface IListService
    {
        Task<IList<ListDto>> GetAllListAsync(int listId);
        Task<IList<ListItemDto>> GetAllListItemAsync(int listItemId);

        //ListDto Methods
        Task AddAsync(ListDto listDto);
        Task AddRangeAsync(IEnumerable<ListDto> listDtos);
        void Remove(ListDto listDto);
        void RemoveRange(IEnumerable<ListDto> listDtos);
        ListDto Update(ListDto listDto);

        //ListItem Methods
        Task AddAsync(ListItemDto listItemDto);
        Task AddRangeAsync(IEnumerable<ListItemDto> listItemDtos);
        void Remove(ListItemDto listItemDto);
        void RemoveRange(IEnumerable<ListItemDto> listItemDtos);
        ListItemDto Update(ListItemDto listItemDto);
    }
}
