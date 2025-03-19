using static System.Console;

namespace ConsoleApp0319
{
    internal class Program
    {
        //enum DialogResult { YES=0, NO, CANEL=100, CONFIRM,OK}
        
            static void Main(string[] args)
            {
            #region P86
            /* Console.WriteLine((int)DialogResult.YES);
             Console.WriteLine((int)DialogResult.NO);
             Console.WriteLine((int)DialogResult.CANEL);
             Console.WriteLine((int)DialogResult.CONFIRM);
             Console.WriteLine((int)DialogResult.OK);


             DialogResult result = DialogResult.YES;
             Console.WriteLine(result == DialogResult.YES);
             Console.WriteLine(result == DialogResult.NO);
             Console.WriteLine(result == DialogResult.CANEL);
             Console.WriteLine(result == DialogResult.CONFIRM);
             Console.WriteLine(result == DialogResult.OK);*/
            #endregion

            #region P90
            /*int? a = null;

            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);

            a = 3;

            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);
            Console.WriteLine(a.Value);*/
            #endregion

            #region P93
            /*  object a = 20;
              Console.WriteLine("Type : {0}, Value : {1}", a.GetType(), a);

              object b = 3.1414213;
              Console.WriteLine("Type : {0}, Value : {1}", b.GetType(), b);

              var c = "Hello, World!";
              Console.WriteLine("Type : {0}, Value : {1}", c.GetType(), c);

              var d = new int[] { 10, 20, 30 };
              Console.Write("Type : {0}, Value : ", d.GetType());
              foreach (var e in d)
                  Console.Write("{0} ", e);

              Console.WriteLine();*/
            #endregion

            #region P95

            /*   System.Int32 a = 123;
                   int b = 456;

               Console.WriteLine("a type:{0}, value:{1}", a.GetType().ToString(), a);
               Console.WriteLine("b type:{0}, value:{1}", b.GetType().ToString(), b);

               System.String c = "abc";
                   String d = "def";

               Console.WriteLine("c type:{0}, value:{1}", c.GetType().ToString(), c);
               Console.WriteLine("d type:{0}, value:{1}", d.GetType().ToString(), d);*/

            #endregion

            string greeting = "Good Morning";

            WriteLine(greeting);
            WriteLine();

        }
        
    }
}
