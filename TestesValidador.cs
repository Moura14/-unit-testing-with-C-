using System.ComponentModel.DataAnnotations;
using Xunit;


public class Validator
{

    public bool ParOrImpar(int numero) => numero % 2 == 0;
}






public class ValidadorTestes
{

    [Theory]
    [InlineData (2, true)]
    [InlineData (3, false)]
    [InlineData (4, true)]
    [InlineData (-5, false)]
    [InlineData (6, false)]

    public void RetornarValor(int numero, bool resultadoEsperado)
    {
        var validator = new Validator();
       var resultado =  validator.ParOrImpar(numero);

        Assert.Equal(resultadoEsperado, resultado);



       
    }
}