using Campeonato.Models;

namespace CampeonatoTests;

public class Tests
{
    public List<Time> times { get; set; }
    [SetUp]
    public void Setup()
    {
        times = new List<Time>();
        times.Add(new Time()
        {
            GolsFeitos = 5,
            GolsSofridos = 2
        });
        times.Add(new Time()
        {
            GolsFeitos = 4,
            GolsSofridos = 2
        });
        times.Add(new Time()
        {
            GolsFeitos = 3,
            GolsSofridos = 2
        });
    }

    [Test]
    public void WhenHasTime_ShouldReturnCorrect()
    {
        // Prepare
        var campeonato = new Competicao(times);

        // Act
        var resultado = campeonato.Classificados();

        // Check
        Assert.That(resultado, Is.Not.Empty);
        Assert.That(resultado, Has.Count.EqualTo(2));
    }
}
