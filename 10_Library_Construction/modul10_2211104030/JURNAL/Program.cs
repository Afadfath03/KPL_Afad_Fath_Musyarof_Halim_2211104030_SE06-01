using MatematikaLibraries;

Class1 mtk = new Class1();

int FPB = mtk.FPB(10, 15);
int KPK = mtk.KPK(10, 8);
string Tur = mtk.Turunan([1, 4, -12, 9]);
string Integral = mtk.Integral(new int[] { 2, 4, -6, 8 });

Console.WriteLine("FPB(10, 15) = " + FPB);
Console.WriteLine("KPK(10, 8) = " + KPK);
Console.WriteLine("Turunan({1, 4, -12, 9}) = " + Tur);
Console.WriteLine("Integral({4, 6, -12, 9}) = " +  Integral);