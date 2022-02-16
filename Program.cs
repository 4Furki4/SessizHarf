using System;

namespace SessizHarf
{
    class Program
    {
        static void Main(string[] args)
        {
            Konsol_Islemleri konsol = new Konsol_Islemleri();
            Algoritma algoritma = new Algoritma();
            konsol.IlkMesaj();
            konsol.SonuclariEkranaYazdır(algoritma.YanYanaIkiUnsuzKontrolu(konsol.KelimeleriAlma()));
            
            
        }
    }
}
