using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace Assiment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question1
            //Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print  both title and upperTitle to show that title did not change.
            /*string title = "clean code";
            string upperTitle= title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(upperTitle);*/

            #endregion

            #region Question2
            //Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory.
            /*  string cl = "Clean Code";
              string cle = "Clean Code";
              Console.WriteLine(ReferenceEquals(cl,cle));*/
            #endregion

            #region Question3
            // Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same object.Print the final result.
            /*StringBuilder s1 = new StringBuilder();
            s1.Append("Book List");
            s1.Append(" - Updated");
            Console.WriteLine(s1);*/




            #endregion

            #region Question4
            //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".  Print the result.
            /* s1.Replace("Book List" , "Library");
             Console.WriteLine(s1);*/
            #endregion

            #region  Question5
            //Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,  Pages: 464" using the + operator. 
            /* string title = "Clean Code ";
             int pages = 464;
             Console.WriteLine("Book:"+ title +"," + "Pages:"+ pages); */

            #endregion

            #region Question6
            //Build the same sentence as above, but using string interpolation ($"..."). 
            /* string title = "Clean Code ";
             int pages = 464;
             Console.WriteLine($"Book:{title},Pages: {pages}");*/
            #endregion

            #region Question7
            //Build the same sentence again, but using string.Format(). 
            /* string title = "Clean Code ";
             int pages = 464;
             Console.WriteLine("Book:{0}, Pages:{1}", title , pages);*/
            #endregion

            #region Question8
            //Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than  300, otherwise prints "Short Book".
            /* int pages = 464;
             if (pages >300)
             {
                 Console.WriteLine("Long Book");
             }else
             {
                 Console.WriteLine("Short Book");
             }*/
            #endregion

            #region Qustion9
            //Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is greater than 300 and isAvailable is true.Use the && operator. 
            /*int pages = 464;
            bool isAvailable = true;
            if (pages>300 && isAvailable == true)
            {
                Console.WriteLine("You can borrow this book");

            }else
            {
                Console.WriteLine("not found");
            }*/



            #endregion

            #region Question10
            //Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else. 
            /* string title = "Refactoring";
             switch (title)
             {
                 case "Clean Code": Console.WriteLine("Great choice!"); break;
                 case "Refactoring": Console.WriteLine("Nice pick!"); break;
                 default: Console.WriteLine("Never heard of it"); break;

             }*/


            #endregion

            #region  Question11
            //Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a variable sizeLabel(same rule as question 8: long if pages > 300).
            /* int pages = 100;
             string sizeLabel = (pages > 300) ? "Long Book" : "Short Book";
             Console.WriteLine(sizeLabel); */


            #endregion

            #region  Question12
            //Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop to print each book with its position number, like 1.Clean Code.
            /* string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
              for (int i = 0; i < books.Length ; i++)
                {
                    Console.WriteLine(i+"." + books[i]);

                }*/
            #endregion


            #region  Question13
            //Using the same books array, use a while loop to print every book title.
            /*string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
             int i = 0;
             while (i<= books.Length )
             {
                 Console.WriteLine("Book title:" + books[i]);
                 i++;
             }*/

            #endregion

            #region  Question14
            //Write a do-while loop that prints "Checking book..." exactly 3 times. 
            /*  string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
              int i = 0;
              do
              {
                  Console.WriteLine("Checking book...");
                  i++;
              }
              while (i < books.Length);*/


            #endregion

            #region Qustion15
            //Using the same books array, use a foreach loop to print every book title. 
            /* string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
             foreach (string book in books)
             {
                 Console.WriteLine(book);
             }*/
            #endregion


            #region Qustion16
            //Using the same books array, loop through it and print each title, but stop completely (break) once  you reach "Refactoring".
           /* string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string book in books)
            { 
                Console.WriteLine(book);
                if (book == "Refactoring")
                {
                    break;
                }
            }*/
            #endregion
        }
    }
}
