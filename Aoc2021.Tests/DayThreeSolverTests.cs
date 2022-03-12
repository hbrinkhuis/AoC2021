using AoC2021.Solutions;
using Xunit;
using AoC2021.Solutions._03;
using FluentAssertions;

namespace Aoc2021.Tests;

public class DayThreeSolverTests
{
    private readonly ISolver _sut;

    public DayThreeSolverTests()
    {
        string[] lines = {
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

        _sut = new DayThreeSolver(lines);
    }
    [Fact]
    public void PartOneTest()
    {
        var result = _sut.SolvePartOne();

        result.Should().Be("198");
    }

    [Fact]
    public void PartTwoTest()
    {
        var result = _sut.SolvePartTwo();

        result.Should().Be("230");
    }
}