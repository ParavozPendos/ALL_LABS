using System.Collections.Generic;
using System.IO;
using System.Linq;
using ScottPlot;

public static class PlotDrawer
{
    public static void SavePlots(Dictionary<string, List<long>> data, int[] sizes)
    {
        string desktop = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);
        string folder = Path.Combine(desktop, "AT_LAB_1");
        Directory.CreateDirectory(folder);

        string[] types = { "Случайный", "Обратный", "Частичный" };

        foreach (var type in types)
        {
            var plt = new Plot();
            plt.Title($"Сравнение алгоритмов — {type} массив");
            plt.XLabel("Размер массива (N)");
            plt.YLabel("Число операций");

            double[] xs = sizes.Select(x => (double)x).ToArray();

            // Пузырьковая
            var bubbleVals = data[$"Bubble_{type}"].Select(v => (double)v).ToArray();
            var bubbleLine = plt.Add.Scatter(xs, bubbleVals);
            bubbleLine.LegendText = "Пузырьковая";
            bubbleLine.LineWidth = 2;

            // Слиянием
            var mergeVals = data[$"Merge_{type}"].Select(v => (double)v).ToArray();
            var mergeLine = plt.Add.Scatter(xs, mergeVals);
            mergeLine.LegendText = "Слиянием";
            mergeLine.LineWidth = 2;

            plt.ShowLegend();
            plt.SavePng(Path.Combine(folder, $"{type}.png"), 800, 600);
        }
    }
}