using System;
using System.Collections.Generic;

namespace GeneticAlgorithmWPF.Models;

public class Individ
{
    private static readonly Random Random = new ();
        
    // Границы поиска минимума
    private readonly double _start;
    private readonly double _end;

    private readonly int _mutationSteps;

    private readonly int _countOfComponents;

    public readonly List<double> Components = new ();
    
    public double Score;

    public readonly Func<List<double>, double> CalculateFunction;
        
    public Individ(double start, double end, int mutationSteps, int countOfComponents, Func<List<double>, double> calculateFunction)
    {
        _start = start;
        _end = end;
        
        _mutationSteps = mutationSteps;

        _countOfComponents = countOfComponents;

        for (var i = 0; i < countOfComponents; i++)
        {
            Components.Add(GetRandomDoubleFromRange(start, end));
        }

        CalculateFunction = calculateFunction;
        
        Score = CalculateFunction(Components);
    }
}