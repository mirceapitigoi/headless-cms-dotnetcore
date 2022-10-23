using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Domain.Contracts
{
    internal interface IAggregateRoot
    {
        public Guid Id { get; set; }
    }
}
