﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {
        public int UID { get; set; }
        public string username { get; set; }

        public override string ToString()
        {
            return "UID: " + UID +
                " username: " + username;
        }
    }
}
