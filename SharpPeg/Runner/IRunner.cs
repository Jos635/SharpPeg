﻿using System.Collections.Generic;

namespace SharpPeg.Runner
{
    public interface IRunner
    {
        IEnumerable<string> GetPatternsTriedAt(int index);
        IEnumerable<string> GetPatternsFinishedAt(int index);
        string ExplainResult(RunResult result, string inputData);
        RunResult Run(string stringData, List<Capture> captureOutput = null);
        RunResult Run(char[] data, int index, int length, List<Capture> captureOutput = null);
    }
}