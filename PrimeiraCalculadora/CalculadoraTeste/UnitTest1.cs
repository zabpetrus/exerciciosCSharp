using NUnit.Framework;
using Calculadora.Models;


namespace CalculadoraTeste
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            double r = Calculador.Adicionar(1, 3);
            Assert.Equals(r, 4);
            //Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            double m = Calculador.Subrair(5, 10);
            Assert.Equals(m, -5);
        }

        [Test]
        public void Test3()
        {
            double m = Calculador.Multiplicar(0, 2);
            Assert.Equals(m, 0);
        }

        [Test]
        public void Test4()
        {
            double m = Calculador.Dividir(3, 2);
            Assert.Equals(m, 1.5);
        }

    }
}