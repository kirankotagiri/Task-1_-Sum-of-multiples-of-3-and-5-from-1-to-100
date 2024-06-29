using System;


namespace Task_1__Sum_of_multiples_of_3_and_5_from_1_to_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Pseudocode:

              *Initialize sum to 0.
              *Loop i from 1 to 100:
              *If i is a multiple of 3 or 5:
              *Add i to sum.
              *Print sum. */

            // we start by declaring a variable `sum` of type `int` to store the sum of multiples of 3 and 5
            int sum = 0;



                    // we use a `for` loop to iterate through numbers from 1 to 100 (inclusive)

                   for (int i = 1; i <= 100; i++)
            {
                

                        //  Inside the loop, we use a conditional statement (`if` statement) to check if the current number is a multiple of 3 or 5.
                       //  We use the module operator (`%`) to check if the remainder of division by 3 or 5 is 0.
                

                      if (i % 3 == 0 || i % 5 == 0)


                      //If the number is a multiple of 3 or 5, we add it to the `sum` variable using the `+=` operator.

                      sum += i;

            }
            


            // Display the sum

            Console.WriteLine("sum of all multiples of 3 and 5 from 1 to 100 is: " + sum);

            Console.ReadLine();
        }
        
       

    }
}
