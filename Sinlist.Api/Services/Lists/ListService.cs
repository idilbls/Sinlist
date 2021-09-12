using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sinlist.Core.Context;
using Sinlist.Core.Entities.Lists;
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

        public async Task<ListDto> AddListAsync(ListDto listDto)
        {

            listDto.CreationTime = DateTime.Now;

            var map = _mapper.Map<List>(listDto);
            await  _context.Lists.AddAsync(map);
            await _context.SaveChangesAsync();

            return _mapper.Map<ListDto>(map);
        }

        public async Task<ListItemDto> AddListItemAsync(ListItemDto listItemDto)
        {
            //ListItem listItem = _mapper.Map<ListItemDto, ListItem>(listItemDto);
            //listItem.CreationTime = DateTime.Now;
            //var addedListItem = await _context.ListItems.AddAsync(listItem);
            //await _context.SaveChangesAsync();
            //return _mapper.Map<ListItem, ListItemDto>(addedListItem.Entity);

            listItemDto.CreationTime = DateTime.Now;
            var map = _mapper.Map<ListItem>(listItemDto);
            await _context.ListItems.AddAsync(map);
            await _context.SaveChangesAsync();

            return _mapper.Map<ListItemDto>(map);
        }

        public async Task<bool> DeleteListItem(int ItemId)
        {
            try
            {
                var listItem = await _context.ListItems.FirstOrDefaultAsync(x => x.Id == ItemId);
                _context.ListItems.Remove(listItem);
                await _context.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> DeleteListWithItem(int listId)
        {
            //var list = await _context.Lists.FirstOrDefaultAsync(x => x.Id == listId);
            //_context.Lists.Remove(list);
            //var lisItems = await _context.ListItems.AllAsync(x => x.ListId == listId);
            try
            {
                var list = await _context.Lists.FindAsync(listId);
                if (list != null)
                {
                    var listItems = await _context.ListItems.Where(x => x.ListId == listId).ToListAsync();

                    _context.ListItems.RemoveRange(listItems);
                    _context.Lists.Remove(list);
                    await _context.SaveChangesAsync();
                }
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public async Task<IList<ListItemDto>> GetListWithItemsAsync(int listId)
        {
            var list = await _context.Lists.FindAsync(listId);
            var listItems = await _context.ListItems.Where(x => x.ListId == listId).ToListAsync();
            return _mapper.Map<List<ListItemDto>>(listItems);
            
        }

        public async Task<ListDto> UpdateList(ListDto list)
        {
            var listDto = await _context.Lists.FirstOrDefaultAsync(x => x.Id == list.Id);
            listDto.Name = list.Name;
            listDto.CreationTime = DateTime.Now;
            _context.Lists.Update(listDto);
            await _context.SaveChangesAsync();
            return _mapper.Map<ListDto>(listDto);

        }

        public async Task<ListItemDto> UpdateListItem(ListItemDto listItem)
        {
            var listItemDto = await _context.ListItems.FirstOrDefaultAsync(x => x.Id == listItem.Id);
            listItemDto.Name = listItem.Name;
            listItemDto.Description = listItem.Description;
            listItemDto.Count = listItem.Count;
            listItemDto.CreationTime = DateTime.Now;
            _context.ListItems.Update(listItemDto);
            await _context.SaveChangesAsync();
            return _mapper.Map<ListItemDto>(listItemDto);
        }
    }
}
