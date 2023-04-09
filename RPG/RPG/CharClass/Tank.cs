using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.CharClass
    {
    public class Tank : FullClass
        {
        // Overloading class
        public Tank()
            : base()
            { 
            }

        public Tank(string name, CharGend gender) : base ()
            {
            Name = name;
            Gender = gender;
            char_power = 5;
            char_def = 15;
            char_intel = 5;
            char_health = 40;
            }

        public Tank(string name, CharGend gender, int power, int def, int intel, int health) 
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
