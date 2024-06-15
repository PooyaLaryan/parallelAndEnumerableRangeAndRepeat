// See https://aka.ms/new-console-template for more information
Parallel.ForEach(Enumerable.Range(1, 10), x =>
{
    Console.WriteLine(x);
});


Parallel.ForEach(Enumerable.Repeat(1, 10), (x,y) =>
{
    Console.WriteLine(x);
});
