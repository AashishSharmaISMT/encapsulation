// // // // Student a=new Student("Kisan Mahat");
// // // // int c = a.study(20,30);
// // // // a.draw();
// // // // Console.WriteLine(c);



// // // // Student b=new Student("xyz ads");

// // // // b.draw();
// // // // Console.WriteLine(b.study(30,10));





// // // // class Student{
// // // //     public string Name="";

// // // // public Student(String name)
// // // // {
// // // //     Name=name;
// // // // }

// // // // public void draw()
// // // //     {
// // // //         Console.WriteLine($"name=(Name)");
// // // //     }



// // // //     public int study(int a, int b){
// // // //         return a+b;
// // // //     }
// // // // }




// // // // // Console.Write("Enter first number: ");
// // // // // int num1 = Convert.ToInt32(Console.ReadLine());

// // // // // Console.Write("Enter second number: ");
// // // // // int num2 = Convert.ToInt32(Console.ReadLine());

// // // // // Student a = new Student();

// // // // // int c = a.study(num1, num2);

// // // // // Console.WriteLine("Result: " + c);


// // // // // class Student
// // // // // {
// // // // //     public string Name = "";

// // // // //     public int study(int a, int b)
// // // // //     {
// // // // //         return a + b;
// // // // //     }
// // // // // }





// // // Movie mov1 = new Movie("Avengers: Doomsday", "2 hours", "Action");

// // // mov1.customer.Add("Atul Sinjali");
// // // mov1.customer.Add("AtulSinjali1984@gmail.com");
// // // mov1.customer.Add("9876223990");
// // // mov1.Ticket(1, 300);
// // // mov1.Show();

// // // class Movie
// // // {
// // //     public string movieName = "";
// // //     public string duration = "";
// // //     public string genra = "";
// // //     public int ticketPrice = 0;
// // //     public int numTicket = 0;
// // //     public List<string> customer = new List<string>();

// // //     public Movie(string moviename, string duraa, string gen)
// // //     {
// // //         movieName = moviename;
// // //         duration = duraa;
// // //         genra = gen;
// // //     }
// // //     public int Ticket(int numtick, int pric)
// // //     {
// // //         numTicket = numtick;
// // //         ticketPrice = pric;

// // //         return 0;
// // //     }
// // //     public int TotalPrice()
// // //     {
// // //         return ticketPrice * numTicket;
// // //     }
// // //     public void Show()
// // //     {
// // //         Console.WriteLine("Name:    " + customer[0]);
// // //         Console.WriteLine("Email:   " + customer[1]);
// // //         Console.WriteLine("Phone:   " + customer[2]);
// // //         Console.WriteLine("Tickets: " + numTicket);
// // //         Console.WriteLine("Price:   " + ticketPrice);
// // //         Console.WriteLine("Total:   " + TotalPrice());
// // //     }



// // // }



// // // Movie mov1 = new Movie("Avengers: Doomsday", "2.3 hours");
// // // Movie mov2 = new Movie("Avengers: Infinity War", "2.4 hours");
// // // Movie mov3 = new Movie("Avengers: Endgame", "2 hours");
// // // Movie mov4 = new Movie("Spiderman: Brand New Day ", "2.2 hours");
// // // Movie mov5 = new Movie("Spiderman: Far From Home ", "2.1 hours");

// // // class Movie
// // // {

// // // }


// // // using System;

// // // class Movie
// // // {
// // //     public string[] movie =
// // //     {
// // //         "Avengers",
// // //         "Avatar",
// // //         "Titanic",
// // //         "Inception",
// // //         "Interstellar"
// // //     };

// // //     public int[] price =
// // //     {
// // //         300,
// // //         350,
// // //         300,
// // //         400,
// // //         450
// // //     };

// // //     public void DisplayMovies()
// // //     {
// // //         Console.WriteLine("\n===== AVAILABLE MOVIES =====");

// // //         for (int i = 0; i < 5; i++)
// // //         {
// // //             Console.WriteLine(
// // //                 (i + 1) + ". " + movie[i] +
// // //                 " | Price: Rs. " + price[i]
// // //             );
// // //         }
// // //     }
// // // }


// // // class Customer
// // // {
// // //     public string name;
// // //     public string contact;
// // //     public string date;
// // //     public string time;

// // //     public void GetDetails(Movie m)
// // //     {
// // //         Console.WriteLine("\n===== CUSTOMER DETAILS =====");

// // //         Console.Write("Enter your name: ");
// // //         name = Console.ReadLine();

// // //         Console.Write("Enter contact number: ");
// // //         contact = Console.ReadLine();

// // //         Console.Write("Enter date: ");
// // //         date = Console.ReadLine();

// // //         Console.Write("Enter time: ");
// // //         time = Console.ReadLine();

// // //         // Display available movies
// // //         m.DisplayMovies();

// // //         Console.Write("\nChoose a movie (1-5): ");
// // //         int choice = Convert.ToInt32(Console.ReadLine());

// // //         if (choice >= 1 && choice <= 5)
// // //         {
// // //             Console.WriteLine("\n===== BOOKING CONFIRMED =====");

// // //             Console.WriteLine("Name: " + name);
// // //             Console.WriteLine("Contact: " + contact);
// // //             Console.WriteLine("Date: " + date);
// // //             Console.WriteLine("Time: " + time);
// // //             Console.WriteLine("Movie: " + m.movie[choice - 1]);
// // //             Console.WriteLine("Price: Rs. " + m.price[choice - 1]);
// // //         }
// // //         else
// // //         {
// // //             Console.WriteLine("Invalid movie choice!");
// // //         }
// // //     }
// // // }


