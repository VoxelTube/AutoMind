﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMind
{
    internal class CalculatingEnvironment
    {
        public List<Property> Properties;
        public List<Constant> Constants;
        public List<Formula> Functions;
        public CalculatingEnvironment()
        {
            Properties = new List<Property>();
            Constants = new List<Constant>();
            Functions = new List<Formula>();
        }
        public void AddEnviromentPack(string import)
        {
            var file = File.ReadAllText(import);
            file.Replace("\t", "");
            file.Replace("\n", "");

        }
    }
}