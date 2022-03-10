using System.Collections.Immutable;

namespace AoC2021.Solutions;

public abstract class AbstractSolver
{
    protected ImmutableArray<string> Lines { get; }

    protected AbstractSolver(IEnumerable<string> lines)
    {
        Lines = lines.ToImmutableArray();
    }
}