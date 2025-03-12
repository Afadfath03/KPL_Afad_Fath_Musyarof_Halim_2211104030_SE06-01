namespace generic {
    class Program {
        static void Main(string[] args) {
            int[] arr = { 0, 1, 2, 3, 4 };

            List<int> list = new List<int>();
            for(int x = 5; x < 10; x++) {
                list.Add(x);
            }
            ProcessItem(arr);
            ProcessItem(list);
        }

        static void ProcessItem<T>(IList<T> Cell) {
            // IsReadOnly return true for the array and false for the list
            System.Console.WriteLine("IsReadOnly");

            // The following statement cause a run-time exception for the array but not for the list
            // cell.removeat(4)
            foreach(T item in Cell) {
                System.Console.Write(item.ToString() + "");
            }
            System.Console.WriteLine();
        }
    } 
}