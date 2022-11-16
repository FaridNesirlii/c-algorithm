

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

        //------------------------------------------------- */









            ///------------------2--------------------------]
            /*
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
           // -------------------------------------------------/
            */












            //-----------3-----------------------


            string ad = "azerbaycan";
            char[] chars = ad.ToCharArray();
            for (int i = 0; i < ad.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < chars.Length; j++)
                {
                    if (chars[j] == ad[i])
                    {
                        chars[j] = ' ';
                        count++;    
                    }

                }
                if (count != 0)
                {
                    Console.WriteLine($"{chars[i]}-{count}");
                }
            }











            //----------* BUNU INTERNETDEN TAPDIM AMMA BIZ BUNU KECMEMISHIQ YEQIN*-----------------

            //string str = "azerbaycan";
            //while (str.Length > 0)
            //{
            //    Console.Write(str[0] + " = ");
            //    int cal = 0;
            //    for (int i = 0; i < str.Length; i++)
            //    {
            //        if (str[0] == str[i])
            //        {
            //            cal++;
            //        }
            //    }
            //    Console.WriteLine(cal);
            //    str = str.Replace(str[0].ToString(), string.Empty);
            //}
            // */


        }
    }
}