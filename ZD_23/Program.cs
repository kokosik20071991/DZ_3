int N;
Console.Write($"Введите число N: ");
int.TryParse(Console.ReadLine(), out N);
for (int i = 1; i <= N; i++) 
Console.Write($" {i * i * i}");