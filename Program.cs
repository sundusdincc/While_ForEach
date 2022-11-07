internal class Program
{
    private static void Main(string[] args)
    {
        //Traversing an array of gender using foreach loop
        char[] gender = { 'm', 'f', 'm', 'm', 'm', 'f', 'f', 'm', 'm', 'f' };
        int male = 0, female = 0;
        foreach (char g in gender)
        {
            if (g == 'm')
                male++;
            else if (g == 'f')
                female++;
        }
        Console.WriteLine("Number of male = {0}", male);
        Console.WriteLine("Number of female = {0}", female);

        //foreach loop with List (Collection)
        var numbers = new List<int>() { 5, -8, 3, 14, 9, 17, 0, 4 };
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine("Sum = {0}", sum);
        
        string[] isimler = {"Ahmet CANSEVER","Emirhan SOYLU","Elif SÜTÇÜ",
                                "Hakan ALTIN","Sema ÇALIŞKAN"};
            foreach(string eleman in isimler)
            {
                Console.WriteLine(eleman);
            }
            



            //20 elemanlı bir diziye 1-100 arası rasgele değer atarak bu diziyi Foreach döngüsü kullanarak yazdırma
            int[] dizi = new int[20];
            Random rnd = new Random();
            for(int i=0;i<dizi.Length;i++)
            {
                dizi[i] = rnd.Next(1,100);
            }
            int kucuk = dizi[0];
            int buyuk = dizi[0];
 
            foreach (int value in dizi)
            {
                Console.WriteLine(value);
                if (value < kucuk)
                {
                    kucuk = value;
                }
                if (value > buyuk)
                {
                    buyuk = value;
                }
            }
            Console.WriteLine("En büyük değer : {0}", buyuk);
            Console.WriteLine("En küçük değer : {0}", kucuk);
            Console.ReadKey();
    }
}