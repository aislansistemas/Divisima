using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using divisima.Enums.ProdutoEnums;
using Divisima.Services;
using Divisima.ViewModels;

namespace Divisima.Enums.ProdutoEnums
{
    public static class ProdutoTamanhoEnumClass 
    {
        public static List<KeyValuePair<int, string>> GetComboEnum()
        {
            Dictionary<int, string> produtoTamanhoEnum = new Dictionary<int, string>();
            produtoTamanhoEnum.Add((int)ProdutoTamanhoEnum.PP, "PP");
            produtoTamanhoEnum.Add((int)ProdutoTamanhoEnum.P, "P");
            produtoTamanhoEnum.Add((int)ProdutoTamanhoEnum.M, "M");
            produtoTamanhoEnum.Add((int)ProdutoTamanhoEnum.G, "G");
            produtoTamanhoEnum.Add((int)ProdutoTamanhoEnum.GG, "GG");
            produtoTamanhoEnum.Add((int)ProdutoTamanhoEnum.EG, "Extra G");
            
            return produtoTamanhoEnum.ToList();
        }
    }
}