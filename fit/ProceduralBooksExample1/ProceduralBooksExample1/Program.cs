using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceduralBooksExample1
{
    //there are no classes in Procedural Programing
    //we are supposed to work in C
    class Program
    {

        //Define a structure to hold Book information
        //We dont have the string type in C (instead we use char[] )
         struct  Book
        {
            //c# struct members would be private by default
            //we would not need to use access modifiers in C because they are not part
            //of the C language or the Procedural Programming paradigm      
           public string title;
           public string author;
           public string subject;
           public int book_id;
        }

        //We need static in C# - Not in 'C'
        static void Main(string[] args)
        {

            //We need to see the new keyword to create a new struct
            //We do not use the new keyword in C
            //'new' is used in OOp to create a new instance of an object
            //We do not have Classes/objects in 'C'


            //create a few book structures and assign vales to its properties
            Book book1 = new Book();
            book1.author = "Ken Jones";
            book1.title = "Lala Land";
            book1.subject = "musical";
            book1.book_id = 44;

            Book book2 = new Book();
            book2.author = "Tim Court";
            book2.title = "Red Label";
            book2.subject = "crime";
            book2.book_id = 74;

            Book book3 = new Book();
            book3.author = "Treci autor";
            book3.title = "Knjiga treca";
            book3.subject = "thriller";
            book3.book_id = 14;

            


            //An array of  book structures
           // or  Book[] allBooks = { book1, book2, book3};
            Book[] books = new Book [3];


            //put some books in array
            books[0] = book1;
            books[1] = book2;
            books[2] = book3;

            //Book 4 will be a copy of book 2
            Book book4 = book2;


            //Print the info for a book
            printBooks(book3);


            //Print the infor for all the books in array
            printAllBooksInfo(books);

            Console.ReadLine();


        }

        //Create a method to print all the info about a given book structure
        //has to be static to be called in main method
       static void printBooks(Book book) {

            //print data for the book
        Console.WriteLine("*****************************************************\n");
        Console.WriteLine("The Author of Book  is: {0} \n", book.author);
        Console.WriteLine("The Title of Book is: {0} \n", book.title);
        Console.WriteLine("The Subject of Book  is: {0} \n", book.subject);
        Console.WriteLine("The ID of Book is: {0} \n", book.book_id);
        Console.WriteLine("\n");
           }



        //Create a method to print all the info  for each book in and array of book structure
       static void printAllBooksInfo(Book[] books) {
	        for (int i = 0; i< books.Length; i++) 
            {
                printBooks(books[i]);
            }

       }

       
    }
}
