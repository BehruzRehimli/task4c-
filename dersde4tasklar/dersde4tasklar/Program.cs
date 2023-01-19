using System;
using System.Threading.Tasks;

namespace dersde4tasklar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool a = false;
            //string input;
            //do
            //{
            //    Console.WriteLine("salam");
            //    input = Console.ReadLine();
            //    for (int i = 0; i < input.Length; i++)
            //    {
            //        if (input[i]=='@')
            //        {
            //            a= true;
            //            break;
            //        }
            //    }
            //} while (a==false);
            string[] input = {"Baki","quba", "world","Sheki" };
            Console.WriteLine(DeleteFirstSpaceInString("  Hello World"));
        }
        static bool SearchName(string [] arr,string name)
        {
            foreach (var item in arr)
            {
                if (item==name)
                {
                    return true;
                }
            }
            return false;
        }
        static bool SearchDigitIntArray(int[]arr,int n)
        {
            foreach (var item in arr)
            {
                if (item==n)
                {
                    return true;
                }
            }
            return false;
        }
        static bool SearchSameDigitInTwoArray(int[]arr,int [] n) 
        {
            foreach (var item in n)
            {
                if(SearchDigitIntArray(arr, item))
                    return true;
            }
            return false;
        
        }
        static bool ThisCharIsDigit(char c) 
        {
            string digit = "0123456789";
            foreach (var item in digit) 
            {
                if (item==c)
                {
                    return true;
                }
            }
            return false;
        }
        static bool FindInStringDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (ThisCharIsDigit(str[i])==true)
                {
                    return true;
                }
            }
            return false;
        }
        static int FindCharIndex (string str,char c) 
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==c)
                {
                    return i;
                }
            }
            return -1;
        }
        static string CutStringInIndex(string str,int num)
        {
            string result = "";
            for (int i = 0; i < num; i++)
            {
                result+= str[i];
            }
            return result;
        }
        static string FindWord(string str)
        //Task 1- Verilmiş string dəyərindəki ilk sözü tapan metod (ilk söz ilk boşluğa qədərki ifadədir)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==' ')
                {
                    break;
                }
                else
                {
                    result+= str[i];
                }
            }
            return result;

        }
        //Task 2 - Verilmiş string dəyərindəki sözlərin sayını tapan metod (boşluqlarla ayrılan bütün ifadələri söz kimi nəzərə alın)
        static int FindWordsInString(string str)
        {
            int counter = 1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==' ')
                {
                    counter++;
                }
            }
            return counter;
        }
        // Task 3 - Verilmiş ədədlər siyahısından içində yalnız müsbət ədədlər qalan yeni bir array düzəldən metod. Misalçün verilmiş arraydə {4, -3, 10, -24}  dəyərləridirsə methoddan geriyə {4, 10} dəyərli array qayıdır.
        static int[] PostivInt(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    counter ++;
                }
            }

            int[] result= new int[counter];
            int count = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>0)
                {
                    result[count] = arr[i];
                    count++;
                    
                }
            }
            return result;
        }
        //Task 4 - Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod
        static int HowMuchStrWithDigit(string []str)
        {
            int counter = 0;
            foreach (var item in str)
            {
                foreach (var item2 in item)
                {
                    if (item2>47&&item2<58)
                    {
                        counter++;
                        break;
                    }
                }
            }
            return counter;
        }
        //Task 5- Verilmiş yazıdaki ilk boşluq olmayan index-i qaytaran metod. Misalçun "  Salam" yazısında S ilk boşluq olmayan char-dır.
        static char FirstCharNotSpace(string str)
        {
            foreach (var item in str)
            {
                if (item!=' ')
                {
                    return item;
                }
            }
            return '-';
        }
        //Task 6- Verilmiş yazını sol tərəfində boşluq olmayan vəziyyətdə qaytaran metod
        static string DeleteFirstSpaceInString(string str)
        {
            string result = "";
            int firstindex=0;
            for (int j = 0; j <str.Length; j++)
            {
                if (str[j]!=' ')
                {
                    firstindex = j;
                    break;
                }
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]!=' '|| i>=firstindex)
                {
                    result+= str[i];
                }

            }
            return result;
        }
    }
}
