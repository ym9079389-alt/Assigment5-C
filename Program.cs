using System.Collections.Specialized;
using System.Drawing;
using System.Reflection;
using System.Runtime.Serialization.Formatters;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assigment5_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            #region Q 1
            // Add a private string password = "secret"; field to a Book class. Try to print it from Main
            //(outside the class). What happens, and why?
            //Console.WriteLine(book.Password);
            // ظهر  compile error لان بالنسباله مفيش متغير بالاسم ده لانه متعرف private
            #endregion

            #region Q 2
            //Add an internal int copiesInStock = 5; field to Book.Print it from Main.Does it compile? Why ?
            //Console.WriteLine(book.copiesInStock);
            // ظهر 5 لان internal متعرفه داخل نفس المشروع
            #endregion

            #region Q 3
            //Add a public string Title; field to Book.Set it and print it from Main.
            //Console.Write("Enter the title of the book:");
            //book.Title = Console.ReadLine();
            //Console.WriteLine(book.Title);
            #endregion

            #region Q 4
            //Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book, assign it Genre.Science, and print it.
            //book.Genre = Genre.Science;
            //Console.WriteLine(book.Genre);
            #endregion

            #region Q 5
            //Using the Genre enum above, print the underlying int value of Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.
            //int fictionValue = (int) Genre.Fiction;
            //int nonFictionValue = (int) Genre.NonFiction;
            //int scienceValue = (int) Genre.Science;
            //Console.WriteLine(fictionValue);
            //Console.WriteLine(nonFictionValue);
            //Console.WriteLine(scienceValue);
            #endregion

            #region Q 6
            //Given int genreNumber = 1;, cast it into a Genre value and print the result.
            //int genreNumber = 1;
            //Genre genre = (Genre)genreNumber;
            //Console.WriteLine(genre);
            #endregion

           
        }
    }
}
