namespace AoC2021.Solutions.DayTwo;

internal class DayTwoResolver : AbstractSolver, ISolver
{
    public DayTwoResolver() : base("day2.txt")
    {
    }

    public string SolvePartOne()
    {
        var distance = 0;
        var depth = 0;
        foreach (var line in Lines)
        {
            var tuple = line.Split(" ");
            var size = int.Parse(tuple[1]);
            switch (tuple[0])
            {
                case "forward":
                    distance += size;
                    break;
                case "up":
                    depth -= size;
                    break;
                case "down":
                    depth += size;
                    break;
            }
        }

        return (depth * distance).ToString();
    }

    public string SolvePartTwo()
    {
        var distance = 0;
        var aim = 0;
        var depth = 0;
        foreach (var line in Lines)
        {
            var tuple = line.Split(" ");
            var size = int.Parse(tuple[1]);
            switch (tuple[0])
            {
                case "forward":
                    distance += size;
                    depth += (size * aim);
                    break; 
                case "up":
                    aim -= size;
                    break;
                case "down":
                    aim += size;
                    break;
            }
        }

        return (depth * distance).ToString();
    }

    public int Day => 2;
}