using System.Collections.Immutable;

namespace AoC2021.Solutions;

internal abstract class AbstractSolver
{
    protected ImmutableArray<string> Lines { get; }

    protected AbstractSolver(string fileName)
    {
        Lines = File.ReadLines($"Inputs/{fileName}").ToImmutableArray();
    }
}