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
    }
}
