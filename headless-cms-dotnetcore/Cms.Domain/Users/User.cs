using Cms.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Domain.Users
{
    internal class User : Entity, IAggregateRoot
    {
        public Guid Id { get; set; }

        public Name Name { get; set; }

        public Password Password { get; set; }

        public Email Email { get; set; }
    }
}
