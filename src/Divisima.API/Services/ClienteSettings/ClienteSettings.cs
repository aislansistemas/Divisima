using Divisima.API.Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

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
