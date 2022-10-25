using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Domain.Contracts
{
    internal abstract class Entity //:IValidator
    {
        private Guid Id { get; }

        protected Entity(Guid id)
        {
            Id = id;
        }

        protected Entity() : this(Guid.NewGuid())
        {
        }
    }
}
