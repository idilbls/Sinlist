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

    }
}