using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace LibraryManagementSystem
{
    public partial class AdminForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public AdminForm()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialRaisedButton1.Enabled = false;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue700, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);
            materialRaisedButton3.Enabled = false;

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialRaisedButton1.Enabled = false;
            materialRaisedButton2.Enabled = true;
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialRaisedButton1.Enabled = true;
            materialRaisedButton2.Enabled = false;
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue700, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);
            materialRaisedButton3.Enabled = false;
            materialRaisedButton4.Enabled = true;
            materialRaisedButton5.Enabled = true;
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
            materialRaisedButton3.Enabled = true;
            materialRaisedButton4.Enabled = false;
            materialRaisedButton5.Enabled = true;
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink600, Primary.Pink700, Primary.Pink200, Accent.Orange100, TextShade.WHITE);
            materialRaisedButton3.Enabled = true;
            materialRaisedButton4.Enabled = true;
            materialRaisedButton5.Enabled = false;
        }
    }
}
