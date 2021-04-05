using AutoMapper;
using Sinlist.Core.Context;
using Sinlist.Shared.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sinlist.Api.Services.Lists
{
    public class ListService : IListService
    {
        private readonly SinlistDbContext _context;
        private readonly IMapper _mapper;

        public ListService(SinlistDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
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
