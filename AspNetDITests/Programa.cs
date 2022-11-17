using AspNetDependencyInjection.Models;

namespace AspNetDITests;

public class ProgramaTest
{
    [Theory]
    [InlineData("10:00", "12:00")]
    [InlineData("11:00", "13:00")]
    [InlineData("23:00", "01:00")]
    public void Programa_WhenHasValues_ShouldComputeDateEnd(string _HorarioInicio, string _Expected)
    {
        // arrange
        var programa = new Programa()
        {
            Duracao = 120,
            HorarioInicio = _HorarioInicio
        };

        // act
        var horarioTermino = programa.HorarioTermino;

        // assert
        Assert.Equal(_Expected, horarioTermino);
    }
}
