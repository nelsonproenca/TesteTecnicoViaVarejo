using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteTecnico.AmigosProximos.ConsoleApp.Dll;

namespace TesteTecnico.AmigosProximos.Console.Tests
{
    [TestClass]
    public class DistanciaTest
    {
        [TestMethod]
        public void Test_Distancia()
        {
            Amigo amigoAtual = new Amigo()
            {
                Id = 1,
                Nome = "Breno",
                Visitando = true,
                Coordenadas = new CoordenadasAmigo()
                {
                    IdAmigo = 1,
                    Latitude = -23.6914,
                    Longitude = -46.5646          
                }
            };

            Amigo amigoBusca = new Amigo()
            {
                Id = 2,
                Nome = "Walter",
                Visitando = false,
                Coordenadas = new CoordenadasAmigo()
                {
                    IdAmigo = 2,
                    Latitude = -21.9736,
                    Longitude = -44.6042
                }
            };

            double esperado = 1300;

            double calculado = Distancia.CalcularDistancia(amigoAtual, amigoBusca);

            Assert.AreEqual(esperado, calculado);
        }
    }
}
