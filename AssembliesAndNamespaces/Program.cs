﻿using System;
using static System.Console;
using System.Xml.Linq;
using DialectSoftware.Collections;
using DialectSoftware.Collections.Generics;

namespace AssembliesAndNamespaces;

internal class Program
{
    static void Main(string[] args)
    {
        Axis x = new("x", 0, 10, 1);
        Axis y = new("y", 0, 4,1);
        Matrix<long> matrix = new(new[] { x, y });
        for(int i=0; i < matrix.Axes[0].Points.Length; i++)
        {
            matrix.Axes[0].Points[i].Label = "x" + i.ToString();
        }
        for (int i = 0; i < matrix.Axes[1].Points.Length; i++)
        {
            matrix.Axes[1].Points[i].Label = "y" + i.ToString();
        }
        foreach (long[] c in matrix)
        {
            matrix[c] = c[0] + c[1];
        }
        foreach (long[] c in matrix)
        {
            WriteLine(
                "{0},{1} ({2},{3}) = {4}",
                matrix.Axes[0].Points[c[0]].Label,
                matrix.Axes[1].Points[c[1]].Label,
                c[0], c[1], matrix[c]
                );
        }
    }
}