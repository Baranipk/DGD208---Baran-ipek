using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Exceptions_Throw_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception ex0 = new Exception("my inner exception");

            Exception ex = new Exception("bu bir hatadır !",ex0);

            ex.Source = "aptalca birşey";

            MyException mEx = new MyException("my exeptions");

            throw mEx;
            throw ex;

        }

    }

    class MyException : Exception
    {
        public MyException():base() { }

        public MyException(string message):base(message) { }

        public MyException(string mesasge,Exception ex):base() { }
    }
}
