using System.ComponentModel;
using System.Drawing;
using System.Dynamic;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assigment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            /*Q01.Create a Book class with a Title(string) and Pages(int). Create a Book object and store it in a
             variable of type object.Print it.*/
            //object obj;
            //Book book = new Book() { Title = "C# Programming", Pages = 300 };
            //obj = book;
            //Console.WriteLine(obj);
            #endregion
            #region Question2
            /*Q02.Using the Book class above, print the result of calling ToString(), Equals() (compare book with
             itself), GetHashCode(), and GetType() on book.*/
            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());
            #endregion
            #region Question3
            /*Q03.Look at the line below.Is it a compile - time error, a runtime error, or a logical error? Fix it.
             int pages = "464";*/
            //Compile time error: Cannot implicitly convert type 'string' to 'int'
            //int pages = 464;
            #endregion
            #region Question4
            /*Q04.Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by
             zero", and then prints "Done" in a finally block.*/
            //try
            //{
            //    int x = 10, y = 0;
            //    int result = x / y;
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}
            #endregion
            #region Question5
            //Q05.Declare an int pages = 300; then store it in a double variable without using a cast.
            //int pages = 300;
            //double pagesDouble = pages;
            #endregion
            #region Question6
            //Q06.Declare a double price = 49.99; then convert it into an int using a cast.
            //double price = 49.99;
            //int priceInt = (int)price;
            //Console.WriteLine(priceInt);
            #endregion
            #region Question7
            //Q07. Given string pagesText = "464";, convert it into an int using the Convert class.
            //string pagesText = "464";
            //int pages = Convert.ToInt32(pagesText);
            //Console.WriteLine(pages);
            #endregion
            #region Question8
            /*Q08.Given string yearText = "2023";, convert it using int.Parse().Then given string badText = "abc";,
             use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.*/
            //string yearText = "2023";
            //int year = int.Parse(yearText);
            //string badText = "abc";
            //int number;
            //bool b = int.TryParse(badText, out number);
            //if (b)
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Number");
            //}
            #endregion
            #region Question9
            /*Q09.Given int pages = 464;, convert it into a string using ToString() and print its type using GetType()
            to prove it's now a string.*/
            //int pages = 464;
            //string pagesText = pages.ToString();
            //Console.WriteLine(pagesText.GetType());
            #endregion
            #region Question10
            /*Q10.Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int
            variable, and print both.*/
            //int copies = 100;
            //object obj = copies;
            //Console.WriteLine(obj);
            //int x = (int)obj;
            //Console.WriteLine(x);
            #endregion
            #region Question11
            //Q11. Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its value.
            //int? year = null;
            //Console.WriteLine(year.HasValue);
            //year = 2023;
            //Console.WriteLine(year);
            #endregion
            #region Question12
            //Q12. Declare a string? reviewer = null;. Print whether it is null.
            //string? reviewer = null;
            //Console.WriteLine(reviewer == null);
            #endregion
            #region Question13
            /*Q13. Declare a Book? book = null;. Use ?. to safely read book.Title without crashing the program, and
             print the result.*/
            //Book? book = null;
            //Console.WriteLine(book?.Title);
            #endregion
            #region Question14
            /*Q14.Using title from the previous question, use ?? to print "Untitled" if title is null.Then use ??= to
            assign title the value "Untitled" only if it's still null.*/
            //string? title = null;
            //Console.WriteLine(title ?? "Untitled");
            //Console.WriteLine(title ??= "Untitled");
            #endregion
            #region Question15
            /*Q15.Given string? name = "Ahmed"; (you are sure it's not null here), assign it to a non-nullable string
            confirmedName using the ! operator.*/
            //string? name = "Ahmed";
            //string confirmedName = name!;
            //Console.WriteLine(confirmedName);
            #endregion

        }
    }
}
