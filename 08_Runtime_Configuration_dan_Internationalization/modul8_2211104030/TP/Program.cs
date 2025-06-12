using TP;

class Program
{
    static void Main()
    {
        CovidConfig config = CovidConfig.Load();

        Console.Write("Apakah Anda ingin mengganti satuan suhu? (y/n): ");
        if (Console.ReadLine().ToLower() == "y")
        {
            config.GantiJenis();
            Console.WriteLine("Satuan suhu telah diubah menjadi " + config.Jenis);
        }

        Console.Write($"Berapa suhu badan anda saat ini? Dalam nilai {config.Jenis}: ");
        double suhu = Convert.ToDouble(Console.ReadLine());

        Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam? ");
        int Hari = Convert.ToInt32(Console.ReadLine());

        bool suhuValidasi = (config.Jenis == "celcius" && suhu <= 37.5) ||
                         (config.Jenis == "fahrenheit" && suhu <= 99.5);

        bool hariValidasi = Hari >= config.Hari;

        Console.WriteLine();
        Console.WriteLine(suhuValidasi && hariValidasi ? config.Tolak : config.Terima);
    }
}