﻿using Campeonato.Models;

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
            Nome = "time A",
            GolsFeitos = 5,
            GolsSofridos = 2
        });
        times.Add(new Time()
        {
            Nome = "time B",
            GolsFeitos = 8,
            GolsSofridos = 5
        });
        times.Add(new Time()
        {
            Nome = "time C",
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
        Assert.That(resultado.First().Nome, Is.EqualTo("time A"));
    }

    [Test]
    public void WhenHasTime_ShouldReturnClassificadosComMaisGols()
    {
        // Prepare
        var campeonato = new Competicao(times);

        // Act
        var resultado = campeonato.ClassificadosComMaisGols();

        // Check
        Assert.That(resultado, Is.Not.Empty);
        Assert.That(resultado, Has.Count.EqualTo(2));
        Assert.That(resultado.First().Nome, Is.EqualTo("time B"));
    }
}