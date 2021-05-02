using System.Net;

namespace Module.Dto.Validation.Api
{
    public class DeniedAcessException : ApiException
    {
        public DeniedAcessException() : base(HttpStatusCode.MethodNotAllowed)
        {
        }
    }
}