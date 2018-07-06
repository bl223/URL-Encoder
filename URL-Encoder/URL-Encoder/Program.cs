using System;

namespace URLEncoder
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string pName; //For Project name
            string aName; //For Activity name

             bool response = false;//While loop for creating new URL choice
             while (!response)
            {
                Console.WriteLine("*** URL ENCODER ***"); //Title

                Console.WriteLine("Enter a Project Name: ");
                pName = Console.ReadLine();

                Console.WriteLine("Enter a Activity Name: ");
                aName = Console.ReadLine();

                Console.WriteLine("Result URL: ");
                Console.WriteLine("https://companyserver.com/content/" + aName + "%20Lab/files/" + pName + "%3E" + pName + "/" + aName + "%3E" + pName + "Report.pdf");

                Console.WriteLine("Press 'Enter/Return' to Continue...");
                Console.ReadLine();

                //choice to create new URL
                Console.WriteLine("Would you like to create another URL? [y/n]");

                   string option = Console.ReadLine();

                //no choice
                //Yes choice 
                   if (option == "n")
                   {
                       response = true;
                   }
            }

        }
    }
}
