using System;
using System.Collections.Generic;

namespace ConAppAssisgnment_20 
{
    class Program
    {
        static void Main()
        {


            string op;
            do
            {
                Library library = new Library();


                Console.WriteLine("\n--- Library Management System ---");
                Console.WriteLine("1. Add a book");
                Console.WriteLine("2. View all books");
                Console.WriteLine("3. Search by ID");
                Console.WriteLine("4. Search by title");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Book ID: ");
                        int bookId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter Genre: ");
                        string genre = Console.ReadLine();
                        Console.Write("Is the book available? (True/False): ");
                        bool isAvailable = bool.Parse(Console.ReadLine());

                        Book book = new Book();
                        library.AddBook(book);
                        Console.WriteLine("Book added successfully!");
                        break;

                    case "2":
                        library.ViewAllBooks();
                        break;

                    case "3":
                        Console.Write("Enter Book ID to search: ");
                        int searchById = int.Parse(Console.ReadLine());
                        library.SearchBookById(searchById);
                        break;

                    case "4":
                        Console.Write("Enter Title to search: ");
                        string searchByTitle = Console.ReadLine();
                        library.SearchBookByTitle(searchByTitle);
                        break;

                    case "5":
                        Console.WriteLine("Exiting Library Management System.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine("Do you Want to Continue? ");
                op = Console.ReadLine().ToLower();
            } while (op == "y");
            Console.ReadKey();

        }
    }
 }

