﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProGitForProgrammers
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{LastName} {FirstName}";
            }
        }
    }

}
