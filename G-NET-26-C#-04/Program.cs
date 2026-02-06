using System.Text;

namespace G_NET_26_C__04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            //Question 01 : A junior developer wrote this code to build a comma-separated list of 5,000 product IDs:
            //string productList = "";
            //for (int i = 1; i <= 5000; i++)
            //{
            //    productList += "PROD-" + i + ",";
            //}
            /*Tasks:
               (a) Explain why this code is inefficient. Reference what happens in memory.
                => Because String is Immutable. it creates new object each loop, Creates 5,000 string objects wich cause Heavy GC pressure
               (b) Rewrite this code using StringBuilder to be more efficient.
               (c) Add timing code (using Stopwatch) to both versions and report the time difference.
                =>  String  : 33ms   ,   StringBuilder  : 0ms
            */
            //String
            //var watch1 = System.Diagnostics.Stopwatch.StartNew();
            //string productList = "";
            //for (int i = 0; i < 5000; i++)
            //    productList += "PROD-" + i + ",";
            //watch1.Stop();

            // StringBuilder
            //var watch2 = System.Diagnostics.Stopwatch.StartNew();
            //StringBuilder sbResult = new StringBuilder();
            //for (int i = 0; i < 5000; i++)
            //    sbResult.Append("PROD-" + i + ",");
            //string sbFinal = sbResult.ToString();
            //watch2.Stop();

            //Console.WriteLine($"5,000 concatenations:");
            //Console.WriteLine($"  String (+)      : {watch1.ElapsedMilliseconds}ms");
            //Console.WriteLine($"  StringBuilder   : {watch2.ElapsedMilliseconds}ms");

            #endregion

        
        }
    }
}
