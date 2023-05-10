 namespace ConsoleApp1
 {
     internal class Bai3
     {
         static void Main(string[] args)
         {
             Console.WriteLine("Image 1: ");
             for(int i  = 0; i <= 4; i++)
             {
                 for (int j = 0; j <= i; j++)
                 {
                     Console.Write("* ");
                 }
                 Console.WriteLine();
             }
             Console.WriteLine("Image 2: ");
             for (int i = 0; i <= 4; i++)
             {
                 for (int j = 0; j < 5-i; j++)
                 {
                     Console.Write("* ");
                 }
                 Console.WriteLine() ;
             }
             Console.WriteLine("Image 3: ");
             for(int i = 0;i < 5; i++)
             {
                 for(int j = 0;j < 5; j++)
                 {
                     if(j < 5 - i - 1)
                     {
                         Console.Write("  ");
                     }
                     else
                     {
                         Console.Write("* ");
                     }
                    
                 }
                 Console.WriteLine();
             }
             Console.WriteLine("Image 4: ");
             for (int i = 0; i < 5; i++)
             {
                 for (int j = 0; j < 5; j++)
                 {
                     if (j >= i)
                     {
                         Console.Write("* ");
                     }
                     else
                     {
                         Console.Write("  ");
                     }

                 }
                 Console.WriteLine();
             }
             Console.WriteLine("Image 5: ");
             for (int i = 0; i < 5; i++)
             {
                 for (int j = 0; j < 10; j++)
                 {
                     if (Math.Abs(5-j-1)<=i)
                     {
                         Console.Write("* ");
                     }
                     else
                     {
                         Console.Write("  ");
                     }

                 }
                 Console.WriteLine();
             }
             Console.WriteLine("Image 6: ");
             for (int i = 0; i < 5; i++)
             {
                 for (int j = 0; j < 10; j++)
                 {
                     if (j>i -1 && j< 10 - i- 1)
                     {
                         Console.Write("* ");
                     }
                     else
                     {
                         Console.Write("  ");
                     }

                 }
                 Console.WriteLine();
             }
             Console.WriteLine("Image 7: ");
             for (int i = 0; i < 10-1; i++)
             {
                 for (int j = 0; j < 10; j++)
                 {
                     if (Math.Abs(5-j-1) >Math.Abs(5-i-1) && Math.Abs(5-j) < 10 - Math.Abs(5 - i-1))
                     {
                         Console.Write("  ");
                     }
                     else
                     {
                         Console.Write("* ");
                     }

                 }
                 Console.WriteLine();
             }
             Console.WriteLine("Image 8: ");
             for (int i = 0; i < 7; i++)
             {
                 for (int j = 0; j < 12; j++)
                 {
                     if (i == 0 || i == 6 || j == 0 || j == 11 )
                     {
                         Console.Write("* ");
                     }
                     else
                     {
                         Console.Write("  ");
                     }

                 }
                 Console.WriteLine();
             }
         }
     }
 }
