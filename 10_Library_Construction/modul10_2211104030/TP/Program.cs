using Aljabar;

double[] akar = Class1.AkarKuadrat(new double[] { 1, -2, -3 });
double[] hasil = Class1.HasilKuadrat(new double[] { 2, -3 });


Console.WriteLine("Akar-akar persamaan (1, -2, -3) : " + string.Join(", ", akar));
Console.WriteLine("Hasil kuadrat (2, -3): " + string.Join(", ", hasil));