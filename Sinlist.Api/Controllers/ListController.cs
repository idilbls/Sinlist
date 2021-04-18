using Microsoft.AspNetCore.Mvc;
using Sinlist.Api.Services.Lists;
using Sinlist.Shared.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Sinlist.Api.Controllers
{
    [Route("api/list")]
    [ApiController]
    public class ListController : ControllerBase
    {
        public readonly IListService _serviceList;
        public ListController(IListService serviceList)
        {
            _serviceList = serviceList;
        }



        [HttpPost("add_list")]
        public async Task<ListDto> AddListAsync([FromBody] ListDto listDto)
        {
            var result = await _serviceList.AddListAsync(listDto);
            return result;
        }

        [HttpPost("add_list_item")]
        public async Task<ListItemDto> AddListItemAsync([FromBody] ListItemDto listItemDto)
        {
            var result = await _serviceList.AddListItemAsync(listItemDto);
            return result;
        }

        [HttpPost("delete_list_item")]
        public async Task DeleteListItem([FromBody] int ItemId)
        {
            await _serviceList.DeleteListItem(ItemId);
        }

        [HttpPost("delete_list_with_item")]
        public async Task DeleteListWithItem([FromBody]int listId)
        {
            await _serviceList.DeleteListWithItem(listId);
        }

        [HttpPost("get_list_with_item")]
        public async Task<IList<ListItemDto>> GetListWithItemsAsync([FromBody]int listId)
        {
            var result = await _serviceList.GetListWithItemsAsync(listId);
            return result;
        }
        [HttpPost("update_list")]
        public async Task<ListDto> UpdateList([FromBody]ListDto list)
        {
            var result = await _serviceList.UpdateList(list);
            return result;
        }
        [HttpPost("update_item")]
        public async Task<ListItemDto> UpdateListItem([FromBody]ListItemDto listItem)
        {
            var result = await _serviceList.UpdateListItem(listItem);
            return result;
        }

    }
}