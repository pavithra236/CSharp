using System;
using System.Collections.Generic;
namespace OnlineMovieTicket
{
    class Program
    {
        public static List<PersonalDetails> personalDetailsList = new List<PersonalDetails>();
        public static List<UserDetails> userDetailsList = new List<UserDetails>();
        public static List<BookingDetails> bookingDetailsList = new List<BookingDetails>();
        public static List<TheatreDetails> theatreDetailsList = new List<TheatreDetails>();
        public static List<MovieDetails> movieDetailsList = new List<MovieDetails>();
        public static List<ScreeningDetails> screeningDetailsList = new List<ScreeningDetails>();
        static UserDetails CurentLoginUser;
        public static void Main()
        {   FileHandling.Create();
            FileHandling.ReadToCSV();
           //DefaultValues();
            // DisplayDefaultValues();


            Console.WriteLine("Welcome To The BookShow");
            string choice = "yes";
            do
            {
                Console.WriteLine("1.User Registeration");
                Console.WriteLine("2.Login");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Choose the above options");
                string options = Console.ReadLine();
                switch (options)
                {
                    case "1":
                        {
                            UserRegisteration();
                            break;
                        }
                    case "2":
                        {
                            Login();
                            break;
                        }
                    case "3":
                        {
                            choice = "no";
                            Console.WriteLine("THANK YOU !");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("YOUR SELECT THE INVALID OPTION,PLEASE ENTER THE VALID OPTION");
                            break;
                        }

                }
            } while (choice == "yes");
            FileHandling.WriteToCSV();
        }
        public static void UserRegisteration()
        {
            Console.WriteLine("USER REGISTRATION !");
            string Name;
            bool nameIsValid;

            do
            {
                Console.WriteLine("ENTER YOUR NAME:");
                Name = Console.ReadLine().ToLower();
                nameIsValid = !string.IsNullOrEmpty(Name) &&
                               !Name.Contains("  ") &&
                               Name.Length > 0 &&
                               Name[0] != ' ' &&
                               Name[Name.Length - 1] != ' ';

                if (nameIsValid)
                {
                    bool containsOnlyLettersAndSpaces = true;

                    for (int i = 0; i < Name.Length; i++)
                    {
                        char c = Name[i];
                        if (!char.IsLetter(c) && c != ' ')
                        {
                            containsOnlyLettersAndSpaces = false;
                            break;
                        }
                    }

                    nameIsValid = containsOnlyLettersAndSpaces;
                }

                if (!nameIsValid)
                {
                    Console.WriteLine("Please enter a valid Name");
                }


            } while (!nameIsValid);

            int Age;

            do
            {
                Console.Write("ENTER YOUR AGE: ");
                string tempAge = Console.ReadLine();
                if (int.TryParse(tempAge, out Age) && !tempAge.StartsWith(" ") && !tempAge.EndsWith(" "))
                {
                    if (Age >= 0 && Age <= 150 )
                    {
                        Console.WriteLine(tempAge);
                        break;
                    }
                    

                }
                else
                {
                    Console.WriteLine("INVALID AGE,ENTER THE VALID AGE");
                }
            } while (true);
            //  int Age = int.Parse(Console.ReadLine());
            int phonenumber;
            do
            {

                Console.WriteLine("Enter Your Mobile Number (Must Be 10 Digits)");
                string mobilenumber = Console.ReadLine().Trim();
                if (int.TryParse(mobilenumber, out phonenumber) && mobilenumber.Length == 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Your Mobile Number");
                }


            } while (true);

            Gender1 gender1;
            do
            {

                Console.WriteLine("Enter Your Gender");
                string gender = Console.ReadLine();
                if (Enum.TryParse(gender, true, out gender1))
                {
                    if (int.TryParse(gender, out _))
                    {
                        Console.WriteLine("Invalid Input Please Try Again");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input Please Try Again ");
                }
            } while (true);
            double walletbalance;
            do
            {

                Console.WriteLine("Enter Your Wallet Balance");
                string balance = Console.ReadLine();
                if (double.TryParse(balance, out walletbalance) && walletbalance > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Amount Please Try Again");

                }
            } while (true);


            PersonalDetails personalDetails = new PersonalDetails(Name, Age, phonenumber, gender1);
            UserDetails userDetails = new UserDetails(walletbalance, personalDetails.Name, personalDetails.Age, personalDetails.PhoneNumber, personalDetails.Gender);

            personalDetailsList.Add(personalDetails);
            userDetailsList.Add(userDetails);
            Console.WriteLine("Your RegistrationID : " + userDetails._userID);
            Console.WriteLine("Registration Successfully");
        }
        public static bool SpecialCase(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return true; // Special character found
                }
            }
            return false; // No special characters found
        }
        public static void DefaultValues()
        {
            theatreDetailsList.Add(new TheatreDetails("TID301", "Inox", "Anna Nagar"));
            theatreDetailsList.Add(new TheatreDetails("TID302", "Ega Theatre", "Chetpet"));
            theatreDetailsList.Add(new TheatreDetails("TID303", "Kamala", "Vadapalani"));

            movieDetailsList.Add(new MovieDetails("MID501", "Bagubali 2", "Telugu"));
            movieDetailsList.Add(new MovieDetails("MID502", "Ponniyin Selvan", "Tamil"));
            movieDetailsList.Add(new MovieDetails("MID503", "Cobra", "Tamil"));
            movieDetailsList.Add(new MovieDetails("MID504", "Vikram", "Hindi (Dubbed)"));
            movieDetailsList.Add(new MovieDetails("MID505", "Vikram", "Tamil"));
            movieDetailsList.Add(new MovieDetails("MID506", "Beast", "English"));


            screeningDetailsList.Add(new ScreeningDetails("MID501", "TID301", 200, 5));
            screeningDetailsList.Add(new ScreeningDetails("MID502", "TID301", 300, 2));
            screeningDetailsList.Add(new ScreeningDetails("MID506", "TID301", 50, 1));
            screeningDetailsList.Add(new ScreeningDetails("MID501", "TID302", 400, 11));
            screeningDetailsList.Add(new ScreeningDetails("MID505", "TID302", 300, 20));
            screeningDetailsList.Add(new ScreeningDetails("MID504", "TID302", 500, 2));
            screeningDetailsList.Add(new ScreeningDetails("MID505", "TID303", 100, 11));
            screeningDetailsList.Add(new ScreeningDetails("MID502", "TID303", 200, 20));
            screeningDetailsList.Add(new ScreeningDetails("MID504", "TID303", 350, 2));
            bookingDetailsList.Add(new BookingDetails("UID1001", "MID501", "TID301", 1, 236, BookingStatus.Booked));
            bookingDetailsList.Add(new BookingDetails("UID1001", "MID504", "TID302", 1, 472, BookingStatus.Booked));
            bookingDetailsList.Add(new BookingDetails("UID1002", "MID505", "TID302", 1, 354, BookingStatus.Booked));

            userDetailsList.Add(new UserDetails(1000, "Pavithra", 20, 9066307311, Gender1.Female));
            userDetailsList.Add(new UserDetails(2000, "Baskaran", 30, 9857747327, Gender1.Male));
        }
        public static void Login()
        {
            Console.WriteLine("Enter The UserId");
            string currentuserid = Console.ReadLine().ToUpper();
            bool check = false;
            foreach (var user in userDetailsList)
            {
                if (currentuserid == user._userID)
                {
                    check = true;
                    CurentLoginUser = user;
                    Console.WriteLine("successfully login ");
                    Submenu();
                    break;
                }
            }
            if (check == false)
            {
                Console.WriteLine("Enter the Correct login id");

            }

        }





