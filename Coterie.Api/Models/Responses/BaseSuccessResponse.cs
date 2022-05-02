using System;

namespace Coterie.Api.Models.Responses
{
    public abstract class BaseSuccessResponse
    {
        public bool IsSuccessful { get; } = true;
        public string TransactionId { get; }  = Guid.NewGuid().ToString();
    }
}