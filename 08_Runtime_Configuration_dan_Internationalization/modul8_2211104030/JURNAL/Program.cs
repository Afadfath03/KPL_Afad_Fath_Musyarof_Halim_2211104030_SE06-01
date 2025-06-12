using JURNAL;

static void Main(string[] args)
{
    BankTransferConfig config = BankTransferConfig.LoadOrCreateConfig();
    string lang = config.Lang;
    string confirmWord = lang == "en" ? config.Confirmation.En : config.Confirmation.Id;

    Console.WriteLine(lang == "en" ?
        "Please insert the amount of money to transfer:" :
        "Masukkan jumlah uang yang akan di-transfer:");

    if (!int.TryParse(Console.ReadLine(), out int amount))
    {
        Console.WriteLine(lang == "en" ? "Invalid amount." : "Jumlah tidak valid.");
        return;
    }

    int fee = amount <= config.Transfer.Threshold ? config.Transfer.LowFee : config.Transfer.HighFee;
    int total = amount + fee;

    Console.WriteLine(lang == "en" ?
        $"Transfer fee = {fee}\nTotal amount = {total}" :
        $"Biaya transfer = {fee}\nTotal biaya = {total}");

    Console.WriteLine(lang == "en" ? "Select transfer method:" : "Pilih metode transfer:");
    for (int i = 0; i < config.Methods.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {config.Methods[i]}");
    }

    Console.ReadLine(); // Ambil input metode transfer (tidak digunakan lanjut)

    Console.WriteLine(lang == "en" ?
        $"Please type \"{confirmWord}\" to confirm the transaction:" :
        $"Ketik \"{confirmWord}\" untuk mengkonfirmasi transaksi:");

    string userInput = Console.ReadLine();

    if (userInput.ToLower() == confirmWord.ToLower())
    {
        Console.WriteLine(lang == "en" ? "The transfer is completed" : "Proses transfer berhasil");
    }
    else
    {
        Console.WriteLine(lang == "en" ? "Transfer is cancelled" : "Transfer dibatalkan");
    }
}