using System;
namespace SessizHarf
{
    public class Konsol_Islemleri
    {
        public void IlkMesaj()
        {
            System.Console.Write("Aralarında boşluk olacak şekilde gireceğiniz kelimeler yan yana 2den fazla sesli harf içeriyorsa True, içermiyorsa False yazılacak."+
            "\nLütfen kelimelerinizi giriniz:");
        }
        public string[] KelimeleriAlma()
        {
            string kelimeler= Console.ReadLine();
            return kelimeler.Split(" ");
        }
    }
}