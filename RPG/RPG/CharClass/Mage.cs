using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.CharClass
    {
    public class Mage : FullClass
        {
        public Mage()
            : base()
            { 
            }

        public Mage(string name, CharGend gender) : base ()
            {
            Name = name;
            Gender = gender;
            char_power = 15;
            char_def = 3;
            char_intel = 30;
            char_health = 30;
            }

        public Mage(string name, CharGend gender, int power, int def, int intel, int health) 
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
