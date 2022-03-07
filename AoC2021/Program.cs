using AoC2021.Solutions;
using AoC2021.Solutions.DayOne;
using AoC2021.Solutions.DayTwo;

var solvers = new List<ISolver> {new DayOneSolver(), new DayTwoResolver()};

foreach (var solver in solvers)
{
    Console.WriteLine($"Day {solver.Day} part 1 answer: {solver.SolvePartOne()}");
    Console.WriteLine($"Day {solver.Day} part 2 answer: {solver.SolvePartTwo()}");
}