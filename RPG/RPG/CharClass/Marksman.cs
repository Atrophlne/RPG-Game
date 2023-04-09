using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.CharClass
    {
    public class Marksman : FullClass
        {
        // Overloading class
        public Marksman() : base() 
            {
            }

        public Marksman(string name, CharGend gender) : base ()
            {
            Name = name;
            Gender = gender;
            char_power = 10;
            char_def = 5;
            char_intel = 15;
            char_health = 20;
            }

        public Marksman(string name, CharGend gender, int power, int def, int intel, int health) 
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
