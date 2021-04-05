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
    public class ListController : ControllerBase
    {
        public readonly IListService _serviceList;
        public ListController(IListService serviceList)
        {
            _serviceList = serviceList;
        }



        [HttpPost("get_all_list")]
        public async Task<IList<ListDto>> GetAllList()
        {
            var result = await this._serviceList.GetAllListAsync();
            return result;
        }



        [HttpPost("get_all_items")]
        public async Task<IList<ListItemDto>> GetAllListItem()
        {
            var result = await this._serviceList.GetAllListItemAsync();
            return result;
        }
    }
}