

using System.Text.Json.Serialization;

namespace Divisima.API.Helpers
{
    public class ClienteConfigurationHelper
    {
        [JsonPropertyName("Nome")]
        public string Nome { get; set; }

        [JsonPropertyName("Cidade")]
        public string Cidade { get; set; }

        [JsonPropertyName("Estado")]
        public string Estado { get; set; }

        [JsonPropertyName("Logradouro")]
        public string Logradouro { get; set; }

        [JsonPropertyName("Numero")]
        public string Numero { get; set; }

        [JsonPropertyName("Complemento")]
        public string Complemento { get; set; }

        [JsonPropertyName("Telefone")]
        public string Telefone { get; set; }

        [JsonPropertyName("Email")]
        public string Email { get; set; }

        [JsonPropertyName("Logo")]
        public string Logo { get; set; }
    }
}