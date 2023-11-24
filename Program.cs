namespace ifandelse;

class Program
{
    static void Main(string[] args)
    {
        /*
        (Exerscise #1)
        Console.WriteLine("Write a number between 1 to 10: ");
        var promt = Console.ReadLine();
        var promtToInt = Convert.ToInt32(promt);
        int promtTonumber = 0;
        var checkPrompt = int.TryParse(promt, out promtTonumber);
        if (checkPrompt == true)
        {

            if (promtToInt > 0 && promtToInt <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
        */
        /*
          (Exerscise #1)
        Console.WriteLine("Write a number between 1 to 10: ");
        var promt2 = Console.ReadLine();
        var promtToInt2 = Convert.ToInt32(promt2);
         Console.WriteLine("Write another number between 1 to 10: ");
        var promt3 = Console.ReadLine();
        var promtToInt3 = Convert.ToInt32(promt3);
        var sum= promtToInt3 + promtToInt2; 
            if (double.IsInteger(sum))
            {
               Console.WriteLine("The sum is: " + sum); 
            }
            else
            {
                Console.WriteLine("Sorry try again");
            }*/

            /*   (Exerscise #3)
        Console.WriteLine("Using this format{0000 x 0000} write the height and width of an image: ");
        var promt4 = Console.ReadLine();
        if (promt4 == "1920 x 1080")
        {
            Console.WriteLine("this is a landscape image");
        }
        else if (promt4 == "1080 x 1920")
        {
              Console.WriteLine("this is a Portrait image");
        }
        else
        {
            Console.WriteLine("Image size not found");
        }
*/          //   (Exerscise #4)
         Console.WriteLine("What is the speed limit of the lane?: ");
        var  promt1 = Console.ReadLine();
         var speedlimit = Convert.ToInt32(promt1);
        Console.WriteLine("What is the speed of the car?: ");
        var  promt2 = Console.ReadLine();
         var carspeed = Convert.ToInt32(promt2);
        var demeritPoints = carspeed - speedlimit;
        if (carspeed < speedlimit)
        {
            Console.WriteLine("Ok");
        }
        else if (carspeed > demeritPoints)
        {
              Console.WriteLine("You above the speed limit by: " + demeritPoints);
        }
        else if (demeritPoints >= 12)
        {
              Console.WriteLine("License Suspended");
        }
        // line 75 not working check the question on udemy
    }
}

