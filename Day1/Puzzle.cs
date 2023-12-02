﻿namespace Day1;

public static class Puzzle
{
    public static int Run(string filename) => File.ReadAllLines(filename).Select(ExtractNumberFromString.ExtractCalibration).Sum();
}
