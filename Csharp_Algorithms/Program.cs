

//1.İstənilən iki ədəd arasındakı tək ədədlərin sayın tapın
//2.5 ilə 500 arasında kök altısı olan ədədləri ekrana yazdırın Məs:(9, 16, 25......)
//3.Verilmiş "Azerbaycan" sözündə hər hərfdən neçə dənə olduğunu tapın


namespace Csharp_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*-------------------1--------------------------
             int numm = Convert.ToInt32(Console.ReadLine());
            for (int num = Convert.ToInt32(Console.ReadLine()); num < numm; num++)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine(num);
                }
            }
                        
            -------------------------------------------------*/









            /*------------------2--------------------------
            int numm = 500;
            
            for (int num = 5; num < numm; num++)
            {
                for (int i = 1;i<numm ; i++)
                {
                    if (i*i==num)
                    {
                        Console.WriteLine(num);
                    }
                }
            }
            -------------------------------------------------*/













            //-----------3-----------------------


            string ad = "azerbaycan";
           char a = 'a';
           char b = 'b';
           char c = 'c';
           char e = 'e';
           char r='r';
           char n = 'n';
           char z = 'z';
           int count = 0;
           int count1 = 0;
           int count2 = 0;
           int count3 = 0;
           int count4 = 0;
           int count5 = 0;
           int count6 = 0;

           for (int i = 0; i < ad.Length; i++)
           {
               if (a == ad[i])
               {
                   count++;
               }
           }
           Console.WriteLine($"a:{count}");

           for (int i = 0; i < ad.Length; i++)
           {
               if (b == ad[i])
               {
                   count1++;
               }
           }
           Console.WriteLine($"b:{count1}");

           for (int i = 0; i < ad.Length; i++)
           {
               if (c == ad[i])
               {
                   count2++;
               }
           }
           Console.WriteLine($"c:{count2}");

           for (int i = 0; i < ad.Length; i++)
           {
               if (e == ad[i])
               {
                   count3++;
               }
           }
           Console.WriteLine($"e:{ count3}");

           for (int i = 0; i < ad.Length; i++)
           {
               if (r == ad[i])
               {
                   count4++;
               }
           }
           Console.WriteLine($"r:{count4}");
           for (int i = 0; i < ad.Length; i++)
           {
               if (n == ad[i])
               {
                   count5++;
               }
           }
           Console.WriteLine($"n:{count5}");

           for (int i = 0; i < ad.Length; i++)
           {
               if (z == ad[i])
               {
                   count6++;
               }
           }
           Console.WriteLine($"z:{count6}");



           






            /*
             
----------* BUNU INTERNETDEN TAPDIM AMMA BIZ BUNU KECMEMISHIQ YEQIN*-----------------
             
            string str = "azerbaycan";
            while (str.Length > 0)
            {
                Console.Write(str[0] + " = ");
                int cal = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[0] == str[i])
                    {
                        cal++;
                    }
                }
                Console.WriteLine(cal);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
        */
        

        }
    }
}