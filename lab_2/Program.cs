using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            //Byte хранит целое число от 0 до 255 и занимает 1 байт
            //SByte хранит целое число от -128 до 127 и занимает 1 байт
            //Int16 хранит целое число от -32768 до 32767 и занимает 2 байта
            Int32 intType = 49;  //хранит целое число от -2147483648 до 2147483647 и занимает 4 байта
            Int64 longType = 795487658784986866L; //хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт
            //UInt16 ранит целое число от 0 до 65535 и занимает 2 байта
            UInt32 uintType = 7654U;  //хранит целое число от 0 до 4294967295 и занимает 4 байта
            UInt64 ulongType = 879065UL;   //хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт
            Char charType = 'g'; //хранит одиночный символ в кодировке Unicode и занимает 2 байта
            Boolean boolType = true;
            Single FloatType = 0.6F; //хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта
            Double doubleType = 3.9867575;   //хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта
            Decimal decimalType = 60.00000M; //Данный тип данных, в основном, используется в финансовых расчетах. Он имеет разрядность 127 бит, что позволяет ему представлять числа с точностью до 28 десятичных разрядов
            String stringType = "Midnight";
            Object objectType = "this is object";    //может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе

            //5 операций явного приведения
            Byte b = (Byte)intType;
            SByte sb = (SByte)intType;
            int s = (int)charType;
            Int16 i16 = (Int16)FloatType;
            UInt16 uToU = (UInt16)uintType;

            //5 неявных преобразований
            Int64 l = intType;
            float iToF = longType;
            double dToF = FloatType;
            UInt64 u32ToI = uintType;
            int chToI = charType;

            //упаковка/распаковка
            int ii = 1456;
            object oI = ii; //Когда любой значимый тип присваивается к ссылочному типу данных, значение перемещается из области стека в кучу

            int i2 = (int)oI;   //Когда любой ссылочный тип присваивается к значимому типу данных, значение перемещается из области кучи в стек

            //работа с неявно типизированной переменной
            var amount = 3.67;
            Type amountType = amount.GetType();
            Console.WriteLine("Тип amount: {0}", amountType);   //Единственное отличие неявно типизированной переменной от обычной, явно типизированной переменной, — в способе определения ее типа. Как только этот тип будет определен, он закрепляется за переменной до конца ее существования.

            //nullable
            Nullable<int> ni = 45;
            Nullable<Double> nd = null;
            Console.WriteLine(ni.Value);
            Console.WriteLine(ni.HasValue);
            //Console.WriteLine(nd.Value);
            Console.WriteLine(nd.HasValue);

            //задание 2
            //строковые литералы
            String str1 = "Hello ";
            String str2 = "World ";
           if (str1 == str2)
            { 
                Console.WriteLine("строки идентичны"); 
            }
           else
            { 
                Console.WriteLine("строки отличаются"); 
            };
            Console.WriteLine(String.Compare(str1, str2));  //результат - целое число, которое показывает их относительное положение в порядке сортировки
            Console.WriteLine(String.CompareOrdinal(str1, str2));
            Console.WriteLine(str1.CompareTo(str2));

            //три строки
            String str3 = "wonderful";
            String megaStr = str1 + str2 + str3;    //String.Concat()
            Console.WriteLine(megaStr);
            String copyStr = String.Copy(str3);
            Console.WriteLine(copyStr);
            Console.WriteLine(megaStr.Substring(6,8));
            String[] words = megaStr.Split(" ");
            foreach (string word in words)
            Console.WriteLine("слово: {0}",word);
            Console.WriteLine(megaStr.Insert(10, stringType));
            Console.WriteLine(megaStr.Remove(3,11));

            //null strings
            String s0 = "";
            String sNull = null;
            Console.WriteLine(String.Compare(str3, s0));
            Console.WriteLine(String.Compare(str3, sNull));

            //StringBuilder
            StringBuilder sbild = new StringBuilder("SHINEDOWN", 30);
            Console.WriteLine(sbild);
            sbild.Remove(3, 5);
            sbild.Append(new char[] { 'E' });
            sbild.Insert(0, "SUN");
            Console.WriteLine(sbild);

           /* //задание 3
            //двумерный массив
            const int k = 3;
            int[,] ms = new int[k,k] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            int count = 0;
            foreach(var x in ms)
            {
                Console.Write("\t" + x);
                count++;
                if(count == k)
                {
                    Console.Write("\n");
                    count = 0;
                }
            };

            //одномерный массив строк
            String[] collection = new string[] { "first", "second", "third", "forth" };
            Console.WriteLine("Массив из 4 элементов:");
            foreach (String element in collection)
            {
                Console.WriteLine(element);
            };
            Console.WriteLine("длинна массива:{0}",collection.Length);
            Console.WriteLine("Введите номер элемента, который хотите заменить");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите новое значение");
            String newValue = Console.ReadLine();
            collection[key] = newValue;
            foreach (String element in collection)////////
            {
                Console.WriteLine(element);
            };

            //ступенчатый массив
            int[][] a = new int[3][];
            a[0] = new int[2];
            a[1] = new int[3];
            a[2] = new int[4];
            for( int i=0; i<a.Length;i++)
            {
                for( int j=0;j<a[i].Length;j++)
                {
                    Console.WriteLine("enter number");
                    a[i][j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            for(int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j]+"\t");
                }
                Console.Write("\n");
            }

            //неявнотипизированная переменная
            var unstr = "this is string";
            var arr = new[] { "this", "is", "array" };*/

            //задание 4
            (int, string, char, string, ulong) tuple = (23, "moon", 'g', "light", 13L);
            (int, string, char, string, ulong) tuple1 = (23, "moon", 'g', "light", 13L);
            Console.WriteLine("Кортеж1: {0}",tuple);
            Console.WriteLine("элемент1 {0}", tuple.Item1);
            Console.WriteLine("элемент3: {0}", tuple.Item3);
            Console.WriteLine("элемент4: {0}", tuple.Item4);

            //распаковка кортежа
           // var(number, word, sign, word2, longnum) = CreateCortage(tuple);

            //сравнение
            Console.WriteLine(tuple.CompareTo(tuple1));

            //задание 5
            int[] num = { 5, 45, 234, 76, 15, 87, 45, 765 };
            string line = "google";
            Console.WriteLine(tupleBack(num, line));

        }
        public  tupleBack(int[] num,string line)
        {
            int max = num[0];
            int min = num[0];
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if(num[i]>max)
                {
                    max = num[i];
                };
                if (num[i] < min)
                {
                    min = num[i];
                };
                sum += num[i];
            }
            char sign = Convert.ToChar(line.Substring(0, 1));
            (int, int, int, char) resultTuple = (max, min, sum, sign);
            return resultTuple;
        }
    }
}
