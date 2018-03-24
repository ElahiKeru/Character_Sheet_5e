using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DND_5E_Character_Sheet
{
    public partial class CharacterSheet : Form
    {
        Statistics charStats;
        public CharacterSheet()
        {
            InitializeComponent();
            charStats = new Statistics();
            txtStrScr.Text = "0";
            txtDexScr.Text = "0";
            txtConScr.Text = "0";
            txtIntScr.Text = "0";
            txtWisScr.Text = "0";
            txtChaScr.Text = "0";
        }

        private void AttributeTextChange(object sender, EventArgs e)
        {
            TextBox target = (TextBox)sender;
            
            if(string.IsNullOrEmpty(target.Text))
            {
                target.Text = "0";
            }
            try
            {
                switch(target.Name)
                {
                    case "txtStrScr":
                        charStats.StrengthScore = txtStrScr.Text;
                        charStats.CalculateStrengthMod();
                        txtStrMod.Text = charStats.StrengthMod.ToString();
                        break;
                    case "txtDexScr":
                        charStats.DexterityScore = txtDexScr.Text;
                        charStats.CalculateDexterityMod();
                        txtDexMod.Text = charStats.DexterityMod.ToString();
                        break;
                    case "txtConScr":
                        charStats.ConstitutionScore = txtConScr.Text;
                        charStats.CalculateConstitutionMod();
                        txtConMod.Text = charStats.ConstitutionMod.ToString();
                        break;
                    case "txtIntScr":
                        charStats.IntelligenceScore = txtIntScr.Text;
                        charStats.CalculateIntelligenceMod();
                        txtIntMod.Text = charStats.IntelligenceMod.ToString();
                        break;
                    case "txtWisScr":
                        charStats.WisdomScore = txtWisScr.Text;
                        charStats.CalculateWisdomMod();
                        txtWisMod.Text = charStats.WisdomMod.ToString();
                        break;
                    case "txtChaScr":
                        charStats.CharismaScore = txtChaScr.Text;
                        charStats.CalculateCharismaMod();
                        txtChaMod.Text = charStats.CharismaMod.ToString();
                        break;
                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message, "Problem Converting Score");
                txtStrScr.Text = "0";
            }
        }
    }
}
