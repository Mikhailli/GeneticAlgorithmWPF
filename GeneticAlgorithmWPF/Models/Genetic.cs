using System;
using System.Collections.Generic;

namespace GeneticAlgorithmWPF.Models;

public class Genetic
{
    private static readonly Random Random = new(); 
    
    // Размер популяции
    private readonly int _numberOfIndivids;

    // Какая часть популяции должна производить потомство
    private readonly double _crossoverRate;

    private readonly int _mutationSteps;

    // Вероятность мутации
    private readonly double _mutationChance;

    // Сколько раз будет появляться новое поколение
    private readonly int _numberLives;

    private readonly int _countOfComponents;
    
    // Координаты найденного минимума
    private List<double> _coordinatesOfMinimum = new ();

    // Найденный минимум
    public double Minimum;

    // Границы поиска минимума
    private readonly double _start;
    private readonly double _end;

    private readonly Func<List<double>, double> _calculateFunction;
    
    public Genetic(int numberOfIndivids, double crossoverRate, int mutationSteps, double mutationChance,
        int numberLives, double start, double end, int countOfComponents, Func<List<double>, double> calculateFunction)
    {
        _numberOfIndivids = numberOfIndivids;
        _crossoverRate = crossoverRate;
        _mutationSteps = mutationSteps;
        _mutationChance = mutationChance;
        _numberLives = numberLives;
        _countOfComponents = countOfComponents;

        for (var i = 0; i < countOfComponents; i++)
        {
            _coordinatesOfMinimum.Add(end);
        }
        
        Minimum = double.MaxValue;
        
        _start = start;
        _end = end;

        _calculateFunction = calculateFunction;
    }
}