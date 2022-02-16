using System;
namespace SessizHarf
{
    public class Algoritma
    {
        public bool[] YanYanaIkiUnsuzKontrolu(string[] arr)
        {
            bool[] trueFalse= new bool[arr.Length]; // sıraya bağlı true veya false'ları depolayacağım dizi. 
            string unluler="aeoöuüıi"; //Ünsüzleri tek tek yazmak yerine ünlüleri yazmak ve ünlüler üzerinden yan yana ünsüzleri bulmayı tercih ettim. 
            int sıra=0; // kelime sırasını tutan değişken.
            foreach (var item in arr) // her kelime için bu foreach'i
            {
                int counter=0; // yan yana bulunan ünsüzlerin sayısını tutacağım int değişken. 
                foreach (var harf in item)// her harf için bu foreach'i kullanıyorum.
                {
                    
                    if (unluler.Contains(harf)) // Yan yana ünsüzleri bulmak için mevcut harfin ünlü olup olmadığını kontrol ettim.
                    {
                        counter=0; //harf ünlüyse sıfırlıyorum ki ünlüler birikip algoritma hatalı olmasın.
                    }
                    else
                    {
                        counter++; // ünsüzse artırıyorum
                        if (counter==2) // ve art arda iki ünsüz varsa buradan true yapıyorum
                        {
                            trueFalse[sıra]=true;
                            break; // bu kelimeyle işimiz bittiği için bu döngüyü kırıyorum.
                        }
                    }
                }
                sıra++; // diğer kelimeye geçiyoruz.
                
            }
            return trueFalse;
        }
        
    } 
}//Counteer