        public static void Submenu()
        {

            Console.WriteLine("Submenu : ");
            string choice = "yes";
            do
            {
                Console.WriteLine("1.Ticket Booking");
                Console.WriteLine("2.Ticket Cancellation");
                Console.WriteLine("3.Booking History");
                Console.WriteLine("4.Wallet Recharge");
                Console.WriteLine("5.Show wallet Balance");
                Console.WriteLine("6.Exit");
                Console.WriteLine("choose above options");
                string options = Console.ReadLine();
                switch (options)
                {
                    case "1":
                        {
                            BookTicket();
                            break;
                        }
                    case "2":
                        {
                            CancelTicket();
                            break;
                        }
                    case "3":
                        {
                            ShowBookingHistory();
                            break;
                        }
                    case "4":
                        {
                            RechargeWallet();
                            break;
                        }
                    case "5":
                        {
                            ShowWalletBalance();
                            break;
                        }
                        case "6":
                        {
                            choice = "No";
                            break;
                        }

                    default:
                        {
                            
                            Console.WriteLine("select correct choice");

                            break;
                        }

                }
            } while (choice == "yes");



        }
       public static void BookTicket()
{
    Console.WriteLine("Available Theatres:");
    screen();  // Display available screenings with theatre and movie details
    
    Console.WriteLine("Please select the Theatre ID from the list above:");
    string selectedTheatreId = Console.ReadLine()?.ToUpper();
    bool tdcheck = false;

    foreach (var theatre in theatreDetailsList)
    {
        if (selectedTheatreId == theatre._TheatreID)
        {
            tdcheck = true;

            // Display available movies in the selected theatre
            movies();

            Console.WriteLine("Please select the Movie ID from the list above:");
            string selectedMovieId = Console.ReadLine()?.ToUpper();
            bool mtcheck = false;

            foreach (var movie in movieDetailsList)
            {
                if (selectedMovieId == movie._MovieID)
                {
                    mtcheck = true;

                    Console.WriteLine("Please select the number of seats:");
                    bool seatcheck = false;

                    foreach (var screen in screeningDetailsList)
                    {
                        if (screen.MovieID == selectedMovieId && screen.TheatreID == selectedTheatreId)
                        {
                            // Display seat availability
                            Console.WriteLine($"Currently available seats: {screen.NoOfSeatsAvailable}");

                            if (!int.TryParse(Console.ReadLine(), out int noofseats))
                            {
                                Console.WriteLine("Invalid number of seats.");
                                return;
                            }

                            if (noofseats <= screen.NoOfSeatsAvailable)
                            {
                                seatcheck = true;
                                double totalAmount = noofseats * screen.TicketPrice * 1.18; // Include GST

                                if (CurentLoginUser.WalletBalance < totalAmount)
                                {
                                    Console.WriteLine("Insufficient Wallet Balance. Please recharge your wallet.");
                                    return;
                                }

                                // Deduct balance and update seat availability
                                CurentLoginUser.DeductBalance(totalAmount);
                                screen.NoOfSeatsAvailable -= noofseats;

                                // Create a new booking
                                BookingDetails booking = new BookingDetails(CurentLoginUser._userID, selectedMovieId, selectedTheatreId, noofseats, totalAmount, BookingStatus.Booked);
                                bookingDetailsList.Add(booking);

                                // Display booking information
                                Console.WriteLine("Booking Successful!");
                                Console.WriteLine($"Booking ID : {booking._BookingID}");
                                Console.WriteLine($"Booking Status : {booking.bookingStatus}");
                                Console.WriteLine($"Total Amount : {totalAmount}");
                                Console.WriteLine($"Current Wallet Balance: {CurentLoginUser.WalletBalance}");

                                return;
                            }
                            else
                            {
                                Console.WriteLine($"Required seat count not available. Current availability is {screen.NoOfSeatsAvailable}.");
                                return;
                            }
                        }
                    }
                    
                    if (!seatcheck)
                    {
                        Console.WriteLine("Screening information is not available.");
                        return;
                    }
                }
            }
            
            if (!mtcheck)
            {
                Console.WriteLine("Invalid Movie ID.");
                return;
            }
        }
    }
    
    if (!tdcheck)
    {
        Console.WriteLine("Invalid Theatre ID.");
    }
}

