using DTO.Model;
using Model.Abstract;
using Model.Concret;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public async Task TestCriarPessoa()
        {
            // Arrange
            var novaPessoa = new PessoaFisicaDTO
            {
                NomeCompleto = "John Doe",
                DataNascimento = DateTime.Parse("1990-01-01"),
                ValorRenda = 5000.00m,
                CPF = "12345678901"
            };

            var content = new StringContent(JsonConvert.SerializeObject(novaPessoa), Encoding.UTF8, "application/json");

            // Act
            HttpClient _client = new HttpClient();
            var response = await _client.PostAsync("/Pessoafisica", content);

            // Assert
            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        }

        [Fact]
        public async Task TestListarPessoas()
        {
            HttpClient _client = new HttpClient();
            var response = await _client.GetAsync("/Pessoafisica");

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var contentString = await response.Content.ReadAsStringAsync();
            var pessoas = JsonConvert.DeserializeObject<List<PessoaFisicaDTO>>(contentString);

            Assert.NotNull(pessoas);
            Assert.True(pessoas.Count > 0);
        }
    }
}