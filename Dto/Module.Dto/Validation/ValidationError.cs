using System;
using System.Collections.Generic;
using System.Linq;

namespace Module.Dto.Validation
{
    [Serializable]
    public class ValidationError
    {
        private readonly List<string> errors;
        private readonly string subject;

        public ValidationError(string subject, string message)
        {
            this.errors = new List<string>() { message };
            this.subject = subject;
        }

        public ValidationError(string subject, List<string> messages)
        {
            this.errors = messages;
            this.subject = subject;
        }

        public bool ContainsErrors
        {
            get
            {
                return errors.Count > 0;
            }
        }

        public List<string> Errors
        {
            get
            {
                return this.errors;
            }
        }

        public string Subject
        {
            get
            {
                return this.subject;
            }
        }

        public string GetErrorMessage(string errorIndicator = null, string errorSeparator = null)
        {
            if (!this.ContainsErrors)
            {
                return null;
            }

            string _errorSeparator = errorSeparator ?? Environment.NewLine;

            List<string> errorsList = this.Errors
                .Select((message) =>
                {
                    return $"{errorIndicator}{message}";
                }).ToList();

            string errorMessage = string.Join(_errorSeparator, errorsList);

            return errorMessage;
        }
    }
}