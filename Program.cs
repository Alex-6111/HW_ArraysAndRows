
using System.Text;
using static System.Console;

namespace HW_ArraysAndRows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem1();
            Problem2();
            Problem3();
            Problem4();
            Problem5();
            //Problem6();
            Problem7();

            OutputEncoding = Encoding.Unicode;
            ReadKey(true);
        }

        static Random random = new Random();
        public static int EnterInt32(string prompt)
        {
            while (true)
            {
                Write(prompt);
                string str = ReadLine();
                if (int.TryParse(str, out int value))
                {
                    return value;
                }
                WriteLine("\t\tError!!!");
            }
        }

        static void Problem1()
        {
            int n = 5;
            int[] Data = new int[n];
            int i = 0;
            int j = 0;
            int min = 0;
            WriteLine("Enter 5 digits array:");
            while (i < n)
            {
                Data[i] = int.Parse(ReadLine());
                WriteLine();
                i++;
            }
            for (i = 0; i < n; i++)
            {
                WriteLine(Data[i]);
            }
            Array.Sort(Data);
            int max = int.MinValue;
            foreach (int a in Data)
            {
                if (a > max)
                {
                    max = a;

                }
            }
            WriteLine($"Max:{max}");

            int minimum = int.MaxValue;
            foreach (int b in Data)
            {
                if (b < minimum)
                {
                    minimum = b;
                }
            }
            WriteLine($"Min:{minimum}");

            int dabl = 0;

            for (i = 0; i < Data.Length; i++)
                if (Data[i] % 2 == 0)
                {
                    dabl += Data[i];
                }

            WriteLine($"Dabl:{dabl}");


            int summ = 0;
            for (i = 0; i < Data.Length; i++)
                summ += Data[i];
            WriteLine($"Summ:{summ}");

            Random rnd = new Random();
            double[,] arr = new double[3, 4];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    arr[i, j] = rnd.NextDouble() * 100;
                    WriteLine(arr[i, j]);
                }
                WriteLine();
            }

            double maximum = double.MinValue;
            foreach (double c in arr)
            {
                if (c > maximum)
                {
                    maximum = c;

                }
            }
            WriteLine($"Max:{maximum}");

            double minimumm = double.MaxValue;
            foreach (double d in arr)
            {
                if (d < minimumm)
                {
                    minimumm = d;
                }
            }
            WriteLine($"Min:{minimumm}");

            double dabll = 0;

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (arr[i, j] % 2 == 0)

                        dabll += arr[i, j];

                }
            }
            WriteLine($"Dabl:{dabll}");

            double summm = 0;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    summm += arr[i, j];
                }
            }
            WriteLine($"Summ:{summm}");

            double sumstolb = 0;
            if (j % 2 != 0)
            {
                for (i = 0; i < 3; i++)
                {
                    sumstolb += arr[i, j];
                }
            }
            WriteLine($"Sum nechetnih stolb:{sumstolb}");
        }

        static void Problem2()
        {
            WriteLine("Random array 5x5 from -100 to 100");
            int i = 0;
            int j = 0;
            int sum = 0;
            int max = 0;
            int min = 0;
            int imax;
            int imin;
            Random rand = new Random();
            int[,] arr = new int[5, 5];

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                    WriteLine($"{arr[i, j]}\t\t");
                }
                WriteLine();
            }
            imin = arr[0, 0];
            imax = arr[0, 0];
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j]; imax = i + 1; imax = j + 1;
                    }
                }
            }
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (min < arr[i, j])
                    {
                        min = arr[i, j]; imin = i + 1; imin = j + 1;
                    }
                }
                if (imin < imax)
                {
                    for (i = imin + 1; i <= imax; i++)
                    {
                        for (j = imin + 1; j <= imax; j++)
                        {
                            sum = sum + arr[i, j];
                        }
                    }
                }
                else
                {
                    for (i = imax + 1; i <= imin; i++)
                    {
                        for (j = imax + 1; j <= imin; j++)
                        {
                            sum = sum + arr[i, j];
                        }
                    }
                }
                Console.WriteLine($"Sum between min and max:{sum}");

            }
        }

        static void Problem3()
        { 
        const string alfabet = "АБВГДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЪЮЯ";
        Write("Введіть текст: ");
        var text = ReadLine();
        Write("Введіть ключ: ");
        var k = Convert.ToInt32(ReadLine());

        var fullAlfabet = alfabet + alfabet.ToLower();
        var letterQty = fullAlfabet.Length;
        var retVal = "";
        for (int i = 0; i < text.Length; i++)
        {
            var c = text[i];
            var index = fullAlfabet.IndexOf(c);
            if (index < 0)
            {
                retVal += c.ToString();
            }
            else
            {
                var codeIndex = (letterQty + index + k) % letterQty;
                retVal += fullAlfabet[codeIndex];
            }
        } 
        WriteLine("Введене повідомлення : {0}", text);
        WriteLine("Розшифроване повідомлення : {0}", retVal);  
        }

        static void Fill2D(double[,] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    arr[i, j] = random.Next(-50, 100);
            }

        }
        static void Print2D(double[,] arr, int size)
        {
            WriteLine("--------Виведення матриці----------");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Write("{0 , 7}", arr[i, j]);
                }
                WriteLine();
            }
        }

        static void MnoginaNaChislo(double[,] arr, int size, int chislo)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr[i, j] += chislo;
                }
            }
        }

        static void MatrixSum(double[,] arr1, double[,] arr2, int size)
        {
            double[,] arr3 = new double[size, size];

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    arr3[row, col] = arr1[row, col] + arr2[row, col];
                }
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Write("{0 , 7}", arr3[i, j]);
                }
                WriteLine();
            }
        }
        static void MatrixMno(double[,] arr1, double[,] arr2, int size)
        {
            double[,] arr3 = new double[size, size];

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    arr3[row, col] = arr1[row, col] * arr2[row, col];
                }
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Write("{0 , 7}", arr3[i, j]);
                }
                WriteLine();
            }
        }

        static void Problem4()
        {
            int size;


            size = EnterInt32("Введіть розмір масива-> ");

            double[,] arr1 = new double[size, size];
            double[,] arr2 = new double[size, size];

            Fill2D(arr1, size);
            Print2D(arr1, size);
            Fill2D(arr2, size);
            Print2D(arr2, size);

            int n = EnterInt32("\nВведіть число на яке хочете помножити -> ");
            MnoginaNaChislo(arr1, size, n);
            Print2D(arr1, size);

            WriteLine("--------------2 Завдання -----------------");
            MatrixSum(arr1, arr2, size);
            WriteLine("--------------3 Завдання -----------------");
            MatrixMno(arr1, arr2, size);
        }
        
        static void Problem5()
        {
            int k = 2;
            int? Result = null;
            string? ArithmeticExpretion = null;
            Write("Enter arithmetic expression: ");
            ArithmeticExpretion = ReadLine();
            string[] subs = ArithmeticExpretion.Split('-', '+');
            int[] ArrayDigit = new int[ArithmeticExpretion.Length + 10];
            Result = int.Parse(subs[0]);
            for (int i = 1; i < subs.Length; i++)
            {
                ArrayDigit[k] = int.Parse(subs[i]);
                k += 2;
            }
            for (int i = 1; i < ArithmeticExpretion.Length; i++)
            {
                if (ArithmeticExpretion[i] == '+')
                {
                    Result += ArrayDigit[i + 1];
                }
                else if (ArithmeticExpretion[i] == '-')
                {
                    Result -= ArrayDigit[i + 1];
                }
            }
            WriteLine($"Result {Result}");
        }


        static void Problem7()
        {
            int AmountOfLine = 0;
            StringBuilder stringBuilder = new StringBuilder();
            int CounterPeplace = 0;
            Write("Enter word for replace: ");
            string? WordForReplace = ReadLine();
            Write("Enter amount of line: ");
            AmountOfLine = Convert.ToInt32(ReadLine());
            Write("Enter text: ");
            for (int i = 0; i < AmountOfLine; i++)
            {
                string? Temp = ReadLine();
                stringBuilder.AppendLine(Temp);
                if (Temp.Contains(WordForReplace))
                {
                    CounterPeplace++;
                }
            }
            stringBuilder.Replace(WordForReplace, "***");
            Write("New text: ");
            Write(stringBuilder.ToString());
            Write($"change statistics: {CounterPeplace}");

        }
    }

}
