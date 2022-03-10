using Xunit;
using AoC2021.Solutions._03;
using FluentAssertions;

namespace Aoc2021.Tests;

public class DayThreeSolverTests
{
    [Fact]
    public void ExampleTest()
    {
        string[] lines =
        {
            "00100",
            "11110",
            "10110",
            "10111",
            "10101",
            "01111",
            "00111",
            "11100",
            "10000",
            "11001",
            "00010",
            "01010"
        };

        var sut = new DayThreeSolver(lines);

        var result = sut.SolvePartOne();

        result.Should().Be("198");
    }
}