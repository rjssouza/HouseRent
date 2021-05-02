namespace Module.Dto.Validation.Api
{
    public class ValidationException : ApiException
    {
        private readonly ValidationSummary validation;

        public ValidationException()
            : base(System.Net.HttpStatusCode.PreconditionFailed)
        {
        }

        public ValidationException(ValidationSummary validation)
            : base(System.Net.HttpStatusCode.PreconditionFailed)
        {
            this.validation = validation;
        }

        public ValidationException(string subject, string message)
            : base(System.Net.HttpStatusCode.PreconditionFailed)
        {
            this.validation = new ValidationSummary();
            this.validation.AddError(subject, message);
        }

        public ValidationSummary Validation
        {
            get
            {
                return this.validation;
            }
        }
    }
}