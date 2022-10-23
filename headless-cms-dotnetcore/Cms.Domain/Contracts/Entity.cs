﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Domain.Contracts
{
    internal abstract class Entity
    {
        private Guid id;

        protected Entity(Guid id)
        {
            this.id = id;
        }

        protected Entity()
        {
            this.id = Guid.NewGuid();
        }
    }
}
