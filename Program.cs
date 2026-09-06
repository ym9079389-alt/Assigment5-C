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

            
        }
    }
}
