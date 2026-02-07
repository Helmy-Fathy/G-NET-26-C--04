using System.ComponentModel;
using System.Net.Sockets;
using System.Text;
using static System.Formats.Asn1.AsnWriter;

namespace G_NET_26_C__04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            //Question 01 : A junior developer wrote this code to build a comma-separated list of 5,000 product IDs:
            //string productList = "";
            //for (int i = 1; i <= 5000; i++)
            //{
            //    productList += "PROD-" + i + ",";
            //}
            /*Tasks:
               (a) Explain why this code is inefficient. Reference what happens in memory.
                => Because String is Immutable. it creates new object each loop, Creates 5,000 string objects wich cause Heavy GC pressure
               (b) Rewrite this code using StringBuilder to be more efficient.
               (c) Add timing code (using Stopwatch) to both versions and report the time difference.
                =>  String  : 33ms   ,   StringBuilder  : 0ms
            */
            //String
            //var watch1 = System.Diagnostics.Stopwatch.StartNew();
            //string productList = "";
            //for (int i = 0; i < 5000; i++)
            //    productList += "PROD-" + i + ",";
            //watch1.Stop();

            // StringBuilder
            //var watch2 = System.Diagnostics.Stopwatch.StartNew();
            //StringBuilder sbResult = new StringBuilder();
            //for (int i = 0; i < 5000; i++)
            //    sbResult.Append("PROD-" + i + ",");
            //string sbFinal = sbResult.ToString();
            //watch2.Stop();

            //Console.WriteLine($"5,000 concatenations:");
            //Console.WriteLine($"  String (+)      : {watch1.ElapsedMilliseconds}ms");
            //Console.WriteLine($"  StringBuilder   : {watch2.ElapsedMilliseconds}ms");

            #endregion

            #region Q2
            //Question 02: Ticket Pricing System : Write a program for a cinema ticket pricing system
            /*
              Tasks:
                (a) Implement using if-else if-else statements
                (b) The program should ask for: age, day of week (1-7, where 6=Fri, 7=Sat), and whether they have a student ID (yes/no)
                (c) Display the final price with a breakdown of how it was calculated
             */
            //Console.WriteLine("Please inter your age");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please inter day of week, where 6=Fri, 7=Sat");
            //int day = int.Parse(Console.ReadLine());
            //Console.WriteLine("Do you have a student ID? (yes/no)");
            //string isStudent = Console.ReadLine();

            //double basePrice = 0;
            //double surcharge = 0;
            //double discount = 0;
            //string ageCategory = "";

            //if (age < 5)
            //{
            //    basePrice = 0;
            //    ageCategory = " (Under 5)";
            //}
            //else if (age >= 5 && age <= 12)
            //{
            //    basePrice = 30;
            //    ageCategory = " (5-12)";
            //}
            //else if (age >= 13 && age <= 59)
            //{
            //    basePrice = 50;
            //    ageCategory = " (13-59)";
            //}
            //else
            //{
            //    basePrice = 25;
            //    ageCategory = " (60+)";
            //}

            //double priceAfterSurcharge = basePrice;
            //if (basePrice > 0 && (day == 6 || day == 7))
            //{
            //    priceAfterSurcharge += 10;
            //}

            //double finalPrice = priceAfterSurcharge;
            //if (isStudent == "yes" && basePrice > 0)
            //{
            //    discount = priceAfterSurcharge * 0.20;
            //    finalPrice -= discount;
            //}

            //Console.WriteLine($"Age Category: {ageCategory}");
            //Console.WriteLine($"Base Price: {basePrice} LE");

            //if (day == 6 || day == 7)
            //    Console.WriteLine($"Weekend Surcharge: +10 LE");

            //if (discount > 0)
            //    Console.WriteLine($"Student Discount (20%): -{discount} LE");

            //Console.WriteLine($"Final Ticket Price: {finalPrice} LE");

            #endregion

            #region Q3
            /*
                Question 03: Convert the following if-else chain to:
                (a) A traditional switch statement
                (b) A switch expression 
            */
            //string fileExtension = ".pdf";
            //string fileType;

            //if (fileExtension == ".pdf")
            //    fileType = "PDF Document";
            //else if (fileExtension == ".docx" || fileExtension == ".doc")
            //    fileType = "Word Document";
            //else if (fileExtension == ".xlsx" || fileExtension == ".xls")
            //    fileType = "Excel Spreadsheet";
            //else if (fileExtension == ".jpg" || fileExtension == ".png" || fileExtension == ".gif")
            //    fileType = "Image File";
            //else
            //    fileType = "Unknown File Type";


            // (a) A traditional switch statement
            //switch (fileExtension) 
            //{
            //    case ".pdf":
            //        fileType = "PDF Document";
            //        break;
            //    case ".docx":
            //        fileType = "Word Document";
            //        break;
            //    case ".xlsx":
            //        fileType = "Excel Spreadsheet";
            //        break;
            //    case ".jpg":
            //        fileType = "Image File";
            //        break;
            //    default:
            //        fileType = "Unknown File Type";
            //        break;

            //}

            // (b) A switch expression 
            //fileType = fileExtension switch
            //{
            //    ".pdf" => "PDF Document",
            //    ".docx" => "Word Document",
            //    ".xlsx" => "Excel Spreadsheet",
            //    ".jpg" => "Image File",
            //    _ => "Unknown File Type"
            //};

            #endregion

            #region Q4
            /*
             Question 04 : Ternary Operator 
             Rewrite the following using only ternary operators (no if statements):
            */
            //int temperature = 35;
            //string weatherAdvice;

            //if (temperature < 0)
            //    weatherAdvice = "Freezing! Stay indoors.";
            //else if (temperature < 15)
            //    weatherAdvice = "Cold. Wear a jacket.";
            //else if (temperature < 25)
            //    weatherAdvice = "Pleasant weather.";
            //else if (temperature < 35)
            //    weatherAdvice = "Warm. Stay hydrated.";
            //else
            //    weatherAdvice = "Hot! Avoid sun exposure.";

            //// Ternary Operator 
            //weatherAdvice = temperature < 0 ? "Freezing! Stay indoors." : temperature < 15 ? "Cold. Wear a jacket." : temperature < 25 ? "Pleasant weather." : temperature < 35 ? "Warm. Stay hydrated." : "Hot! Avoid sun exposure.";

            // Is the ternary version more readable? When would you choose one over the other?
            // the ternary version is Not more readable , i would choose ternary version in cases wich have mostly 3 paths to Avoid Nested Ternary
            #endregion

            #region Q5
            /*
               Question 05 : Input Validation with Loops 
                Create a password validation program with these requirements:
                Password Rules:
                ●	Minimum 8 characters
                ●	At least one uppercase letter
                ●	At least one digit
                ●	No spaces allowed
                Program Behavior:
                ●	Use a do-while loop to keep asking until a valid password is entered
                ●	After each invalid attempt, tell the user which specific rules they violated
                ●	Limit attempts to 5. After 5 failed attempts, display "Account locked" and exit
                ●	On success, display "Password accepted!"
             */
            //string password;
            //bool isValid;
            //int attempts = 0;
            //const int maxAttempts = 5;

            //do
            //{
            //    attempts++;
            //    Console.WriteLine($"Enter a password (Attempt {attempts}/{maxAttempts}): ");
            //    password = Console.ReadLine();

            //    bool hasMinLength = password.Length >= 8;
            //    bool hasUpper = false;
            //    bool hasDigit = false;
            //    bool hasNoSpace = !password.Contains(" ");

            //    foreach (char c in password)
            //    {
            //        if (char.IsUpper(c))
            //            hasUpper = true;
            //        if (char.IsDigit(c))
            //            hasDigit = true;
            //    }

            //    isValid = hasMinLength && hasUpper && hasDigit && hasNoSpace;

            //    if (isValid)
            //    {
            //        Console.WriteLine("Password accepted!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid password. Please fix the following:");
            //        if (!hasMinLength)
            //            Console.WriteLine("Minimum 8 characters");
            //        if (!hasUpper)
            //            Console.WriteLine("At least one uppercase letter");
            //        if (!hasDigit)
            //            Console.WriteLine("At least one digit");
            //        if (!hasNoSpace)
            //            Console.WriteLine("No spaces allowed");
            //    }

            //    if (attempts >= maxAttempts)
            //    {
            //        Console.WriteLine("Account locked. Too many failed attempts.");
            //        break;
            //    }

            //} while (!isValid);

            #endregion
        }
    }
}

