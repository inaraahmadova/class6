namespace class6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(text.ToCaptalize());
            //string text = "s";
            //Console.WriteLine("a",ToCaptalize());
            //Console.WriteLine(5.Add(10));
            //IsEven(null);
            var a= Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1: Console.WriteLine(Weekdays.Monday); break;
                case 2: Console.WriteLine(Weekdays.Tuesday); break;
                case 3:
                    Console.WriteLine(Weekdays.Wednesday); break;
                case 4:
                    Console.WriteLine(Weekdays.Thursday); break;
                    case 5:
                    Console.WriteLine(Weekdays.Friday); break;
                    case 6:
                    Console.WriteLine(Weekdays.Saturday); break;
                    case 7:
                    Console.WriteLine(Weekdays.Sunday); break;
                    foreach (var item in Enum.GetValues(typeof(Weekdays)))
                    {
                        Console.WriteLine(item.ToString());
                    }
            }
        }
        //static void IsEven (int? num)
        //{
        //    string text = "sAlAm";
        //    Console.WriteLine(text.ToUpper());
        //    if (num==null) Console.WriteLine("num must be non nullable value");
        //    else
        //    {
        //        Console.WriteLine(num%2==0);
        //    }
        //}
    }
}
