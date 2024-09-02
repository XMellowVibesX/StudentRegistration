using System;

namespace StudentRegistration
{
    class frmStudentRegistration
    {
        /*
             I tried adding the file reading features and what not,
            but it turned into spaghetti code with too much complexity
            I ended up wasting so much time on debugging :,)
            that is the life of a programmer i suppose
            so i just had to wipe it all clean and submit something simple... just... long
            as long as i passed something, so i dont get a 0
        */
        
        static void theWholeThing()
        {
            Console.WriteLine("==================================================\n" +
                "   WELCOME! ARE YOU READY TO BECOME AN STIer?\n" +
                "==================================================");
            Console.WriteLine("Please fill out the form below\n");



            // ASKING FOR THE STUDENT'S NAME
            Console.WriteLine("=== FULL NAME ===");
            Console.Write("First name: ");
            string fn = Console.ReadLine();
            Console.Write("Middle name: ");
            string mn = Console.ReadLine();
            Console.Write("Last name: ");
            string ln = Console.ReadLine();



            // ASKING FOR THE STUDENT'S BDAY
            Console.WriteLine("\n=== BIRTHDATE ===");
            Console.Write("Month: ");
            string mo = Console.ReadLine();
            Console.Write("Day: ");
            int dy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Year: ");
            int yr = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("\n" + "=============================="); // DIVIDER



            //                         === PAYMENT METHOD ===
            Console.WriteLine("The tuition is Php32,000. Choose your payment method (type the number): \n" +
                "1. Downpayment\n" +
                "2. Installation\n");
            int userPayChoice = Convert.ToInt32(Console.ReadLine());

            // If the student chooses installation
            if (userPayChoice == 2)
            {
                Console.WriteLine("How would you like to handle the payment?\n" +
                    "1. Per term\n" +
                    "2. Per semester\n" +
                    "3. Other\n");
                int installChoice = Convert.ToInt32(Console.ReadLine());

                if (installChoice == 3)
                {
                    Console.WriteLine("Please write down your prefered option: ");
                    string installationOther = Console.ReadLine();
                }

            }



            Console.WriteLine("\n" + "==============================");



            //                         === REQUIREMENTS CHECKLIST ===
            Console.WriteLine("Here are the following requirements you must submit to the registrar's office: \n" +
                "- SHS DIPLOMA\n" +
                "- FORM 137\n" +
                "- GOOD MORAL CARD\n" +
                "- PSA\n" +
                "- MEDICAL CERTIFICATE\n");



            Console.WriteLine("\n" + "==============================");



            //                         === PRINTING THE INFORMATION ===
            Console.WriteLine("IS ALL THE INFORMATION BELOW CORRECT?\n");
            Console.WriteLine("Name: " + ln + ", " + fn + " " + mn + "\n" +
                "Date of Birth: " + mo + " " + dy + " " + yr + "\n");

            if (userPayChoice == 1)
            {
                Console.WriteLine("Payment Method: Downpayment");
            }
            else if (userPayChoice == 2) 
            {
                Console.WriteLine("Payment Method: Installation");
            }
            
        }
        static void Main(string[] args)
        {
            theWholeThing();
            Console.WriteLine("\n IS EVERYTHING CORRECT? (y/n)");
            bool willReset = Console.ReadLine() == "y";
            if (willReset) 
            {
                theWholeThing();
            }
            

        }
    }
}