public class mcqueen {
    public static void Main(String[] args) {
        bool lateFromSleep;
        string username;
        bool failed;
        List<string> Endings = new List<string>();

        Console.WriteLine("I appologize for what you're about to read.");
        while (true)
        {
            lateFromSleep = false;
            username = "";
            failed = false;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("This is an interactive romance story about Lightning McQueen.");

            Console.Write("Enter your name ");
            username = Console.ReadLine();

            Console.Write("Press [enter] to begin a roadtrip of love, " + username + ". Alternatively, type [endings] to see what endings you've gotten during this session. ");

            switch (Console.ReadLine())
            {
                case "":
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  _______________");
                    Console.WriteLine(" [  (  )   (  )  ]");
                    Console.WriteLine("|.:. LIGHTNING .:.|)<");
                    Console.WriteLine(" *:*           *:*");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine();

                    Console.Write("You wake up to the incessent beeping of your alarm clock. Do you get up [up] or snooze your alarm clock [snooze]? ");

                    switch (Console.ReadLine())
                    {
                        case "up":
                            Console.Write("You get out of bed. Your room is a mess. Do you neaten your room [clean] or drink a Monster Energy(TM) [drink]? ");

                            switch (Console.ReadLine())
                            {
                                case "clean":
                                    Console.Write("You make the responsible decision by tidying up your room. A strong start to your day. ");

                                    if (lateFromSleep == true) { Console.WriteLine("You are, however, going to be a little late for work."); } else { Console.WriteLine(""); }

                                    Console.WriteLine("While you are cleaning, your mind starts to wander.");
                                    Console.WriteLine("You think about a fancy racecar you saw on your way to the store a couple days ago. You've always been something of a car aficionado, but never seen anything like this car.");
                                    Console.WriteLine("You were naturally interested when you saw the car, as you tend to be; but this time felt inexplicably different.");
                                    Console.WriteLine("You were drawn to this car in a way you had never felt toward anything before. You glance back at your alarm clock to see that it's already 11:30!");
                                    Console.Write("Time really got away from you. You were supposed to be at work half an hour ago. Do you go to work [work] or is breakfast more important [eat]? ");

                                    switch (Console.ReadLine())
                                    {
                                        case "work":

                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.Write("''");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("First of all, you go to work, you go to your cubicle, and you put a picture of your family on your cubicle wall.");
                                            Console.WriteLine("Then, you log onto your computer and all the sudden you start thinking of the beautiful car you saw in that parking lot.");
                                            Console.Write("Your boss gives you seven papers and tells you to stop daydreaming and get to work. You snap out of it and think of how you have to work an hour of overtime because you were late.");
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine("''");
                                            Console.ForegroundColor = ConsoleColor.Yellow;

                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine("- What Eli thinks going to work is like.");
                                            Console.ForegroundColor = ConsoleColor.Yellow;

                                            Console.Write("You feel a little tired so you log off from your computer and head home. [press enter] ");
                                            
                                            switch (Console.ReadLine())
                                            {
                                                case "":
                                                    Console.WriteLine("On your way home, you see it. You see the car. You can't hold yourself back. You immediately pull over and approach the vehicle. You observe it from all angles, taking care to pay attention to every detail.");
                                                    Console.WriteLine("The driver window is open wide enough for you to reach the lock. The keys were left on the center console.");
                                                    Console.Write("Do you open the door to take a look inside and risk [crime] or do you wait for the owner to come and compliment them on their car [no crime] OR do you wait for the owner so you can steal their keys and not risk hurting your arm by reaching in [double crime]? ");
                                                    
                                                    switch (Console.ReadLine())
                                                    {
                                                        case "crime":
                                                            Console.WriteLine("You reach into the window and grasp the lock with your grip and you grip it into your grasp and you pull the lock, grasping and grabbing it.");
                                                            Console.WriteLine("You remove your arm from the car and do the same gripping and grabbing and grasping with the door handle. You sit in the driver seat and grab the key.");
                                                            Console.WriteLine("''Hey! What are you doing?!!''");
                                                            Console.WriteLine("You've been caught!!!!!!!!!!!!!!! OMGGGGGGGGGGGGGGGGGGGGGGGG!!!!!!! Where is the owner of the car?????????!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                                                            Console.WriteLine("''Right here bucko,'' says Lightning McQueen. ");
                                                            Console.Write("You are shocked . . . [press enter] ");


                                                            switch (Console.ReadLine())
                                                            {
                                                                case "":
                                                                        Console.WriteLine("but you also feel something you can't quite explain. Almost a warm feeling, in fact, it's a hot feeling. Lightning McQueen has activated his natural defenses. The heating system is turned up to 200°C.");
                                                                        Console.Write("You are at risk of perishing, yet that warm feeling persists and you know it's not just from the sweltering temperature. Do you try to escape and explain yourself [run] or flirt with Lightning McQueen [flirt]? ");
                                                                 
                                                                        switch (Console.ReadLine())
                                                                        {
                                                                            case "run":
                                                                                Console.WriteLine("You attempt to open the door to no avail. You fumble for the lock in terror, it doesn't budge. The heat keeps increasing on it's way to 200°C, now at 100°C. Lightning McQueen says, ''Don't steal cars.''");
                                                                                Console.Write("Do you plead for your life [plead] or try flirting [flirt]? ");

                                                                                switch (Console.ReadLine())
                                                                                {
                                                                                    case "plead":
                                                                                        Console.WriteLine("You beg for your life with the passion of someone who is about to overheat and die. Lightning McQueen takes pity on you. He sees past his pity and instead of saving you, he plays Buddy Holly by Weezer at 100% volume to further torture you.");
                                                                                        Console.WriteLine("Little did Lightning McQueen know, listening to Weezer while in danger activates your stand's ability, Liquidation. Lightning McQueen turns into goo. You have won.");
                                                                                        Endings.Add("Liquidation. ");
                                                                                        break;

                                                                                    case "flirt":
                                                                                        Console.WriteLine("You flirt with the passion of someone who is about to overheat and die. Your passion pays off, Lightning McQueen falls madly in love with you.");
                                                                                        Console.WriteLine("He turns down the heat to a comfortable 2°C to cool you down before begins driving away, the seatbelt wraps around your limp body and buckles into the latch. The next thing you know, you're sitting in a warehouse with Lightning at rest adjacent to you.");
                                                                                        Console.WriteLine("''So you're up,'' says lightning, ''I had to bring you here because I knew you would want to leave.''");
                                                                                        Console.WriteLine("You are shocked, ''Why would you do this?!~'' You have mixed feelings, you know now that you are in love with Lightning, but how can you condone kidnapping (even of someone who was unknowingly a kidnapper too)?");
                                                                                        Console.WriteLine("''BECAUSE I LOVE YOU, " + username.ToUpper() + ",'' exclaims Lightning McQueen, ''and that means I will never let you go.'' You have won.");
                                                                                        Endings.Add("Warehoused. ");
                                                                                        break;

                                                                                    default:
                                                                                        failed = true;
                                                                                        break;
                                                                                }
                                                                                break;

                                                                            case "flirt":
                                                                                Console.WriteLine("You attempt to flirt with Lightning McQueen but you haven't gotten a deep enough connection with him yet.");
                                                                                failed = true;
                                                                                break;

                                                                            default:
                                                                                failed = true;
                                                                                break;
                                                                        }
                                                                    
                                                                    break;
                                                                    
                                                                default:
                                                                    failed = true;
                                                                    break;
                                                            }
                                                            break;

                                                        case "no crime":
                                                            Console.WriteLine("You can't do that.");
                                                            Endings.Add("Law Abiding Citizen. ");
                                                            failed = true;
                                                            break;

                                                        case "double crime":
                                                            Console.WriteLine("You wait forever. The owner never returns. ");
                                                            Endings.Add("Eternal Wait. ");
                                                            failed = true;
                                                            break;

                                                        default:
                                                            failed = true;
                                                            break;
                                                    }
                                                    break;

                                                default:
                                                    failed = true; 
                                                    break;
                                            }
                                            break;

                                        case "eat":
                                            Console.WriteLine("You appear in the kitchen, you are in the kitchen. You food are eaten. You food eat eat. You are eaten. Eating. Eat.");
                                            Console.Write("You're late for being late for work. Do you go to work [work] or is it no longer worth it [stay]? ");

                                            switch (Console.ReadLine())
                                            {
                                                case "work":
                                                    Console.WriteLine("You go to work and when you get there you are immediately notified by your boss that you have been fired.");
                                                    Endings.Add("Fired. ");
                                                    failed = true;
                                                    break;

                                                case "stay":
                                                    Console.WriteLine("You walk back into your bedroom and before you is the ghostly figure of a police car.");
                                                    Console.WriteLine("''You're under arrest.''");
                                                    Endings.Add("Arrested. ");
                                                    failed = true;
                                                    break;

                                                default:
                                                    failed = true;
                                                    break;
                                            }
                                            break;

                                        default:
                                            failed = true;
                                            break;
                                    }

                                    break;

                                case "drink":
                                    Console.WriteLine("You walk over to your minifridge and pull out a can of Monster Energy(TM).");
                                    Console.WriteLine(". . .");
                                    Console.WriteLine("You see the floor start to spin, the design on your rug begins warping and shifting. The colors around you become brighter and more vibrant.");
                                    Console.WriteLine("Time slows down. Time speeds up. You are launched into space as painfully bright and colorful patterns flash before your eyes.");
                                    Console.WriteLine("Ghostly figures appear before you in the shape of racecars. They look down upon you with distain.");
                                    Console.WriteLine("Things begin to calm down and you are back in bed sleeping.");
                                    Console.WriteLine();
                                    Endings.Add("Energized. ");
                                    break;
                                    
                                default:
                                    failed = true;
                                    break;
                            }
                            break;

                        case "snooze":
                            Console.WriteLine("You fall back into deep slumber . . . 10 minutes pass. You are once again awakened.");
                            lateFromSleep = true;
                            goto case "up";

                        default:
                            failed = true;
                            break;
                    }
                    break;

                case "endings":
                    Console.WriteLine(Endings);

                    switch (Console.ReadLine())
                    {
                        case "":

                            break;

                        default:
                            failed = true;
                            break;
                    }
                    break;

                default:
                    failed = true;
                    break;
            }

            // If user gives an invalid answer
            switch (failed)
            {
                case true:
                    Console.WriteLine("You have failed. Lightning McQueen will never love you. (Invalid Answer or Wrong Path)");
                    Console.Write("Press [enter] to try again. ");
                    break;

                default:
                    Console.Write("Press [enter] to play again. ");
                    break;
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}