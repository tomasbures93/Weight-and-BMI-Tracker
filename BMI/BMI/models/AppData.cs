﻿using BMI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI.models
{
    public static class AppData
    {
        internal static Person User { get; set; } = new Person("", 0, 0, 0, "", 0);
    }
}
