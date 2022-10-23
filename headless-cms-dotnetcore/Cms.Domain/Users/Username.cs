using Cms.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Domain.Users
{
    internal class UserName : ValueObject
    {
        private readonly string userName;

        public UserName(string userName)
        {
            this.userName = userName;
        }

        private void ValidateUsername()
        {
            throw new NotImplementedException();
        }

    }
}
