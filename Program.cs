using System;

namespace SelectionExample {
    class Program {
        static void Main(string[] args) {
            
            Console.Write("Please enter your age: ");
            string age = Console.ReadLine();

            int ageNum = int.Parse(age);

            // Selection - if
            if (ageNum >= 16) {
                // true branch
                Console.WriteLine("Great! You can apply for a learner's permit");

                // read in a result
                Console.Write("Please enter your test result out of 100: ");
                string result = Console.ReadLine();

                int resultNum = int.Parse(result);

                if (resultNum >= 80) {
                    System.Console.WriteLine("Congratulations, you have passed the conditions for a learner's permit");
                } else {
                    System.Console.WriteLine("Sorry, based on your results we cannot trust you on the road");
                }

            } else {
                Console.WriteLine("Sorry!  You are unable to apply for a learner's permit");
                Console.WriteLine("Thank-you, come again later!");

            }

        }
     }
}
