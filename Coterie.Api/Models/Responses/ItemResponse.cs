namespace Coterie.Api.Models.Responses
{
    public class ItemResponse<T> : BaseSuccessResponse
    {
        public T Item { get; set; }
    }
}