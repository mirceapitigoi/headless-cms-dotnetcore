using Cms.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Domain.Roles
{
    internal class Role : Entity
    {
        public RoleName roleName { get; set; }
        public List<AccessRight> AccessRights { get; set; }

        public Role(Guid id) : base(id)
        {

        }
    }
}
