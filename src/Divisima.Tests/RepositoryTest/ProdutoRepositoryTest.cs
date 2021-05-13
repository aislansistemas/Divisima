using divisima.Enums.ProdutoEnums;
using divisima.Models;
using divisima.Repository.Contracts;
using Divisima.Enums.GeneroEnum;
using Divisima.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Divisima.Tests.RepositoryTest
{
    public class ProdutoRepositoryTest
    {
        private readonly Produto _produto;
        public ProdutoRepositoryTest()
        {
            _produto = new Produto
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

        }

        [Fact(DisplayName = "Testar método obter um produto por id")]
        public async Task Obter_Produto_Por_Id_Async()
        {
            var produtoRepositoryMock = new Mock<IProdutoRepository>();
            produtoRepositoryMock.Setup(p => p.GetById(_produto.ProdutoId)).ReturnsAsync(_produto);
            var produtoRepository = produtoRepositoryMock.Object;

            var produtoResult = await produtoRepository.GetById(_produto.ProdutoId);
            Assert.NotNull(produtoResult);
            Assert.True(produtoResult.ProdutoId == _produto.ProdutoId);
            Assert.Equal(produtoResult.Nome, _produto.Nome);

            produtoRepositoryMock = new Mock<IProdutoRepository>();
            produtoRepositoryMock.Setup(p => p.GetById(It.IsAny<long>())).ReturnsAsync((Produto) null);
            produtoRepository = produtoRepositoryMock.Object;

            var produtoResultNotFound = await produtoRepository.GetById(_produto.ProdutoId);
            Assert.Null(produtoResultNotFound);
        }

        [Fact(DisplayName = "Testar método obter todos os produtos")]
        public async Task Obter_Todos_Produtos_Test_Async()
        {
            var limit = 20;
            var offSet = 0;

            var produtosList = new List<Produto>();
            for(int i = 0; i < 10; i++)
            {
                var produto = new Produto
                {
                    ProdutoId = new Random().Next(),
                    CategoriaId = new Random().Next(),
                    Nome = Faker.Company.Name(),
                    Descricao = Faker.Lorem.Paragraph(),
                    Valor = Faker.RandomNumber.Next(),
                    Quantidade = Faker.RandomNumber.Next(),
                    Tamanho = (int) ProdutoTamanhoEnum.P,
                    DataCadastro = Faker.DateOfBirth.Next(),
                    Genero = GeneroEnum.Masculino
                };

                produtosList.Add(produto);
            }

            var produtoRepositoryMock = new Mock<IProdutoRepository>();
            produtoRepositoryMock.Setup(p => p.GetAll(offSet, limit)).ReturnsAsync(produtosList);
            var produtoRepository = produtoRepositoryMock.Object;

            var produtosResult = await produtoRepository.GetAll(offSet, limit);
            Assert.NotNull(produtosResult);
            Assert.True(produtosResult.Count == produtosList.Count);

            produtoRepositoryMock = new Mock<IProdutoRepository>();
            produtoRepositoryMock.Setup(p => p.GetAll(It.IsAny<int>(), It.IsAny<int>())).ReturnsAsync(new List<Produto>());
            produtoRepository = produtoRepositoryMock.Object;

            produtosResult = await produtoRepository.GetAll(offSet, limit);
            Assert.Empty(produtosResult);
            Assert.True(produtosResult.Count() != produtosList.Count);
        }
    }
}
