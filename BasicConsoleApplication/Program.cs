using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            //The condition of the loop
            bool condition = true;

            //Possible user defined reasons
            string[] theReasonWhy = { "HUNGRY", "SAD", "FEELINGS", "PEOPLE" };
            
            //This loop is artificial as it only runs once.
            while(condition == true)
            {
                Console.WriteLine("Hello. How are you doing? (good/bad)");
                string input = Console.ReadLine();
                //change the input to upper case
                input = input.ToUpper();
                //Determine what to say to the user
                if (input == "GOOD")
                {
                    Console.WriteLine("Sweet. I'm glad you're doing good.");
                }
                else
                {
                    //The program is limited..inform user its not his/her psychiatrist
                    Console.WriteLine("Well...I'm actually just a console application not a psychiatrist.");
                    Console.WriteLine("But I will ask why anyway.. Why? ");
                    //Tell user the valid options
                    Console.WriteLine("-Valid Options:");
                    //list options using a for loop iterating through theReasonWhy array
                    for(int i = 0;  i < theReasonWhy.Length;  i++)
                    {
                        Console.WriteLine("--" + theReasonWhy[i]);
                    }
                    //Ask user why the user is sad
                    Console.WriteLine("Tell me the reason why you're doing bad: ");
                    string userDefinedReason = Console.ReadLine();
                    userDefinedReason = userDefinedReason.ToUpper();
                    for (int i = 0; i < theReasonWhy.Length; i++)
                    {
                        if(userDefinedReason == theReasonWhy[i])
                        {
                            Console.WriteLine("Well there are steps to not feeling that way.");
                        }

                        if(i == theReasonWhy.Length - 1 && userDefinedReason != theReasonWhy[i])
                        {
                            Console.WriteLine("Like I said I'm just a simple console application.");
                        }
                    }

                }
                //ask user for the arguments for the user defined class
                Console.WriteLine("How about we fabricate a class together...");
                Console.WriteLine("Tell me two words.");
                Console.WriteLine("First Word:");
                string x = Console.ReadLine();

                Console.WriteLine("Second Word:");
                string y = Console.ReadLine();
                //create a computer object from the heyKidImAComputer class
                heyKidImAComputer computer = new heyKidImAComputer(x, y);
                //Call the method getMe from the computer
                Console.WriteLine(computer.getMe());
                //Keep console open
                Console.ReadLine();
                //Make the loop artificial
                condition = false;

            }


        }

        public class heyKidImAComputer
        {
            //stop all the downloading...help computer...

            string returnedComputedWord;
            string firstWord;
            string secondWord;
            //setter
            public heyKidImAComputer(string x, string y)
            {
                firstWord = x + "BEEPBOOP";
                secondWord = y + "BOPBEEPZEP";
                returnedComputedWord = firstWord + secondWord;
            }
            //getter
            public string getMe()
            {
                return returnedComputedWord;
            }

        }

    }
}
