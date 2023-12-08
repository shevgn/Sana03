// See https://aka.ms/new-console-template for more information

int N;
double MAX_VALUE = 30.0;
double MIN_VALUE = -30.0;
Console.WriteLine("Enter size N: ");
if (int.TryParse(Console.ReadLine(), out N))
{
    var array = new double[N];
    var rand = new Random();
    
    double sumNeg = 0;

    double min = 9999;
    double max = -9999;
    var maxIndex = 0;
    double maxModulo = -9999;
    for (int i = 0; i < N; i++)
    {
        array[i] = rand.NextDouble() * (MAX_VALUE - MIN_VALUE) + MIN_VALUE;
        Console.WriteLine("array[{0}] = {1:N3}", i, array[i]);

        if (array[i] < 0)
        {
            sumNeg += array[i];
        }

        if (array[i] < min)
        {
            min = array[i];
        }

        if (array[i] > max)
        {
            max = array[i];
            maxIndex = i;
        }

        if (Math.Abs(array[i]) > maxModulo)
        {
            maxModulo = array[i];
        }

    }

    Console.WriteLine("Sum of negative elements: {0:N3}", sumNeg);
    Console.WriteLine("Min element: {0:N3}", min);
    Console.WriteLine("Max element index: " + maxIndex);
    Console.WriteLine("Maximum by module: {0:N3}", maxModulo);

}
