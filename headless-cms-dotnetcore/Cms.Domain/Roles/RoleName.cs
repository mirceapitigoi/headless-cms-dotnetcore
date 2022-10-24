using Cms.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Domain.Roles
{
    internal class RoleName : ValueObject
    {
        private readonly string name;

        public RoleName(string name)
        {
            this.name = name;
        }
    }
}
