using System;
using ConsoleDesafioTDD.Entities;
using Xunit;
using Xunit.Abstractions;

namespace TesteDesafioTDD
{
    public class TesteVeiculo
    {
        private readonly ITestOutputHelper _output;
        public TesteVeiculo(ITestOutputHelper output)
        {
            _output = output;
        }
        [Fact]    
        [Trait("Categoria","Velocidade")]  
        public void DeveriaRetonarUmValorMaisVinte()
        {   
            Veiculo carro = new Veiculo("Jipe","Regenate","PEQ-2805","Azul",0.0f,false,20,30,20000.00);

            // Given
            var velocidadeAtual = carro.Velocidade;
            var experado  = velocidadeAtual + 20;
            // When
            var resultado = carro.Acelerar();
            // Then
            _output.WriteLine($"DeveriaRetonarUmValorMaisVinte Input {velocidadeAtual} Expected: {experado} e Resultado: {resultado}");
            Assert.Equal(experado,resultado);
        } 
        
        [Theory(DisplayName = "Teoria de diminuição de velocidade")]
        [Trait("Categoria","Velocidade")]
        //Arrange
        [InlineData(30,10)]
        [InlineData(50,30)]
        [InlineData(20,0)]
        [InlineData(10,0)]

        public void DeveriaDiminuirAVelocidadeMenosVinte(int entrada,int esperado)
        {
            Veiculo carro = new Veiculo("Jipe","Regenate","PEQ-2805","Azul",0.0f,false,20,entrada,20000.00);
            // When
            var resultado = carro.Frear();
            // Then
            _output.WriteLine($"DeveriaRetonarUmValorMenosVinte Input {entrada} Expected: {esperado} e Resultado: {resultado}");
            Assert.Equal(esperado,resultado);
        }
        //AAA
        //Arrange = Organizar
        
        //Act = Agir

        //Assert = Afirmar

    }
}
