using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    class ValidationResult
    {
        public string UserEntry { get; set; }
        public bool Result { get; set; }
        public ValidationResult(string userEntry, bool result)
        {
            UserEntry = userEntry;
            Result = result;
        }
    }
}
