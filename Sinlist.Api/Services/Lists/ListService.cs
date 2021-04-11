using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sinlist.Core.Context;
using Sinlist.Core.Entities.Lists;
using Sinlist.Shared.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public async Task<ListDto> AddListAsync(ListDto listDto)
        {

            listDto.CreationTime = DateTime.Now;

            var map = _mapper.Map<List>(listDto);
            await  _context.Lists.AddAsync(map);
            await _context.SaveChangesAsync();

            return _mapper.Map<ListDto>(map);
        }

    }
}
