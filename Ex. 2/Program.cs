double[] sal2 = new double[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o salário da {i + 1}ª pessoa: ");
    sal2[i] = double.Parse(Console.ReadLine());
    if (sal2[i] < 1000)
    {
        sal2[i] *= 1.1;
    }
}

Console.WriteLine("Lista de salários atualizada:");
foreach (double sal in sal2)
{
    Console.WriteLine(sal);
}