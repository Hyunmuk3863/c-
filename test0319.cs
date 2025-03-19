using System.Security;

namespace test0319
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region P1
            /*  Console.WriteLine("Hello, World!");

              int sum = 0;

             for (int i=1; i<=100; i++ )
              {
                  sum = sum + i;
              }
              Console.WriteLine("sum {0}", sum);*/
            #endregion

            #region P2

            /*      for (int i = 2; i < 10; i++)
                  {
                      for (int j = 1; j < 10; j++)
                      {
                          Console.WriteLine("{0} x {1} = {2}", i, j, i* j);
                      }
                      Console.WriteLine();*/
            #endregion
            #region P3
            while (true)
            {
                Console.WriteLine("단수를 입력 하세요");
                int.TryParse(Console.ReadLine(), out int i);


                if (i == 0)
                {
                    Console.WriteLine("종료 합니다");
                    break;
                }

                else if (i >= 1 && i <= 9)
                {

                    for (int j = 1; j < 10; j++)
                    {
                        Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
                    }
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine("잘못 된 입력입니다");
                }
            }
            #endregion


            #region P4
            /*      while (true)
                  {
                      Console.WriteLine("단수를 입력 하세요");
                      int.TryParse(Console.ReadLine(), out int i);


                      if (i < 1 || i > 9)
                      {
                          Console.WriteLine("종료 합니다");
                          break;
                      }


                      Console.WriteLine($"\n{i}단 출력");
                      for (int j = 1; j < 10; j++)
                      {

                          Console.WriteLine($"{i} x {j} = {i * j}");
                      }
                      Console.WriteLine();

                  }*/

            #endregion



        }
    }
}
