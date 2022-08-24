// See https://aka.ms/new-console-template for more information

var l = 2;
var r = 5;
var result = new List<int>();
for (int i = l; l<=r;l++)
{
    if (i % 2 != 0)
        result.Add(i);
}

Console.WriteLine($"Result {result}");
Console.ReadKey();