

namespace ConsoleApp1
{
    internal class Program0317
    {
     
        static void Main(string[] args)
         {
            #region p10
            /* byte a = 240;
             Console.WriteLine($"a={a}");

             byte b = 0b1111_0000;
             Console.WriteLine($"b={b}");

             byte c = 0XF0;
             Console.WriteLine($"c={c}");

             uint d = 0x1234_abcd;
             Console.WriteLine($"d={d}");*/
            #endregion

            #region p11
            //byte a = 128;
            //sbyte b = (sbyte)a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion

            #region p57
            //int a = int.MaxValue;

            //Console.WriteLine(a);

            //a = a + 2;

            //Console.WriteLine(a);
            #endregion

            #region p60
            /*float a = 3.1415_9625_3589_7932_3846f;
            Console.WriteLine(a);

            double b = 3.1415_9265_3589_7932_3846;
            Console.WriteLine(b);*/
            #endregion

            #region p61
            /*float a = 3.1415_9565_3589_7932_3846_2463_3232_79f;
            double b = 3.1415_9565_3589_7932_3846_2463_3232_79;
            decimal c = 3.1415_9565_3589_7932_3846_2463_3232_79m;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);*/
            #endregion
            #region p62
            /*
                        char a = '안';
                        char b = '녕';
                        char c = '하';
                        char d = '세';
                        char e = '요';

                        Console.Write(a);
                        Console.Write(b);
                        Console.Write(c);
                        Console.Write(d);
                        Console.Write(e);
                        Console.WriteLine();
            */
            #endregion

            #region p64

            /*string a = "안녕하세요?";
            string b = "김현묵입니다.";

            Console.WriteLine(a);
            Console.WriteLine(b);
*/
            #endregion

            #region p65
            /*          string multiline = """
                          별 하나에 추억과
                          별 하나에 사랑과
                          별 하나에 쓸쓸함과
                          별 하나에 동경과
                          별 하나에 시와
                          별 하나에 어머니,어머니
                          """;
                      Console.WriteLine(multiline);
            */
            #endregion

            #region p68
            /*bool a = true;
            bool b = false;

            Console.WriteLine(a);
            Console.WriteLine(b);*/
            #endregion

            #region p69
            /* object a = -123;
             object b = -3.141592653589793238462643383279f;
             object c = true;
             object d = "안녕하세요";

             Console.WriteLine(a);
             Console.WriteLine(b);
             Console.WriteLine(c);
             Console.WriteLine(d);*/
            #endregion

            #region p71
            /*  int a = 123;
              object b = a ;
              int c = (int)b + 123;

              Console.WriteLine(a);
              Console.WriteLine(b);
              Console.WriteLine(c);

              double x = 3.1414213;
              object y = x;
              double z = (double)y;
              Console.WriteLine(x);
              Console.WriteLine(y);
              Console.WriteLine(z);*/


            #endregion

            #region p 74

            /*sbyte a = 127;
            Console.WriteLine(a);

            int b = (int)a;
            Console.WriteLine(b);

            int x = 1237;
            Console.WriteLine(x);

            sbyte y = (sbyte)x;
            Console.WriteLine(y);*/


            #endregion
            #region p75
            float a = 69.6875f;
            Console.WriteLine("a : {0}", a);

            double b = (double)a;
            Console.WriteLine("b : {0}", b);
            Console.WriteLine("69.6875 == b : {0}", 69.6875 == b);

            float x = 0.1f;
            Console.WriteLine("x : {0}", x);

            double y = (double)x;
            Console.WriteLine("y:{0}", y);


            #endregion

        }
    }
}
