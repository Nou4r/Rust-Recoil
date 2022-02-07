using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recoil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            weapon_combo_box.SelectedIndex = (int)Program.g_weapon_index;
            barrel_combo_box.SelectedIndex = (int)Program.g_barrel;
            sight_combo_box.SelectedIndex = (int)Program.g_sight;


            weapon_box.Enabled = false;
            attachment_box.Enabled = false;
            humanization_box.Enabled = false;
        }

        private void enabled_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Program.g_enabled = enabled_checkbox.Checked;

            weapon_box.Enabled = enabled_checkbox.Checked;
            attachment_box.Enabled = enabled_checkbox.Checked;
        }

        private void humanization_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Program.g_humanization = humanization_checkbox.Checked;

            if (enabled_checkbox.Checked && humanization_checkbox.Checked)
                humanization_box.Enabled = true;
            else
                humanization_box.Enabled = false;
        }

        private void weapon_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.g_weapon_index = (WeaponIndex)weapon_combo_box.SelectedIndex;
            Data.WeaponColletion[(int)Program.g_weapon_index].Update();
        }

        private void barrel_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.g_barrel = (Barrel)barrel_combo_box.SelectedIndex;
            Data.WeaponColletion[(int)Program.g_weapon_index].Update();
        }

        private void sight_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.g_sight = (Sight)sight_combo_box.SelectedIndex;
            Data.WeaponColletion[(int)Program.g_weapon_index].Update();
        }

        private void sens_numbox_ValueChanged(object sender, EventArgs e)
        {
            Program.g_sensitivity = (float)sens_numbox.Value;
            Data.WeaponColletion[(int)Program.g_weapon_index].Update();
        }

        private void fov_numbox_ValueChanged(object sender, EventArgs e)
        {
            Program.g_field_of_view = (float)fov_numbox.Value;
            Data.WeaponColletion[(int)Program.g_weapon_index].Update();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }
    }
}
