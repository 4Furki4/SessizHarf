using System;
namespace SessizHarf
{
    public class Algoritma
    {
        public bool[] YanYanaIkiUnsuzKontrolu(string[] arr)
        {
            bool[] trueFalse= new bool[arr.Length];
            string unluler="aeoöuüıi";
            int[] yanYanaIkiSessiz=new int[arr.Length];
            int sıra=0;
            foreach (var item in arr)
            {
                int counter=0;
                foreach (var harf in item)
                {
                    
                    if (harf.ToString().Contains(unluler))
                    {
                        counter=0;
                    }
                    else
                    {
                        counter++;
                        if (counter==2)
                        {
                            yanYanaIkiSessiz[sıra]++;
                        }
                    }
                    sıra++;
                    
                }
                
            }
            for (int i = 0; i < trueFalse.Length; i++)
            {
                if (yanYanaIkiSessiz[i]>=1)
                {
                    trueFalse[i]=true;
                }else
                {
                    trueFalse[i]=false;
                }
            }
            return trueFalse;
        }
        
    } 
}//Counteer