namespace Module.Dto.Validation.Api
{
    public class ConfirmationException : ApiException
    {
        private readonly string _message;

        public ConfirmationException()
            : base(System.Net.HttpStatusCode.Conflict)
        {
        }

        public ConfirmationException(string message) : base(System.Net.HttpStatusCode.Conflict)
        {
            this._message = message;
        }

        public override string Message => this._message;
    }
}