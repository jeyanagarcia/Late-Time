using System;

namespace LateHours
{
    class Program
    {
        public static String id = "", pass = "";
        public static TimeSpan timeIn = new TimeSpan(0, 0, 0);
        static void Main(string[] args)
        {
            String employeeId = "";
            String employeePass = "";
            TimeSpan checking = new TimeSpan(0, 0, 0);
            TimeSpan timeOut = new TimeSpan(0, 0, 0);
            TimeSpan gracePeriod = new TimeSpan(8, 30, 0);
            TimeSpan totalHours = new TimeSpan(0, 0, 0);
            TimeSpan regularHoursStart = new TimeSpan(8, 0, 0);
            TimeSpan regularHoursEnd = new TimeSpan(17, 0, 0);
            TimeSpan lateIn = new TimeSpan(0, 0, 0);
            TimeSpan earlyOut = new TimeSpan(0, 0, 0);
            TimeSpan totalLateHours = new TimeSpan(0, 0, 0);

            Console.WriteLine("Welcome to Employee Time Keeping System");
            Console.WriteLine($"Today's Date:  {DateTime.Today.ToShortDateString()}");
            Console.WriteLine("Press 1: Time-In");
            Console.WriteLine("Press 2: Time-Out");
            Console.WriteLine("Enter the number: ");
            String response = Console.ReadLine();

            switch (response){
                    case "1":
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Please Log-in");

                    Console.Write("Enter your Employee ID: ");
                    id = Console.ReadLine();

                    Console.Write("Enter your password: ");
                    pass = Console.ReadLine();

                    timeIn = new TimeSpan(8, 30, 0);

                    Console.WriteLine($"Time In Successfully: {timeIn} ");
                    Console.WriteLine("\n \n \n");
                    Main(args);
                    break;

                    case "2":
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Please Log-in");

                    Console.Write("Enter your Employee ID: ");
                    employeeId = Console.ReadLine();

                    Console.Write("Enter your password: ");
                    employeePass = Console.ReadLine();

                    if (employeeId.Equals(id))
                    {
                        if (employeePass.Equals(pass))
                        {
                            timeOut = new TimeSpan(17, 30, 0);

                            Console.WriteLine($"Your log-out time is recorded: {timeOut}");
                            TimeSpan lunchBreakDuration = new TimeSpan(1, 0, 0);
                            totalHours = (timeOut - timeIn) - lunchBreakDuration;

                            if (timeIn >= gracePeriod)
                            {
                                totalLateHours = (gracePeriod - regularHoursStart) + (gracePeriod - timeIn);
                                Console.WriteLine($"Hi employee {employeeId}");
                                Console.WriteLine($"Your total late hours is: {totalLateHours}");
                            }
                            else if (timeIn == checking)
                            {
                                Console.WriteLine("Please time in first.");
                                Console.WriteLine("\n \n \n");
                                Main(args);
                            }
                            else if (timeIn < gracePeriod)
                            {
                                Console.WriteLine($"Hi employee {employeeId}");
                                Console.WriteLine("You're not late.");
                            }
                           
                        }
                        else
                        {
                            Console.WriteLine("Error (Incorrect Employee ID or Password");
                            Console.WriteLine("\n \n \n");
                            Main(args);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error (Incorrect Employee ID or Password" + employeeId + id);
                        Console.WriteLine("\n \n \n");
                        Main(args);
                    }

                    break;

                        }
                    }
            }
        }
