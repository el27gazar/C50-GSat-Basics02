using System;
using System.Collections.Generic;
using System.Text;

namespace CApp_1
{
    internal class Book
    {
        public string Tittle;
        public int Pages;

        override public string ToString()
        {
            return $"Title: {Tittle}, Pages: {Pages}";
        }
    }
}
