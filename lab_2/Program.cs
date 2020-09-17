﻿using System;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Byte byteType = 17;  //хранит целое число от 0 до 255 и занимает 1 байт
            System.SByte sbyteType = -29;    //хранит целое число от -128 до 127 и занимает 1 байт
            System.Int16 shortType = -3856; //хранит целое число от -32768 до 32767 и занимает 2 байта
            System.Int32 intType = 49;  //хранит целое число от -2147483648 до 2147483647 и занимает 4 байта
            System.Int64 longType = 795487658784986866L; //хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт
            System.UInt16 ushortType = 9676;    //ранит целое число от 0 до 65535 и занимает 2 байта
            System.UInt32 unitType = 7654U;  //хранит целое число от 0 до 4294967295 и занимает 4 байта
            System.UInt64 ulongType = 879065UL;   //хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт
            System.Char charType = 'g'; //хранит одиночный символ в кодировке Unicode и занимает 2 байта
            System.Boolean boolType = true;
            System.Single FloatType = 0.6F; //хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта
            System.Double doubleType = 3.9867575;   //хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта
            System.Decimal decimalType = 60.00000M; //Данный тип данных, в основном, используется в финансовых расчетах. Он имеет разрядность 127 бит, что позволяет ему представлять числа с точностью до 28 десятичных разрядов
            System.String stringType = "Midnight";
            System.Object objectType = "this is object";    //может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе

            //5 операций явного приведения
            Byte b = (Byte)intType;
            SByte sb = (SByte)intType;
            Char ch = (Char)intType;
            float f = (float)doubleType;
            int s = (int)charType;

            //5 неявных преобразований
            Int64 l = intType;
        }
    }
}
