using Sinlist.Shared.Lists;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sinlist.Shared.Service.Lists
{
    public interface IListService
    {
        Task<ListDto> AddListAsync(ListDto listDto);
        Task<ListItemDto> AddListItemAsync(ListItemDto listItemDto);
        Task<bool> DeleteListItem(int ItemId);
        Task<bool> DeleteListWithItem(int listId);
        Task<IList<ListItemDto>> GetListWithItemsAsync(int listId);
        Task<ListDto> UpdateList(ListDto list);
        Task<ListItemDto> UpdateListItem(ListItemDto listItem);
    }
}
