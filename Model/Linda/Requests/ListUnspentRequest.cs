using System;

namespace Tumba.CanLindaControl.Model.Linda.Requests
{
    public class ListUnspentRequest : BaseRequest
    {
        public override string Method { get { return "listunspent"; } }
        public override object[] MethodParams { get { return new string[0]; } }
    }
}