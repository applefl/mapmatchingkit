﻿using BenchmarkDotNet.Running;
using System;
using System.IO;

namespace Sandwych.MapMatchingKit.BenchmarkApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            var switcher = new BenchmarkSwitcher(new[]
            {
                typeof(RoutersBenchmark),
                typeof(SpatialIndexBenchmark),
            });

            switcher.Run(args);
            Console.ReadKey();
        }
    }
}
