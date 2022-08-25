using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Branch first = new Branch(0);
            first.CreateChild(1);
            first.CreateChild(1);
            Branch first_child = first.branches[0];
            Branch second_child = first.branches[1];
            first_child.CreateChild(2);
            second_child.CreateChild(2);
            second_child.CreateChild(2);
            second_child.CreateChild(2);

            Branch second_child_first = second_child.branches[0];
            Branch second_child_second = second_child.branches[1];
            second_child_first.CreateChild(3);
            second_child_second.CreateChild(3);
            second_child_second.CreateChild(3);
            //second_child_second.CreateChild(3);

            Branch second_child_second_first = second_child_second.branches[0];
            second_child_second_first.CreateChild(4);
            second_child_second_first.CreateChild(4);
            second_child_second_first.CreateChild(4);

            Branch second_child_second_first_first = second_child_second_first.branches[1];
            second_child_second_first_first.CreateChild(5);
            second_child_second_first_first.CreateChild(5);

            Console.WriteLine(first.depth.ToString());
            Console.ReadLine();
        }
    }
}
