﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopperPractice15_08.Model
{
    internal class Author
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Book> Books { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
