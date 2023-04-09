using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.CharClass
    {
    public class Support : FullClass
        {
        public Support()
            : base()
            {
            }

        public Support(string name, CharGend gender)
            : base()
            {
            Name = name;
            Gender = gender;
            char_power = 3;
            char_def = 8;
            char_intel = 20;
            char_health = 25;
            }

        public Support(string name, CharGend gender, int power, int def, int intel, int health) 
            {
            char_name = name;
            char_gender = gender;
            char_power = power;
            char_def = def;
            char_intel = intel;
            char_health = health;
            }
        }
    }
