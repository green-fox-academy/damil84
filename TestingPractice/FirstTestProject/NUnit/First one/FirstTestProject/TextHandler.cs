using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTestProject
{
    public class TextHandler
    {
        public string MakeUpperCase(string value)
        {
            return value.ToUpper();
        }

        public string MakeLowerCase(string value)
        {
            return value.ToLower();
        }

        public string UnfinishedMethod(string value)
        {
            throw new NotImplementedException();
        }
    }

}