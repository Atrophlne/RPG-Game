using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.CharClass
    {
    // C# enums
    public enum CharGend { Male, Female, Unknown }
    public enum CharacterClass { Assassin, Fighter, Mage, Marksman, Tank, Support, Unknown }

    // Class abstraction with C# properties
    public abstract class FullClass
        {

        // Methods Properties ---------------- Properties ---------------- 
        #region Properties

        // Name
        public string Name
        {
        get { return char_name; }
        protected set { char_name = value; }
        }

        // Gender
        public CharGend Gender
        {
        get { return char_gender; }
        protected set { char_gender = value; }
        }

        // Class
        public CharacterClass CharClasses
        {
        get { return char_class; }
        protected set { char_class = value; }
        }

        // Character Power / Strength
        public int CPower
        {
        get { return char_power + power_Mod; }
        protected set { char_power = value; }
        }
        // Character Inteligence
        public int CIntel
            {
            get { return char_intel + intel_Mod; }
            protected set { char_intel = value; }
            }
        // Character Defense
        public int CDef
            {
            get { return char_def + def_Mod; }
            protected set { char_def = value; }
            }
        // Character Health
        public int CHealth
            {
            get { return char_health + health_Mod; }
            protected set { char_health = value; }
            }

        //
        #endregion

        // Methods Region ---------------- Region ---------------- 
        #region Methods
        //

        //
        #endregion

        // Methods Constructor ---------------- Constructor ---------------- 
        #region Constructor
        //
        public FullClass()
            {
            char_name = "";
            char_gender = CharGend.Unknown;
            char_class = CharacterClass.Unknown;
            char_power = 0;
            char_intel = 0;
            char_def = 0;
            char_health = 0;
            }
        //
        #endregion

        // Methods Fields ---------------- Fields ---------------- 
        #region Methods
        //
        //Character Info
        protected string char_name;
        protected CharGend char_gender;
        protected CharacterClass char_class;

        //Statistics
        protected int char_power;
        protected int char_intel;
        protected int char_def;
        protected int char_health;

        // Modifiers
        protected int power_Mod;
        protected int intel_Mod;
        protected int def_Mod;
        protected int health_Mod;
        //
        #endregion
        }
    }
