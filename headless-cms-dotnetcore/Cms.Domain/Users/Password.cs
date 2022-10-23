using Cms.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Domain.Users
{
    internal class Password : ValueObject
    {
        public string password;

        public Password(string password)
        {
            this.password = password;
        }

        private string Hash(string password)
        {
            throw new NotImplementedException();
        }
    }
}
