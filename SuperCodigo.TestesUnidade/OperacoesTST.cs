using System;
using Xunit;

namespace SuperCodigo.TestesUnidade
{
    public class OperacoesTST
    {
        //Existe o caractere A e está na posição 3
        [Theory]
        [InlineData("TIAO DA LAZA", "A")]
        public void ObterPosicaoCaractereTST1(string cadeia, string caractere)
        {
            var position = Operacoes.ObterPosicaoCaractere(cadeia, caractere);

        
            Assert.Equal(3, position);
        }

        //Não existe o caractere "J"
        [Theory]
        [InlineData("CARACTERE INVALIDO", "J")]
        public void ObterPosicaoCaractereTST2(string cadeia, string caractere)
        {
            var position = Operacoes.ObterPosicaoCaractere(cadeia, caractere);

            Assert.Equal(-1, position);
        }

        //Cadeia Maior que 20
        [Theory]
        [InlineData("TESTE PARA BOBO MAIS UMA VEZ", "J")]
        public void ObterPosicaoCaractereTST3(string cadeia, string caractere)
        {

            ArgumentException ex = Assert.Throws<ArgumentException>( () => Operacoes.ObterPosicaoCaractere(cadeia, caractere));

            Assert.Equal(ConstantesOperacoes.CADEIA_CARACTERES_CADEIA_INVALIDA, ex.Message);
        }

        //Tamanho da Cadeia igual a 1
        [Theory]
        [InlineData("Tiao Laza", "JJ")]
        public void ObterPosicaoCaractereTST4(string cadeia, string caractere)
        {

            ArgumentException ex = Assert.Throws<ArgumentException>(() => Operacoes.ObterPosicaoCaractere(cadeia, caractere));

            Assert.Equal(ConstantesOperacoes.CADEIA_CARACTERES_CARACTERE_INVALIDO, ex.Message);
        }

        //Teste FIBONACCI 1
        [Theory]
        [InlineData(0)]
        public void ObterElementoFibonnaciTST1(int n)
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => Operacoes.ObterElementoFibonnaci(n));

            Assert.Equal(ConstantesOperacoes.FIBONNACI_MAIOR_QUE_ZERO, ex.Message);
        }

        //Teste FIBONACCI 2
        [Theory]
        [InlineData(2)]
        public void ObterElementoFibonnaciTST2(int n)
        {
            var fibo = Operacoes.ObterElementoFibonnaci(n);

            Assert.Equal(1, fibo);
        }

        //Teste FIBONACCI 3
        [Theory]
        [InlineData(8)]
        public void ObterElementoFibonnaciTST3(int n)
        {
            var fibo = Operacoes.ObterElementoFibonnaci(n);

            Assert.Equal(21, fibo);
        }
        //Teste triangulo inexistente
        [Theory]
        [InlineData(0,0,0)]
        [InlineData(2, 1, 10)]
        public void DeterminarTipoTrianguloTST1(int a, int b, int c)
        {
            var tipo = Operacoes.DeterminarTipoTriangulo(a,b,c);

            Assert.Equal("INEXISTENTE", tipo);
        }
        //Teste triangulo equilatero
        [Theory]
        [InlineData(5, 5, 5)]
        public void DeterminarTipoTrianguloTST2(int a, int b, int c)
        {
            var tipo = Operacoes.DeterminarTipoTriangulo(a, b, c);

            Assert.Equal("EQUILATERO", tipo);
        }
        //Teste triangulo ISOSCELES
        [Theory]
        [InlineData(5, 5, 2)]
        [InlineData(5, 10, 10)]
        [InlineData(10, 5, 10)]
        public void DeterminarTipoTrianguloTST3(int a, int b, int c)
        {
            var tipo = Operacoes.DeterminarTipoTriangulo(a, b, c);

            Assert.Equal("ISOSCELES", tipo);
        }
        
        //Teste triangulo Escaleno
        [Theory]
        [InlineData(10, 12, 13)]

        public void DeterminarTipoTrianguloTST4(int a, int b, int c)
        {
            var tipo = Operacoes.DeterminarTipoTriangulo(a, b, c);

            Assert.Equal("ESCALENO", tipo);
        }
    }

}
