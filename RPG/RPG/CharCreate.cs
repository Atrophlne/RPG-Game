using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RPG.CharClass;

namespace RPG
    {
    public partial class CharCreate : Form
        {
        public CharCreate()
            {
            InitializeComponent();
            }

        private void btn_Save_Click(object sender, EventArgs e)
            {
            // Create a Marksmans obj
       
            // Create a Character
                CharGend cGend;
                CharacterClass cClass;
                string name = txt_name.Text.ToString();
                bool Valid = name.Any(char.IsDigit);
                string gender = (male_btn.Checked ? "Male" : "Female");
                // Name validation
                if (String.IsNullOrEmpty(txt_name.Text) || txt_name.Text[0] == ' ')
                {
                MessageBox.Show("Please name your Character!", "Create Character");
                return;
                }
                // Gender validation
                if (this.male_btn.Checked == false && this.fmale_btn.Checked == false)
                {
                MessageBox.Show("Please select a gender for your Character!", "Create Character");
                return;
                }
                
            // Valid Gendeer
            if(this.male_btn.Checked == true) 
                {
                    cGend = CharGend.Male;
                }
            else 
                {
                    cGend = CharGend.Female;
                }

            if (this.role_slct.Text == "Mage")
            cClass = CharacterClass.Mage;
            else if (this.role_slct.Text == "Marksman")
                cClass = CharacterClass.Marksman;
            else if (this.role_slct.Text == "Assassin")
                cClass = CharacterClass.Assassin;
            else if (this.role_slct.Text == "Fighter")
                cClass = CharacterClass.Fighter;
            else if (this.role_slct.Text == "Support")
                cClass = CharacterClass.Support;
            else if (this.role_slct.Text == "Tank")
                cClass = CharacterClass.Tank;
            else
                {
                MessageBox.Show("Please enter a Class for your character!", "Create Character");
                return;
                }

            Player player = new Player(name, cGend, cClass);
            string Info;
            Info = String.Format("Character Succesfully Created!\n" +
                "Name : {0}\nGender: {1}\nClass: {2}", player.Name, player.Gender.ToString(), player.CharClasses.ToString());
            MessageBox.Show(Info, "Character Create Success!");

            }
        }
    }
