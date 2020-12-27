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
    }
}