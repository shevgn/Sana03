// See https://aka.ms/new-console-template for more information

int N;
Console.WriteLine("Enter size N: ");
if (int.TryParse(Console.ReadLine(), out N))
{
    var array = new int[N];
    var rand = new Random();
    for (int i = 0; i < N; i++)
    {
        array[i] = rand.Next(-20, 20);
        Console.WriteLine(array[i]);
    }
}
