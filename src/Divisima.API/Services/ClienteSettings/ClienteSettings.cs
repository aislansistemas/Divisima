using Divisima.API.Helpers;
using System.IO;
using System.Text.Json;

namespace divisima.API.Services.ClienteSettings
{
    public static class ClienteSettings
    {
        private const string CLIENTE_SETTINGS_FILE_INFO = @"cliente.settings.json";
        public static ClienteConfigurationHelper GetClienteSettings()
        {
            var settings = File.ReadAllText(CLIENTE_SETTINGS_FILE_INFO);

            return JsonSerializer.Deserialize<ClienteConfigurationHelper>(settings);
        }
    }
}
