
// A. Buat dua variabel dengan tipe "PusatDataSingleton"
PusatDataSingleton data1;
PusatDataSingleton data2;

// B. Isi kedua variabel dengan hasil keluaran dari GetDataSingleton()
data1 = PusatDataSingleton.GetDataSingleton();
data2 = PusatDataSingleton.GetDataSingleton();

// C. Pada data1, tambahkan beberapa data nama anggota kelompok dan asisten praktikum
data1.AddSebuahData("Anggota 1: Afad");
data1.AddSebuahData("Anggota 2: Dina");
data1.AddSebuahData("Anggota 3: Fauzan");
data1.AddSebuahData("Anggota 4: Taufik");
data1.AddSebuahData("Anggota 5: Atika");
data1.AddSebuahData("Asisten Praktikum: Naufal & Imelda");

// D. Pada data2, panggil PrintSemuaData() untuk memastikan data yang ditambahkan muncul
Console.WriteLine("Data setelah ditambahkan:");
data2.PrintSemuaData();

// E. Pada data2, hapus nama asisten praktikum
data2.HapusSebuahData(5);

// F. Pada data1, panggil PrintSemuaData() untuk memastikan asisten praktikum telah dihapus
Console.WriteLine("\nData setelah menghapus asisten praktikum:");
data1.PrintSemuaData();

// G. Pada data1 dan data2, panggil GetSemuaData() dan cetak jumlah elemen di list
List<string> semuaData1 = data1.GetSemuaData();
List<string> semuaData2 = data2.GetSemuaData();

Console.WriteLine("\nJumlah elemen di data1: " + semuaData1.Count);
Console.WriteLine("Jumlah elemen di data2: " + semuaData2.Count);