using Newtonsoft.Json;
using Sinlist.Shared.BPResponse;
using Sinlist.Shared.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Sinlist.Shared.Service.Lists
{
    public class ListService : IListService
    {
        private readonly HttpClient _httpClient;

        public ListService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ListDto> AddListAsync(ListDto listDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/list/add_list", listDto);
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<BPJson<ListDto>>(resultString);
            if (!result.Success)
            {
                throw result.Error;
            }
            return result.Result;
        }

        public async Task<ListItemDto> AddListItemAsync(ListItemDto listItemDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/list/add_list_item", listItemDto);
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<BPJson<ListItemDto>>(resultString);
            if (!result.Success)
            {
                throw result.Error;
            }
            return result.Result;
        }

        public async Task<bool> DeleteListItem(int ItemId)
        {
            var response = await _httpClient.PostAsJsonAsync("api/list/delete_list_item", ItemId);
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<BPJson<bool>>(resultString);
            if (!result.Success)
            {
                throw result.Error;
            }
            return result.Result;
        }

        public async Task<bool> DeleteListWithItem(int listId)
        {
            var response = await _httpClient.PostAsJsonAsync("api/list/delete_list_with_item", listId);
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<BPJson<bool>>(resultString);
            if (!result.Success)
            {
                throw result.Error;
            }
            return result.Result;
        }

        public async Task<IList<ListItemDto>> GetListWithItemsAsync(int listId)
        {
            var response = await _httpClient.PostAsJsonAsync("api/list/get_list_with_item", listId);
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<BPJson<IList<ListItemDto>>>(resultString);
            if (!result.Success)
            {
                throw result.Error;
            }
            return result.Result;
        }

        public async Task<ListDto> UpdateList(ListDto list)
        {
            var response = await _httpClient.PostAsJsonAsync("api/list/update_list", list);
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<BPJson<ListDto>>(resultString);
            if (!result.Success)
            {
                throw result.Error;
            }
            return result.Result;
        }

        public async Task<ListItemDto> UpdateListItem(ListItemDto listItem)
        {
            var response = await _httpClient.PostAsJsonAsync("api/list/update_item", listItem);
            var resultString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<BPJson<ListItemDto>>(resultString);
            if (!result.Success)
            {
                throw result.Error;
            }
            return result.Result;
        }
    }
}
