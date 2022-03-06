using AoC2021.Solutions;
using AoC2021.Solutions.DayOne;

var solvers = new List<ISolver> {new DayOneSolver()};

foreach (var solver in solvers)
{
    Console.WriteLine($"Day {solver.Day} part 1 answer: {solver.SolvePartOne()}");
    Console.WriteLine($"Day {solver.Day} part 2 answer: {solver.SolvePartTwo()}");
}