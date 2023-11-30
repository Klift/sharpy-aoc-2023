using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daily_aoc_solutions
{
    public abstract class DailySolutionBase : IDailySolution
    {

        public string ExampleInputPath => Utils.GetInputPath(this.GetType().Name, "example");
        public string CompleteInputPath => Utils.GetInputPath(this.GetType().Name, "complete");
        public string ExpectedOutputPathPart1 => Utils.GetExpectedExampleOutputPath(this.GetType().Name, 1);
        public string ExpectedOutputPathPart2 => Utils.GetExpectedExampleOutputPath(this.GetType().Name, 2);
        public abstract void ReadInput(string inputPath);
        public abstract void SolvePart1();
        public abstract void SolvePart2();
        public abstract string WriteOutput(string outputPath);
    }
}
