using System;
using System.Collections.Generic;
using System.Linq;

namespace Module.Dto.Validation
{
    [Serializable]
    public class ValidationSummary
    {
        private readonly Dictionary<string, ValidationError> errors;

        public ValidationSummary()
        {
            this.errors = new Dictionary<string, ValidationError>();
        }

        public bool ContainsErrors
        {
            get
            {
                return errors.Count > 0;
            }
        }

        public string ErrorMessage
        {
            get
            {
                return this.GetErrorMessage();
            }
        }

        public Dictionary<string, ValidationError> Errors
        {
            get
            {
                return this.errors;
            }
        }

        public void AddError(string subject, string message)
        {
            if (!errors.ContainsKey(subject))
            {
                ValidationError validationError = new(subject, message);

                errors.Add(subject, validationError);

                return;
            }

            errors[subject].Errors.Add(message);
        }

        public void AddValidationError(ValidationError validationError)
        {
            if (!errors.ContainsKey(validationError.Subject))
            {
                errors.Add(validationError.Subject, validationError);

                return;
            }

            errors[validationError.Subject].Errors.AddRange(validationError.Errors);
        }

        public string GetErrorMessage(string errorIndicator = null, string errorSeparator = null)
        {
            if (!this.ContainsErrors)
            {
                return null;
            }

            string _errorSeparator = errorSeparator ?? Environment.NewLine;

            List<string> errorList = this.Errors
                .Select((dictError) =>
                {
                    string errorsFromSubject = dictError.Value.GetErrorMessage(errorIndicator, _errorSeparator);

                    return errorsFromSubject;
                }).ToList();

            string errorMessage = string.Join(_errorSeparator, errorList);

            return errorMessage;
        }
    }
}