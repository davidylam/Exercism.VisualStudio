using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.hello_world
{
    public class HelloWorld
    {
        public static string Hello(string msg)
        {
            string result = string.Empty;
            if (msg == null)
            {
                result = "Hello, World!";
            }
            else {
                result = $"Hello, {msg}!";
            }
            return result;
        }

    }
}
