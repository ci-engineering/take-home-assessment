
using System.Collections.Generic;

namespace Coterie.Api.Models.Responses
{
    public class ItemsResponse<T> : BaseSuccessResponse
    {
        public List<T> Items { get; set; }
    }
}