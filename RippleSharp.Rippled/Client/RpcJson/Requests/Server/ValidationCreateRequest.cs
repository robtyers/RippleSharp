﻿using RippleSharp.Rippled.Constants;
using RippleSharp.Rippled.Models.Requests.Server;

namespace RippleSharp.Rippled.Client.RpcJson.Requests.Server
{
    public class ValidationCreateRequest : RpcJsonRequest<ValidationCreateRequestParams>
    {
        public override string Method => ApiCommands.ValidationCreate;
    }
}
