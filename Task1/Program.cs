int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());

if (A > B)
{
    Console.Write($"{A} - max, {B} - min");
}

else if (A < B)
{
    Console.Write($"{B} - max, {A} - min");
}
