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
        public Task<ListDto> AddListAsync(ListDto listDto);
        public Task<IList<ListItemDto>> GetListWithItemsAsync(int listId);
        public Task<ListDto> UpdateList(ListDto list);
        public Task DeleteListWithItem(int listId);
        public Task<ListItemDto> AddListItemAsync(ListItemDto listItemDto);
        public Task<ListItemDto> UpdateListItem(ListItemDto listItem);
        public Task DeleteListItem(int ItemId);
    }
}
