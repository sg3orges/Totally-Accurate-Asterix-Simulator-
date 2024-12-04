// See https://aka.ms/new-console-template for more information

using TAAS;

Console.WriteLine("Hello, World!");


MyRandom a = new MyRandom(42); // Constructor is implemented next exercise
Console.WriteLine(a.seed); // 81973 = |8944 * sqrt(42 + 42)| % 5150757
Console.WriteLine(a.seed); // 2561406 = |8944 * sqrt(81973 + 42)| % 5150757
Console.WriteLine( a.seed); // ...
Console.WriteLine(a.seed);
Console.WriteLine(a.seed);


MyRandom r = new MyRandom(42);
Console.WriteLine(r.Next(12)); // 1
Console.WriteLine(r.Next(12)); // 6
Console.WriteLine(r.Next(12)); // 0
Console.WriteLine(r.NextMin(5, 7)); // 6
Console.WriteLine(r.NextMin(5, 7)); // 5
Console.WriteLine(r.NextMin(5, 7)); // 5

