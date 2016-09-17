using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Transactions;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Transactions
{
    public class BookOffersRequest : RpcJsonRequest<BookOffersRequestParams>
    {
        public override string Method => ApiCommands.BookOffers;
    }
}
