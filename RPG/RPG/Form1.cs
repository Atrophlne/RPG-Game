using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RPG
    {
    public partial class Rpg_Menu : Form
        {
        public Rpg_Menu()
            {
            InitializeComponent();
            }

        private void ctm_char_btn_Click(object sender, EventArgs e)
            {
            CharCreate charcreate = new CharCreate();
            charcreate.Show();
            }
        }
    }