        public static void movies()
        {
            foreach (var movie in movieDetailsList)
            {
                Console.WriteLine("Movie ID : " + movie._MovieID);
                Console.WriteLine("Movie Name : " + movie.MovieName);
                Console.WriteLine("Language : " + movie.Language);
                Console.WriteLine("-------------------------");
            }
        }
        public static void screen()
        {
            foreach (var ticket in screeningDetailsList)
            {
                Console.WriteLine($"Movie ID :   {ticket.MovieID} , Theatre ID :   {ticket.TheatreID} , Ticket Price :  {ticket.TicketPrice} , Seat Availability : {ticket.NoOfSeatsAvailable}");

                Console.WriteLine("------------------------------------------");
            }
        }
        public static void CancelTicket()
        {

            bool bookingFound = false;
            foreach (var history in bookingDetailsList)
            {
                if (CurentLoginUser._userID == history.UserID)
                {
                    bookingFound = true;
                    Console.WriteLine("User ID: " + history.UserID);
                    Console.WriteLine("Theatre ID: " + history.TheatreID);
                    Console.WriteLine("Movie ID: " + history.MovieID);
                    Console.WriteLine("Total Amount: " + history.TotalAmount);
                    Console.WriteLine("Seat Count: " + history.SeatCount);
                    Console.WriteLine("Booking ID: " + history._BookingID);
                    Console.WriteLine("Booking Status: " + history.bookingStatus);
                    Console.WriteLine("-------------------------------");
                }
            }


            if (!bookingFound)
            {
                Console.WriteLine("You don't have any bookings to cancel.");
                return;
            }


            Console.WriteLine("Enter the booking ID to cancel: ");
            string bookid = Console.ReadLine();
            bool bookingIdFound = false;

            foreach (var history in bookingDetailsList)
            {
                if (CurentLoginUser._userID == history.UserID && history._BookingID == bookid)
                {
                    bookingIdFound = true;


                    if (history.bookingStatus == BookingStatus.Booked)
                    {
                        foreach (var screening in screeningDetailsList)
                        {
                            if (screening.TheatreID == history.TheatreID && screening.MovieID == history.MovieID)
                            {

                                screening.NoOfSeatsAvailable += history.SeatCount;
                                screening.TicketPrice -= 20;
                                CurentLoginUser.WalletBalance += screening.TicketPrice;

                                history.bookingStatus = BookingStatus.Cancelled;

                                Console.WriteLine("Ticket has been successfully cancelled.");
                                return;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("The booking is not in 'Booked' status, so it cannot be cancelled.");
                        return;
                    }
                }
            }


            if (!bookingIdFound)
            {
                Console.WriteLine("Invalid booking ID.");
            }
        }


        public static void ShowBookingHistory()
        {
            bool check = false;
            foreach (var History in bookingDetailsList)
            {
                if (CurentLoginUser._userID == History.UserID)
                {
                    check = true;
                    Console.WriteLine("Booking ID: " + History._BookingID);
                    Console.WriteLine("User ID: " + History.UserID);
                    Console.WriteLine("Theatre ID: " + History.TheatreID);
                    Console.WriteLine("Movie ID: " + History.MovieID);
                    Console.WriteLine("Total Amount: " + History.TotalAmount);
                    Console.WriteLine("Seat Count: " + History.SeatCount);
                    Console.WriteLine("Booking Status: " + History.bookingStatus);
                    Console.WriteLine("-------------------------------");
                }
            }
            if (!check)
            {
                Console.WriteLine("No history found");
            }
        }


        public static void RechargeWallet()
        {
            Console.WriteLine("Enter the amount");
            double amount = double.Parse(Console.ReadLine());
            CurentLoginUser.RechargeWallet(amount);
            Console.WriteLine("Current wallet balance : " + CurentLoginUser.WalletBalance);
            Console.WriteLine("Recharge successfully!");
        }

        public static void ShowWalletBalance()
        {
            Console.WriteLine("Your Wallet Balance : " + CurentLoginUser.WalletBalance);
        }

    }
}