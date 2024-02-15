using System;

class MainClass
{
    public static void Main(string[] args)
    {
        #region Cut ededlerin cemi
        int[] eded = new int[4];

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Eded " + (i + 1) + ": ");
            eded[i] = Convert.ToInt32(Console.ReadLine());
        }

        int cutEdedCemi = 0;

        for (int i = 0; i < eded.Length; i++)
        {
            if (eded[i] % 2 == 0)
            {
                cutEdedCemi += eded[i];
            }
        }
        Console.WriteLine("Cut ededlerin cemi: " + cutEdedCemi);
        #endregion

        #region En boyuk ededi tap
        int[] nums = new int[4];

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine((i+1)+". ededi daxil edin");
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        int maxNumber = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > maxNumber)
            {
                maxNumber = nums[i];
            }
        }
        Console.WriteLine("En boyuk eded: " + maxNumber);
        #endregion

        #region Masin meselesi
        Console.Write("1 km'e yanan benzin: ");
        double yananBenzin = Convert.ToDouble(Console.ReadLine());

        Console.Write("Masinin bakindaki benzin: ");
        double bakdakiBenzin = Convert.ToDouble(Console.ReadLine());

        Console.Write("Getmek istenen mesafe: ");
        double getmekIstenenYol = Convert.ToDouble(Console.ReadLine());

        double gedilecBilecekYol = bakdakiBenzin / yananBenzin;

        if (getmekIstenenYol < gedilecBilecekYol)
        {
            Console.WriteLine("Masin bu mesafeni gede biler");
        }
        else
        {
            Console.WriteLine("Masin bu mesafeni gede bilmez");
        }
        #endregion

        #region Tek ededlerin sayi
        int[] ededler = new int[3];


        for (int i = 0; i < 3; i++)
        {
            Console.Write("Eded " + (i + 1) + ": ");
            ededler[i] = Convert.ToInt32(Console.ReadLine());
        }

        int tekEded = 0;

        for (int i = 0; i < ededler.Length; i++)
        {
            if (ededler[i] % 2 != 0)
            {
                tekEded++;
            }
        }

        Console.WriteLine("Tek ededlerin sayi: " + tekEded);
        #endregion
        //DEYISIKLIK EDILDI
    }
}
