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

           
        }
    }
}
