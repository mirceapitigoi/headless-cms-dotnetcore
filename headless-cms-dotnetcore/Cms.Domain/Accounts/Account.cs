using Cms.Domain.Contracts;
using Cms.Domain.Roles;
using Cms.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Domain.Accounts
{
    internal class Account : Entity//, IAggregateRoot
    {
        public User User { get; set; }
        public List<Role> Roles { get; set; }

        public Account(Guid id) : base(id)
        {

        }
    }
}
