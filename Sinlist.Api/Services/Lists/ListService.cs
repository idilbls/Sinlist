using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sinlist.Core.Context;
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

        public async Task AddAsync(ListDto listDto)
        {
            await _context.AddAsync(listDto);
        }

        public async Task AddAsync(ListItemDto listItemDto)
        {
            await _context.AddAsync(listItemDto);
        }

        public async Task AddRangeAsync(IEnumerable<ListDto> listDtos)
        {
            await _context.AddRangeAsync(listDtos);
        }

        public async Task AddRangeAsync(IEnumerable<ListItemDto> listItemDtos)
        {
            await _context.AddRangeAsync(listItemDtos);
        }

        public Task<IList<ListDto>> GetAllListAsync(int listId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<ListItemDto>> GetAllListItemAsync(int listItemId)
        {
            throw new NotImplementedException();
        }

        public void Remove(ListDto listDto)
        {
            _context.Remove(listDto);
        }

        public void Remove(ListItemDto listItemDto)
        {
            _context.Remove(listItemDto);
        }

        public void RemoveRange(IEnumerable<ListDto> listDtos)
        {
            _context.RemoveRange(listDtos);
        }

        public void RemoveRange(IEnumerable<ListItemDto> listItemDtos)
        {
            _context.RemoveRange(listItemDtos);
        }

        public ListDto Update(ListDto listDto)
        {
            _context.Entry(listDto).State = EntityState.Modified;

            return listDto;
        }

        public ListItemDto Update(ListItemDto listItemDto)
        {
            _context.Entry(listItemDto).State = EntityState.Modified;

            return listItemDto;
        }
    }
}
