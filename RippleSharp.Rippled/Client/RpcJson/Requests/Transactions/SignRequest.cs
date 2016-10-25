using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Transactions;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Transactions
{
    public class SignRequest : RpcJsonRequest<SignRequestParams>
    {
        public override string Method => ApiMethod.Sign;
    }
}
