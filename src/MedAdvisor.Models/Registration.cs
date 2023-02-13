﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAdvisor.Models
{
  public class Registration
    {
       public int Id { get; set; }
        public string ?UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public string IsActive { get; set; }
    }
}
