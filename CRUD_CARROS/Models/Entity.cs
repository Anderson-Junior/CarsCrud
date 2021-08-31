using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Marcas.Api.Models
{
    public abstract class Entity
    {
        public int Id { get; protected set; }
    }
}
