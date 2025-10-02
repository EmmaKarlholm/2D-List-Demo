// Just a little demo of how two-dimensional lists work in C#.
//
// The code runs, but you can learn what you want from it simply by
// reading the code since all screen output is given in comments! =)
//

using System.Globalization;

namespace _2D_List_Demo
{

    internal class Program
    {
        static void Main(string[] args)
        {

            // Set up the two-dimensional list.
            List<List<string>> listObject = new List<List<string>>();

            listObject.Add(new List<string> { "Alice", "Yellow", "Kiwi" });
            listObject.Add(new List<string> { "Bob", "Red", "Pear" });
            listObject.Add(new List<string> { "Tom", "Green", "Banana" });
            listObject.Add(new List<string> { "Dick", "Blue", "Apple" });
            listObject.Add(new List<string> { "Harry", "Orange", "Orange" });

            // This creates the following grid in memory:
            //
            //                                  x
            //                             
            //                   _______/_______|______\________
            //                  |  Alice  |  Yellow  |   Kiwi   | 0
            //                / |   Bob   |   Red    |   Pear   | 1
            //              y - |   Tom   |  Green   |  Banana  | 2
            //                \ |   Dick  |   Blue   |   Apple  | 3
            //                  |  Harry  |  Orange  |  Orange  | 4
            //                   ‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾
            //                       0          1          2
            //
            // You can access the grid using
            // listObject[y][x]
            //
            // If it helps, you can also read it as
            // listObjects[row][column]


            Console.WriteLine(listObject[0][0]);
            // Gives the output:
            //   Alice

            Console.WriteLine(listObject[0][2]);
            // Gives the output:
            //   Kiwi

            Console.WriteLine(listObject[2][1]);
            // Gives the output:
            //   Green


            // Display the full two-dimensional list.
            for (int y = 0; y < listObject.Count; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    Console.Write($"{listObject[y][x]} ");
                }
                Console.Write("\n"); // New line output every time a row finishes
            }
            // Gives the output:
            //   Alice Yellow Kiwi
            //   Bob Red Pear
            //   Tom Green Banana
            //   Dick Blue Apple
            //   Harry Orange Orange

        }
    }
}