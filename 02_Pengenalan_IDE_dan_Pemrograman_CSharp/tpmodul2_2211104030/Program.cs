Console.Write("Masukkan satu huruf: ");
string huruf = Console.ReadLine().ToLower();

if(huruf == "a" | huruf == "i" | huruf == "u" | huruf == "e" | huruf == "o") {
    Console.WriteLine("Huruf " + huruf + " adalah huruf vokal");
} else {
    Console.WriteLine("Huruf " + huruf + " adalah huruf konsonan");
}

//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();

//int[] genap = { 2, 4, 6, 8, 10 };

//for(int i = 0; i < genap.Length; i++) {
//    Console.WriteLine("Angka Genap " + (i+1) + ": " + genap[i]);
//}
