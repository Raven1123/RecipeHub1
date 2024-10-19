using Newtonsoft.Json;

namespace Recipehub.Models
{
    public class CatFact
    {
        public string Fact { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }
    }
}
