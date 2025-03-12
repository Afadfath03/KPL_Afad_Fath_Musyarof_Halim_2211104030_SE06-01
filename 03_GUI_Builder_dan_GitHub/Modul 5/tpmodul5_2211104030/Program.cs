class Program {
    private static void Main(string[] args) {
        Console.Write("Masukkan nama: ");
        string nama = Console.ReadLine();
        HaloGeneric.SapaUser(nama);
    }
}

class HaloGeneric {
    public static void SapaUser(string name) {
        Console.WriteLine($"Halo user {name}");
    }
}