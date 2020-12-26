using System.Collections.Generic;
using System.Collections.Specialized;

namespace Divisima.Enums.PerfilUsuarioEnums
{
    public static class PerfilUsuarioEnum
    {
        public const string Admin = "Admin";
        public const string Comun = "Comun";

        public static List<string> GetPerfilUsuarioCombo() {
            List<string> perfilUsuarioCombo = new List<string>(){
                Comun,
                Admin
            };
            return perfilUsuarioCombo;
        } 
    }
}