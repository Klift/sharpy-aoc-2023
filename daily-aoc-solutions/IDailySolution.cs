using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daily_aoc_solutions
{
    public interface IDailySolution
    {
        string ExampleInputPath { get;  }
        string CompleteInputPath { get;  }
        string ExpectedOutputPathPart1 { get; }
        string ExpectedOutputPathPart2 { get; }
        void ReadInput(string inputPath);
        void SolvePart1();
        void SolvePart2();
        string WriteOutput(string outputPath);
    }
}
