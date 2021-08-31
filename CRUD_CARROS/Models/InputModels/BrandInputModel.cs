using Newtonsoft.Json;

namespace CRUD_Marcas.Api.Models.InputModels
{
    public class BrandInputModel
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
    }
}
