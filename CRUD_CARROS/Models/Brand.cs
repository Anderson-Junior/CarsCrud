namespace CRUD_Marcas.Api.Models
{
    public class Brand : Entity
    {
        public string Name { get; set; }

        public Brand(string name)
        {
            Name = name;
        }
    }
 }
