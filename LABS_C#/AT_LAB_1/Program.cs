using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static long Measure(int[] original, Action<int[], Counter> sort)
    {
        int[] copy = new int[original.Length];
        Array.Copy(original, copy, original.Length);
        var c = new Counter();
        sort(copy, c);
        return c.Total;
    }

    static void ShowSortedExample(string description, int[] original)
    {
        int take = Math.Min(original.Length, 20);
        Console.WriteLine(description);
        Console.WriteLine("Исходный:          " + string.Join(" ", original.Take(take)));

        int[] copyBubble = new int[original.Length];
        Array.Copy(original, copyBubble, original.Length);
        SortAlgorithms.BubbleSort(copyBubble, new Counter());
        Console.WriteLine("Пузырьковая (отсорт.): " + string.Join(" ", copyBubble.Take(take)));

        int[] copyMerge = new int[original.Length];
        Array.Copy(original, copyMerge, original.Length);
        SortAlgorithms.MergeSort(copyMerge, new Counter());
        Console.WriteLine("Слиянием (отсорт.): " + string.Join(" ", copyMerge.Take(take)));

        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Введите максимальный размер массива N (>= 10): ");
        int Nmax = int.Parse(Console.ReadLine()!);
        if (Nmax < 10)
        {
            Console.WriteLine("Минимальное значение – 10. Установлено N = 10.");
            Nmax = 10;
        }

        int[] sizes = Enumerable.Range(0, Nmax + 1).ToArray();
        var rng = new Random(12345);
        var data = new Dictionary<string, List<long>>();

        // Инициализация словаря с русскими ключами
        data["Bubble_Случайный"] = new List<long>();
        data["Bubble_Обратный"] = new List<long>();
        data["Bubble_Частичный"] = new List<long>();
        data["Merge_Случайный"] = new List<long>();
        data["Merge_Обратный"] = new List<long>();
        data["Merge_Частичный"] = new List<long>();

        int[] lastRandom = null!, lastReversed = null!, lastPartSorted = null!;

        for (int idx = 0; idx < sizes.Length; idx++)
        {
            int n = sizes[idx];
            Console.Write($"\rОбработка размера {n} из {Nmax}...");

            if (n == 0)
            {
                data["Bubble_Случайный"].Add(0);
                data["Bubble_Обратный"].Add(0);
                data["Bubble_Частичный"].Add(0);
                data["Merge_Случайный"].Add(0);
                data["Merge_Обратный"].Add(0);
                data["Merge_Частичный"].Add(0);
                continue;
            }

            int[] randomArr = Enumerable.Range(1, n).OrderBy(_ => rng.Next()).ToArray();
            int[] reversedArr = Enumerable.Range(1, n).Reverse().ToArray();
            int[] partSortedArr = Enumerable.Range(1, n).ToArray();
            int changes = n / 20;
            for (int i = 0; i < changes; i++)
            {
                int pos = rng.Next(n);
                partSortedArr[pos] = rng.Next(1, n + 1);
            }

            if (idx == sizes.Length - 1)
            {
                lastRandom = randomArr;
                lastReversed = reversedArr;
                lastPartSorted = partSortedArr;
            }

            data["Bubble_Случайный"].Add(Measure(randomArr, SortAlgorithms.BubbleSort));
            data["Bubble_Обратный"].Add(Measure(reversedArr, SortAlgorithms.BubbleSort));
            data["Bubble_Частичный"].Add(Measure(partSortedArr, SortAlgorithms.BubbleSort));
            data["Merge_Случайный"].Add(Measure(randomArr, SortAlgorithms.MergeSort));
            data["Merge_Обратный"].Add(Measure(reversedArr, SortAlgorithms.MergeSort));
            data["Merge_Частичный"].Add(Measure(partSortedArr, SortAlgorithms.MergeSort));
        }

        Console.WriteLine("\nГотово.\n");

        int lastIdx = sizes.Length - 1;
        Console.WriteLine($"Результаты для N = {sizes[lastIdx]}:");
        Console.WriteLine($"Пузырьковая | Случайный:      {data["Bubble_Случайный"][lastIdx],12}");
        Console.WriteLine($"Пузырьковая | Обратный:       {data["Bubble_Обратный"][lastIdx],12}");
        Console.WriteLine($"Пузырьковая | Частичный:      {data["Bubble_Частичный"][lastIdx],12}");
        Console.WriteLine($"Слиянием    | Случайный:      {data["Merge_Случайный"][lastIdx],12}");
        Console.WriteLine($"Слиянием    | Обратный:       {data["Merge_Обратный"][lastIdx],12}");
        Console.WriteLine($"Слиянием    | Частичный:      {data["Merge_Частичный"][lastIdx],12}");

        Console.Write("\nПоказать примеры отсортированных массивов для Nmax? (y/n): ");
        if (Console.ReadLine()?.Trim().ToLower() == "y")
        {
            Console.WriteLine($"\n--- Демонстрация для N = {sizes[lastIdx]} ---\n");
            ShowSortedExample("Случайный массив", lastRandom);
            ShowSortedExample("Обратный массив", lastReversed);
            ShowSortedExample("Частично отсортированный массив", lastPartSorted);
        }

        Console.Write("\nСохранить графики? (y/n): ");
        if (Console.ReadLine()?.Trim().ToLower() == "y")
        {
            PlotDrawer.SavePlots(data, sizes);
            Console.WriteLine("Графики сохранены в папку AT_LAB_1 на рабочем столе.");
        }
        else
        {
            Console.WriteLine("Сохранение отменено.");
        }
    }
}