using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Standard
{
    public static class Generators
    {
        public static string WelcomeMessage(string prefix, string lastName)
        {
            return $"Welcome to our demo Application {prefix} {lastName}";
        }

        public static string FareWellMessage(string prefix, string lastName)
        {
            return $"I hope yoi enjoyed yur time with us {prefix} {lastName}. Please come back soon.";
        }

    }
}
