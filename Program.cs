using Quiz4;
using System.Diagnostics;
Stopwatch Tiempo = new Stopwatch();
int[] list = new int[100000];
Random rnd = new Random();
for (int i = 0; i < list.Length; i++)
{
    list[i] = rnd.Next(0, 10000000);
}
Tiempo.Start();
//Quick.QuickSort(list, 0, list.Length - 1);
Bubble.bubbleSort(list);
Tiempo.Stop();
Console.WriteLine("Quick Sort: " + Tiempo.Elapsed.TotalMilliseconds + " ms");
