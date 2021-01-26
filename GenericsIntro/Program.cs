using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("ahmet");
            isimler.Add("ali");
            isimler.Add("hakan");
            Console.WriteLine(isimler.Lenght);

        }
    }
}
