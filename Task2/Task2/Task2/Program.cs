using Task2.ClassException;
using Task2.Sort;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[5] {"Liza", "Vlad", "Hope", "Hikita", "Slava" };
            bool flagCycle = true;
            string workWithUser;
            int chose;

            SortArray sortArray = new SortArray();

            do
            {
                Console.WriteLine("Действия");
                Console.WriteLine("1) сортировка А-Я");
                Console.WriteLine("2) сортировка Я-А");
                Console.WriteLine("3) выйти");
                Console.Write("Выберити действие:");
                workWithUser = Console.ReadLine();

                try
                {
                    if(int.TryParse(workWithUser, out chose))
                    {
                        switch (chose)
                        {
                            case 1:
                                sortArray.SortUp(name);
                                PrintArray(name);
                                break;
                            case 2:
                                sortArray.SortDown(name);
                                PrintArray(name);
                                break;
                            case 3:
                                flagCycle = false;
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        throw new IntParseException("Введите число.");
                    }

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            while (flagCycle);
            
        }

        private static void PrintArray(string[] arraySting)
        {
            foreach (string str in arraySting)
            {
                Console.WriteLine(str);
            }

        }

    }
}
