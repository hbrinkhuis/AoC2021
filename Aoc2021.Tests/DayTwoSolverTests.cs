using AoC2021.Solutions;
using Xunit;
using AoC2021.Solutions._02;
using FluentAssertions;

namespace Aoc2021.Tests;

public class DayTwoSolverTests
{
    private readonly ISolver _sut;

    public DayTwoSolverTests()
    {
        string[] lines = {
            "forward 5",
            "down 5",
            "forward 8",
            "up 3",
            "down 8",
            "forward 2"
        };

        _sut = new DayTwoSolver(lines);
    }
    [Fact]
    public void PartOneTest()
    {
        var result = _sut.SolvePartOne();

        result.Should().Be("150");
    }

    [Fact]
    public void PartTwoTest()
    {
        var result = _sut.SolvePartTwo();

        result.Should().Be("900");
    }
}