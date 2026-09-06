using System.Collections.Specialized;
using System.Drawing;
using System.Runtime.Serialization.Formatters;

namespace Assigment5_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q 1
            // Add a private string password = "secret"; field to a Book class. Try to print it from Main
            //(outside the class). What happens, and why?
            Book book = new Book();
            Console.WriteLine(book.Password);
            // ظهر  compile error لان بالنسباله مفيش متغير بالاسم ده لانه متعرف private
            #endregion
        }
    }
}
