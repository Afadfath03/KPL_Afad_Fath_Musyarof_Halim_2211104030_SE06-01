using System.Text;

namespace MatematikaLibraries
{
    public class Class1
    {
        public int FPB(int input1, int input2)
        {
            while (input2 != 0)
            {
                int temp = input2;
                input2 = input1 % input2;
                input1 = temp;
            }
            return input1;
        }

        public int KPK(int input1, int input2)
        {
            return (input1 * input2) / FPB(input1, input2);
        }

        public string Turunan(int[] persamaan)
        {
            StringBuilder result = new StringBuilder();
            int derajat = persamaan.Length - 1;

            for (int i = 0; i < persamaan.Length - 1; i++)
            {
                int koef = persamaan[i];
                int pangkat = derajat - i;
                int hasil = koef * pangkat;

                if (hasil == 0) continue;

                if (result.Length > 0 && hasil > 0)
                    result.Append(" + ");
                else if (hasil < 0)
                    result.Append(" - ");

                int absHasil = Math.Abs(hasil);
                result.Append(absHasil);
                if (pangkat - 1 > 1)
                    result.Append($"x{pangkat - 1}");
                else if (pangkat - 1 == 1)
                    result.Append("x");
            }

            return result.ToString();
        }

        public string Integral(int[] persamaan)
        {
            StringBuilder result = new StringBuilder();
            int derajat = persamaan.Length - 1;

            for (int i = 0; i < persamaan.Length; i++)
            {
                int koef = persamaan[i];
                int pangkatBaru = derajat - i + 1;

                if (result.Length > 0 && koef > 0)
                    result.Append(" + ");
                else if (koef < 0)
                    result.Append(" - ");

                int absKoef = Math.Abs(koef);
                if (absKoef != 1 || pangkatBaru == 0)
                    result.Append($"{absKoef}");

                if (pangkatBaru > 0)
                {
                    result.Append("x");
                    if (pangkatBaru > 1)
                        result.Append($"{pangkatBaru}");
                }
            }

            result.Append(" + C");
            return result.ToString();
        }
    }
}
