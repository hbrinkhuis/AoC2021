namespace AoC2021.Solutions;

public interface ISolver
{
    string SolvePartOne();

    string SolvePartTwo();
    
    int Day { get; }
}