using divisima.Enums.ProdutoEnums;
using divisima.Models;
using divisima.Repository.Contracts;
using Divisima.Enums.GeneroEnum;
using Divisima.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Divisima.Tests.RepositoryTest
{
    public class ProdutoRepositoryTest
    {
        [Fact(DisplayName = "Testar método obter um produto por id")]
        public async Task Obter_Produto_Por_Id_Success_Async()
        {
            var produto = new Produto
            {
                ProdutoId = 1,
                CategoriaId = 1,
                Nome = Faker.Company.Name(),
                Descricao = "Alguma Descricao",
                Valor = Faker.RandomNumber.Next(),
                Quantidade = Faker.RandomNumber.Next(),
                Tamanho = (int)ProdutoTamanhoEnum.P,
                DataCadastro = Faker.DateOfBirth.Next(),
                Genero = GeneroEnum.Masculino           
            };

            var produtoRepositoryMock = new Mock<IProdutoRepository>();
            produtoRepositoryMock.Setup(p => p.GetById(produto.ProdutoId)).ReturnsAsync(produto);
            var produtoRepository = produtoRepositoryMock.Object;

            var produtoResult = await produtoRepository.GetById(produto.ProdutoId);
            Assert.NotNull(produtoResult);
            Assert.True(produtoResult.ProdutoId == produto.ProdutoId);
            Assert.Equal(produtoResult.Nome, produto.Nome);

            produtoRepositoryMock = new Mock<IProdutoRepository>();
            produtoRepositoryMock.Setup(p => p.GetById(It.IsAny<long>())).ReturnsAsync((Produto) null);
            produtoRepository = produtoRepositoryMock.Object;

            var produtoResultNotFound = await produtoRepository.GetById(produto.ProdutoId);
            Assert.Null(produtoResultNotFound);
        }
    }
}
