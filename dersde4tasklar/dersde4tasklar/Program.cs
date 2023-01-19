using System;
using System.Threading.Tasks;

namespace dersde4tasklar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lahiye ishe salindiqda consolda Email taxil etmeyimizi istesin
            //ve her sefer @ isharesi daxil etmedikde yeniden daxil etmeyimizi istesin
            bool a = false;
            string input;
            do
            {
                Console.WriteLine("Maili daxil edin");
                input = Console.ReadLine();
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == '@')
                    {
                        a = true;
                        break;
                    }
                }
            } while (a == false);
            string[] input2 = {"Bak1i","quba", "wo3rld","S2heki" };
            Console.WriteLine(DeleteFirstSpacesInStringTest("  Hello world"));
        }
        #region Dersdeki Tasklar
        //Verilmish adlar siyahisinda verilmish adin olub olmadigini tapan metod
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
        //Verilmish ededler siyahisinda verilmish ededin olub olmadigini tapan metod
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
        // verilmish 2 ededler siyahisinda eyni ededlerin olubolmadigini tapan method
        static bool SearchSameDigitInTwoArray(int[]arr,int [] n) 
        {
            foreach (var item in n)
            {
                if(SearchDigitIntArray(arr, item))
                    return true;
            }
            return false;
        
        }
        //verilmish char reqemdirmi tapan method
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
        //Verilmish yazida reqem varmi tapan method
        static bool FindDigitInString(string str)
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
        //Verilmish stringde verilmis charin indexini tapan metod
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
        //Verilmish yazini verilmish indexe qeder kesib qaytaran metod
        static string CutStringInIndex(string str,int num)
        {
            string result = "";
            for (int i = 0; i < num; i++)
            {
                result+= str[i];
            }
            return result;
        }

        #endregion
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
                if (FindDigitInString(item))
                {
                    counter++;
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
        static string DeleteFirstSpacesInString(string str)
        {
            string result = "";
 
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ' || i >=FirstCharIndexNotSpace(str))
                {
                    result += str[i];
                }

            }
            return result;
        }
        static int FirstCharIndexNotSpace(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    return i;

                }
            }
            return 0;
        }
        static string DeleteFirstSpacesInStringTest(string str)
        {
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ' || (i !=0 && str[i-1]!=' '))
                {
                    result += str[i];
                }

            }
            return result;
        }
    }
}