// // // class Program
// // // {
// // //     static void Main()
// // //     {
// // //         Movie movie = new Movie();
// // //         Customer customer = new Customer();

// // //         customer.GetDetails(movie);
// // //     }
// // // }



// // // Movie[] movies = new Movie[]
// // // {
// // //     new Movie("Avengers: Doomsday", "2h 24m", 400);
// // //     new Movie("Avengers: Endgame", "2h 40m", 450);
// // //     new Movie("Transformers: Rise of The Beast", "2h 30m", 350);
// // //     new Movie("");
// // //     new Movie
// // // };

// // // Console.WriteLine("");
// // // Console.WriteLine("");
// // // Console.WriteLine("");

// // // Console.Write("Enter Customer Name: ");
// // // string customerName= Console.ReadLine()??"";

// // // Console.Write("Enter Customer Email: ");
// // // string customerEmail= Console.ReadLine()??"";

// // // Console.Write("Enter Movie Selection(1-5): ");
// // // string movieChoice= Console.ReadLine()??"";







// // // class Movie
// // // {
// // //     public string Name;
// // //     public string Duration;
// // //     public string Price;
// // //     public Movie(string name, string duration, double price)
// // //     {
// // //         Name=name;
// // //         Duration=duration;
// // //         price=price;

// // //     }

// // // }



// // Movie[] movies = new Movie[5]
// // {
// //     new Movie("Inception", "2h 28m", 12.50),
// //     new Movie("Avatar: The Way of Water", "3h 12m", 15.00),
// //     new Movie("The Dark Knight", "2h 32m", 10.00),
// //     new Movie("Interstellar", "2h 49m", 11.50),
// //     new Movie("Spider-Man: Across the Spider-Verse", "2h 20m", 13.00)
// // };


// // Console.WriteLine("========================================");
// // Console.WriteLine("    WELCOME TO THE MOVIE BOOKING APP    ");
// // Console.WriteLine("========================================\n");

// // Console.Write("Enter Customer Name: ");
// // string customerName = Console.ReadLine()??"";

// // Console.Write("Enter Contact Number: ");
// // string contact = Console.ReadLine()??"";

// // Console.WriteLine("\n--- Available Movies ---");
// // for (int i = 0; i < movies.Length; i++)
// // {
// //     Console.WriteLine($"{i + 1}. {movies[i].Name} | Duration: {movies[i].Duration} | Price: ${movies[i].Price}");
// // }

// // int choice = 0;
// // while (choice < 1 || choice > movies.Length)
// // {
// //     Console.Write($"\nSelect a movie (1-{movies.Length}): ");
// //     if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > movies.Length)
// //     {
// //         Console.WriteLine("Invalid choice. Please select a valid movie number.");
// //     }
// // }

// // Movie chosenMovie = movies[choice - 1];

// // Console.Write("Enter Show Date (e.g., YYYY-MM-DD): ");
// // string date = Console.ReadLine()??"";

// // Console.Write("Enter Show Time (e.g., 06:30 PM): ");
// // string time = Console.ReadLine()??"";

// // Customer customer = new Customer(customerName, contact, chosenMovie, date, time);
// // customer.PrintTicket();






// // class Movie{
// //     public string Name;
// //     public string Duration;
// //     public double Price;

// //     public Movie(string name, string duration, double price)
// //     {
// //         Name = name;
// //         Duration = duration;
// //         Price = price;
// //     }
// // }

// // class Customer
// // {
// //     public string Name;
// //     public string Contact;
// //     public Movie SelectedMovie;
// //     public string ShowDate;
// //     public string ShowTime;

// //     public Customer(string name, string contact, Movie selectedMovie, string showDate, string showTime)
// //     {
// //         Name = name;
// //         Contact = contact;
// //         SelectedMovie = selectedMovie;
// //         ShowDate = showDate;
// //         ShowTime = showTime;
// //     }

// //     public void PrintTicket()
// //     {
// //         Console.WriteLine("\n========================================");
// //         Console.WriteLine("          BOOKING CONFIRMATION          ");
// //         Console.WriteLine("========================================");
// //         Console.WriteLine($"Customer Name  : {Name}");
// //         Console.WriteLine($"Contact Number : {Contact}");
// //         Console.WriteLine($"Movie Selected : {SelectedMovie.Name}");
// //         Console.WriteLine($"Movie Duration : {SelectedMovie.Duration}");
// //         Console.WriteLine($"Ticket Price   : ${SelectedMovie.Price}");
// //         Console.WriteLine($"Show Date      : {ShowDate}");
// //         Console.WriteLine($"Show Time      : {ShowTime}");
// //         Console.WriteLine("========================================");
// //         Console.WriteLine("   Thank you for booking with us!      ");
// //         Console.WriteLine("========================================");
// //     }
// // }


// Student s = new Student();
// s.SetAge(22);
// Console.WriteLine(s.GetAge());

// class Student
// {
//     private int age;

//     public void SetAge(int newAge)
//     {
//         if (newAge >= 0 && newAge <= 120)
//             age = newAge;
//         else
//             Console.WriteLine("Invalid age");
//     }

//     public int GetAge()
//     {
//         return age;
//     }
// }

Person p = new Person();
p.Name = "Shyam";
Console.WriteLine(p.Name);
class Person
{
    private string name = "";
    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name=value;
        }
    }
}