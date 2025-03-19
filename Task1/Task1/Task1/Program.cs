using Task1.ClassException;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string workWithUser;
            bool flagCycle = true;
            int chose;
            Exception[] exceptions = new Exception[5] { new MyFirstException(), new MySecondException("Не правильный выбор :)"), 
                new ArrayTypeMismatchException(), new DriveNotFoundException(), new NullReferenceException()}; 

            do
            {
                Console.Write("Введите номер метода (1-5) или введите 6 для выхода из программы:");
                workWithUser = Console.ReadLine();

                try
                {
                    if (int.TryParse(workWithUser, out chose))
                    {
                        switch (chose)
                        {
                            case 1:
                                throw exceptions[0];
                            case 2:
                                throw exceptions[1];
                            case 3:
                                throw exceptions[2];
                            case 4:
                                throw exceptions[3];
                            case 5:
                                throw exceptions[4];
                            case 6:
                                flagCycle = false;
                                break;
                            default:
                                Console.WriteLine("Введите число от 1 до 6");
                                break;
                        }

                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            while (flagCycle);

        }
    }
}
