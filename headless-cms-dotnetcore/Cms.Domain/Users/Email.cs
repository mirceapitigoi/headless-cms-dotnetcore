using Cms.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Domain.Users
{
    internal class Email : ValueObject
    {
        private readonly string email;

        public Email(string email)
        {
            this.email = email;
        }

        public void ValidateEmail()
        {
            // todo implement FLuentValidation
            throw new NotImplementedException();
        }
    }
}
