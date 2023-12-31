﻿namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("what's your name?");
            // string input = Console.ReadLine();
            // Console.WriteLine($"your name is {input}");

            // var
            // string name = "Shadow"; 
            // string breed = "Golden Retriever";
            // int age = 5;
            // double weight = 65.22;
            // bool spayed = true;
            // Console.WriteLine(name);
            // Console.WriteLine(breed);
            // Console.WriteLine(age);
            // Console.WriteLine(weight);
            // Console.WriteLine(spayed);

            // convert string to int, note: readline values selalu string
            // Console.Write("Enter your favorite number!: ");      
            // Attempt 1: use implicit conversion
            // int faveNumber = Console.ReadLine();
            // Attempt 2: use explicit conversion
            // int faveNumber = (int)Console.ReadLine();
            // Attempt 3: use Convert method
            // int faveNumber = Convert.ToInt32(Console.ReadLine());

            // tipe data numerik
            // Number of pizza shops
            // int pizzaShops = 4332;
            // // Number of employees
            // int totalEmployees = 86928;
            // // Revenue
            // double revenue = 390819.28;
            // // Log the values to the console:
            // Console.WriteLine(pizzaShops);
            // Console.WriteLine(totalEmployees);
            // Console.WriteLine(revenue);

            // Your Age
            // int userAge = 17;
            // // Length of years on Jupiter (in Earth years -> revolusi ke matahari)
            // double jupiterYears = 11.86;
            // // Age on Jupiter
            // double jupiterAge = userAge/jupiterYears;
            // // Time to Jupiter
            // double journeyToJupiter = 6.142466;
            // // New Age on Earth
            // double newEarthAge = userAge + journeyToJupiter;
            // // New Age on Jupiter
            // double newJupiterAge = newEarthAge/jupiterYears;
            // // Log calculations to console
            // Console.WriteLine(jupiterAge);
            // Console.WriteLine(newEarthAge);
            // Console.WriteLine(newJupiterAge);

            // 2 steps forward 1 step back
            // declare steps variable
            // int steps = 0;
            // // Two steps forward 
            // steps += 2;
            // // One step back 
            // steps -= 1;
            // // Print result to the console
            // Console.WriteLine(steps);

            // modulus
            // Number of students
            // int students = 18;
            // // Number of students in a group
            // int groupSize = 5;
            // // Does groupSize go evenly into students?
            // Console.WriteLine(students % groupSize);

            // Create variables 
            // int numberOne = 12932;
            // int numberTwo = -2828472;
            // // Use built-in methods and save to variable 
            // double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));
            // // Use built-in methods and save to variable 
            // double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));
            // // Print the lowest number
            // Console.WriteLine(Math.Min(numberTwoSqrt, numberOneSqrt));
            // double numberOne = 6.5;
            // double numberTwo = 4;
            // // Raise numberOne to the numberTwo power
            // Console.WriteLine(Math.Pow(numberOne, numberTwo));
            // // Round numberOne up
            // Console.WriteLine(Math.Ceiling(numberOne));
            // // Find the larger number between numberOne and numberTwo
            // Console.WriteLine(Math.Max(numberOne, numberTwo));

            // esc chars
            /* 
            // First string variable
            string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife.";
            // Second string variable
            string firstSpeech = "\"My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\"";

            // Print variable and newline
            Console.WriteLine(firstSentence);
            Console.WriteLine("\n");
            Console.WriteLine(firstSpeech);
            */

            /*  
            string concat ======
            string beginning = "Once upon a time";
            string middle = "the kid climbed a tree";
            string end = "Everyone lived happily ever after";

            // Concatenate the string and the variables
            string story = beginning + ", " + middle + ". " + end + ".";

            // Print the story to the console 
            Console.WriteLine(story);
            */

            /*  
            string interpolation
            string beginning = "Once upon a time,";
            string middle = "The kid climbed a tree";
            string end = "Everyone lived happily ever after.";

            // Interpolate the string and the variables
            string story = $"{beginning} it was a beautiful day. {middle} and the birds flew through the sky. {end}";

            // Print the story to the console 
            Console.WriteLine(story);
            */

            /* string methods
            Create password
            string password = "a92301j2add";
            Get password length
            int passwordLength = password.Length;
            Check if password uses symbol
            int passwordCheck = password.IndexOf("!");
            Print results
            Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check."); */

            /* // dna strand
            string startStrand = "ATGCGATGAGCTTAC";
            // find location of "tga"
            int tga = startStrand.IndexOf("TGA");
            // start point and stop point variables
            int startPoint = 0;
            int length = tga + 3;
            // define final strand
            string dna = startStrand.Substring(startPoint, length);
            Console.WriteLine(dna);
            // DNA mutation search
            Console.WriteLine(dna[3]); */

            /*  // Script line
             string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";
             // Get camera directions
             int charPosition = script.IndexOf("Close");
             int length = "Close on".Length;
             string cameraDirections = script.Substring(charPosition, length);
             // Get scene description
             charPosition = script.IndexOf("a portrait");
             string sceneDescription = script.Substring(charPosition);
             // Make camera directions uppercase
             cameraDirections = cameraDirections.ToUpper();
             // Make scene description lowercase
             sceneDescription = sceneDescription.ToLower();
             // Print results
             Console.WriteLine($"{cameraDirections} {sceneDescription}"); */

            // capture output
            // string designer = "Anders Hejlsberg";
            // int indexOfSpace = designer.IndexOf(" ");
            // string secondName = designer.Substring(indexOfSpace);
            // Console.WriteLine(secondName);

            // call method param
            // VisitPlanets(2);
            // VisitPlanets(3);
            // VisitPlanets(4);

            // static void VisitPlanets(int numberOfPlanets)
            // {
            //     Console.WriteLine($"You visited {numberOfPlanets} new planets...");
            // }

            // VisitPlanets();
            // VisitPlanets(numberOfPlanets: 2);
            // VisitPlanets(numberOfPlanets: 2, name: "sekar");

            // static void VisitPlanets(
            //   string adjective = "brave",
            //   string name = "Cosmonaut",
            //   int numberOfPlanets = 0,
            //   double gForce = 4.2)
            // {
            //     Console.WriteLine($"Welcome back, {adjective} {name}.");
            //     Console.WriteLine($"You visited {numberOfPlanets} new planets...");
            //     Console.WriteLine($"...while experiencing a g-force of {gForce} g!");

            // return
            //     Console.WriteLine(DecoratePlanet("Mars"));
            //     Console.WriteLine("Is Pluto really a dwarf...?");
            //     Console.WriteLine(IsPlutoADwarf());
            //     Console.WriteLine("Then how many planets are there in the galaxy...?");
            //     Console.WriteLine(CountThePlanets());
            // }
            // static string DecoratePlanet(string planet)
            // {
            //     return $"*..*..* Welcome to {planet} *..*..*";
            // }
            // static bool IsPlutoADwarf()
            // {
            //     bool answer = true;
            //     return answer;
            // }
            // static string CountThePlanets()
            // {
            //     return "8 planets, usually";
            // }

            // out
            //     string ageAsString = "102";
            //     string nameAsString = "Granny";
            //     int ageAsInt;
            //     bool outcome;
            //     outcome = Int32.TryParse(ageAsString, out ageAsInt);
            //     Console.WriteLine(outcome);
            //     Console.WriteLine(ageAsInt);
            //     int nameAsInt;
            //     bool outcome2;
            //     outcome2 = Int32.TryParse(nameAsString, out nameAsInt);
            //     Console.WriteLine(outcome2);
            //     Console.WriteLine(nameAsInt);

            //     string statement = "GARRRR";
            //     bool marker;
            //     string murmur = Whisper(statement, out marker);
            //     Console.WriteLine(murmur);
            // }

            // static string Whisper(string phrase, out bool wasWhisperCalled)
            // {
            //     wasWhisperCalled = true;
            //     return phrase.ToLower();
            // }

            // c# methods
            // expression-bodied defintions
            //     Welcome("Earth");
            //     double days = 500;
            //     double rotations = DaysToRotations(days);
            //     Console.WriteLine($"In {days} days, the Earth has rotated {rotations} time(s).");
            // }
            // static double DaysToRotations(double days) => days / 365;
            // static void Welcome(string planet) =>
            //   Console.WriteLine($"Welcome to {planet}!");

            // methods as arguments
            // Array to be used as first argument
            // string[] adjectives = { "rocky", "mountainous", "cosmic", "extraterrestrial" };
            // Call Array.Find() and 
            // Pass in the array and method as arguments
            // string firstLongAdjective = Array.Find(adjectives, IsLong());
            // Console.WriteLine($"The first long word is: {firstLongAdjective}.");

            // lambda expressions

            //     string[] spaceRocks = { "meteoroid", "meteor", "meteorite" };
            //     bool makesContact = Array.Exists(spaceRocks, (string s) => s == "meteorite");
            //     if (makesContact)
            //     {
            //         Console.WriteLine("At least one space rock has reached the Earth's surface!");
            //     }
            // } 
            // shorter
            // bool makesContact = Array.Exists(spaceRocks, s => s == "meteorite"); bcs s only return string so remove the type

            // define array 2 ways
            // string[] summerStrut;
            // summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
            // int[] ratings = { 10, 9, 8, 7, 6, 5, 4, 3 };
            // Console.WriteLine($"Lagu {summerStrut[0]} dikasih rating {ratings[0]}");
            // // editing arrays
            // summerStrut[7] = "Science";
            // ratings[7] = 10;
            // // find and sort
            // int threeRating = Array.IndexOf(ratings, 3);
            // Console.WriteLine($"Song number {threeRating + 1} is rated three stars.");
            // string findName = Array.Find(summerStrut, song => song.Length > 10);
            // Console.WriteLine($"The first song that has more than 10 characters in the title is {findName}.");
            // Array.Sort(summerStrut);
            // string firstSong = summerStrut[0];
            // string lastSong = summerStrut[7];
            // Console.WriteLine($"The first song in the playlist is now {firstSong}.");
            // Console.WriteLine($"The last song in the playlist is now {lastSong}.");
            // // another methods
            // string[] summerStrutCopy = new string[7];
            // Array.Copy(summerStrut, summerStrutCopy, 7);
            // Array.Reverse(summerStrutCopy);
            // Array.Clear(ratings, 0, ratings.Length);

            // for loop
            //     for (int i = 1; i < 17; i++)
            //     {
            //         CreateTemplate(i);
            //     }

            // }
            // static void CreateTemplate(int week)
            // {
            //     Console.WriteLine($"Week {week}");
            //     Console.WriteLine("Announcements: \n \n \n ");
            //     Console.WriteLine("Report Backs: \n \n \n");
            //     Console.WriteLine("Discussion Items: \n \n \n");
            // }

            // foreach loop
            //     string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };
            //     foreach (string item in todo)
            //     {
            //         CreateTodoItem(item);
            //     }
            // }
            // static void CreateTodoItem(string item)
            // {
            //     Console.WriteLine($"[] {item}");
            // }

            // jump statements
            /* bool buttonClick = false;
            int counter = 0;
            do
            {
                Console.WriteLine("BLARRRRR");
                counter++;
                
                if (counter == 3)
                {
                break;
                }
            } while(!buttonClick);
            } */


            // class and objects
            // Forest f = new Forest(0);
            // Forest f = new()
            // {
            //     name = "pelem",
            //     biome = "kantil",
            //     trees = 1,
            //     age = 10
            // };
            // properties
            // Console.WriteLine(f.name);
            // f.Name = "Congo";
            // f.Trees = 0;
            // f.age = 0;
            // f.biome = "Tropical";

            // Console.WriteLine(f.Name);

            Forest.PrintTreeFacts();
        }
    }
}
