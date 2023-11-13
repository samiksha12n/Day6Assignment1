using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Day6Assignment1JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] StudentsMarks = new int[3][];
            StudentsMarks[0] = new int[3] { 85, 92, 78};
            StudentsMarks[1]=new int[4] {90, 87, 93, 89};
            StudentsMarks[2] = new int[2] { 76, 88};
            Console.WriteLine("Stored Values are: ");
            int res = 0;
            for(int i=0; i< StudentsMarks.Length; i++)
            {
                Console.WriteLine("Marks for Student  "+(i+1));
                for (int j = 0; j < StudentsMarks[i].Length;j++)
               {

                    Console.Write(StudentsMarks[i][j]+" ");
                    
                    
                }
               Console.WriteLine();
            }
            int score = 0;
            
            for(int i=0;i< StudentsMarks.Length;i++)
            {    
              
                Console.WriteLine(" marks of Student"+(i+1));
                for(int j=0;j< StudentsMarks[i].Length; j++)
                {

                   
                    score =score+ StudentsMarks[i][j];
                    Console.WriteLine(StudentsMarks[i][j]);


                }
                Console.WriteLine("Average Marks for Student"+(i+1));
                Console.WriteLine(score);

            }
            Console.ReadKey();

        }
    }
}
