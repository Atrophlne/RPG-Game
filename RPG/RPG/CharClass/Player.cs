using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.CharClass
    {
    public class Player : FullClass
        {
        public Player()
            : base()
        {

        }

        public Player(string name, CharGend eGender, CharacterClass eClass)
            : base()
            {
            Name = name;
            Gender = eGender;
            CharClasses = eClass;
            }
        public Player(string name, CharGend gender, CharacterClass eClass, int power, int def, int intel, int health) 
            {
            char_name = name;
            char_gender = gender;
            char_class = eClass;
            char_power = power;
            char_def = def;
            char_intel = intel;
            char_health = health;
            }
        }
    }
