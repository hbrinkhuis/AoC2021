using AoC2021.Solutions;
using AoC2021.Solutions._01;
using AoC2021.Solutions._02;
using AoC2021.Solutions._03;

IEnumerable<string> ReadLines(string fileName) => File.ReadLines($"Inputs/{fileName}");

var solvers = new List<ISolver>
{
    new DayOneSolver(ReadLines("day1.txt")), 
    new DayTwoSolver(ReadLines("day2.txt")), 
    new DayThreeSolver(ReadLines("day3.txt"))
};

foreach (var solver in solvers)
{
    Console.WriteLine($"Day {solver.Day} part 1 answer: {solver.SolvePartOne()}");
    Console.WriteLine($"Day {solver.Day} part 2 answer: {solver.SolvePartTwo()}");
}