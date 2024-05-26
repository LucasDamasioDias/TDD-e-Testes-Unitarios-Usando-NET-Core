namespace CalculadoraTeste
{
    public class UnitTest1

    {
        Calculadora _calculadora = new Calculadora();


        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSoma(int x, int y, int resultadoDoTeste)
        {
         
            int resultadoDaCalculadora = _calculadora.Somar(x, y);

            Assert.Equal(resultadoDoTeste, resultadoDaCalculadora);
        }


        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(9, 5, 4)]
        public void TesteSubtracao(int x, int y, int resultadoDoTeste)
        {
           
            int resultadoDaCalculadora = _calculadora.Subtrair(x, y);

            Assert.Equal(resultadoDoTeste, resultadoDaCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicacao(int x, int y, int resultadoDoTeste)
        {
            
            int resultadoDaCalculadora = _calculadora.Multiplicar(x, y);

            Assert.Equal(resultadoDoTeste, resultadoDaCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDivisao(int x, int y, int resultadoDoTeste)
        {
            
            int resultadoDaCalculadora = _calculadora.Dividir(x, y);

            Assert.Equal(resultadoDoTeste, resultadoDaCalculadora);
        }

        [Fact]
        public void divisaoPorZero() 
        {
            Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            _calculadora.Somar(1, 2);
            _calculadora.Subtrair(4, 2);
            _calculadora.Multiplicar(5, 6);
            _calculadora.Dividir(20, 5);

            var lista = _calculadora.Historico();

            Assert.NotEmpty(_calculadora.Historico());
            Assert.Equal(3, lista.Count);
        }
    }


}