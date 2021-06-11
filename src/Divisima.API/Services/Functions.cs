namespace divisima.Services
{
    public static class Functions
    {
        private static string PathFotoFiliado = "arquivos";
        public static string GetPathUploadProdutos() 
        {
            return PathFotoFiliado;
        }

        public static string GetImagemParaExibicao(string nomeImagem) 
        {
            return "/" + PathFotoFiliado + "/" + nomeImagem;
        }

        public static string GetValorMoedaFormatado(decimal valor)
        {
            return "R$ " + valor.ToString("N2").Replace(".", ",");
        }

        public static string GetStringLimitada(string text, int limitCaracters) 
        {
            return text.Length > limitCaracters ? $"{text.Substring(0, limitCaracters)}..." : text;
        }

    }
}