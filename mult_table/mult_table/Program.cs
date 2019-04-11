//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {

    	static void Head_table(int num_line=9)
        {
    		string head="\n\t1 |",head_line="\t";
            for (int x=2;x <=num_line;x++)
            { head=head+"\t"+x;
             head_line=head_line + "---------";
            }
            head=head+"\n"+head_line+"\n";
    		Console.WriteLine(head);
    	}
    	
        static void Mult_table(int par1=9,int par2=9)
        {
             
            for (int x=1;x <=par1;x++)
            {
                Console.Write("\t{0} |",x);
                
            	for (int y=1;y<=par2;y++)
            		{
                	int mult=x*y; Console.Write("{0}\t",mult);     
            		}
                Console.WriteLine("\n");
            }
        }
        
              public static void Main(string[] args)
        {
            //Your code goes here
                        
               /*
 string head= "\n \t1 |\t2\t3\t4\t5\t6\t7\t8\t9\n----------------------------------------------------------------------------------";
            Console.WriteLine( head);
          */
         
            Head_table();
            Mult_table();
                       
  			Console.WriteLine("----------------------------------------------\n");
  			Console.Write("Введите количество строк матрицы ");
			int X=Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите количество столбцов матрицы ");
           	int  Y=Convert.ToInt32(Console.ReadLine());
			Console.Write("\n");
			 
         	Head_table(X);
            Mult_table(X,Y);
            
            Console.ReadKey();
        }
    }
}