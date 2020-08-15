using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WRD_Sploit
{
    public partial class Form2 : Form
    {
        EasyExploits.Module module = new EasyExploits.Module();
        public Form2()
        {
            InitializeComponent();
        }

        private void flatButton4_Click(object sender, EventArgs e)
        {
            module.LaunchExploit();
        }

        private void flatButton5_Click(object sender, EventArgs e)
        {
            module.LaunchExploit();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            module.ExecuteScript(fastColoredTextBox1.Text);
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            //made by ijsbeer :)
            OpenFileDialog opendialogfile = new OpenFileDialog();
            opendialogfile.Filter = "Lua File (*.lua)|*.lua|Text File (*.txt)|*.txt";
            opendialogfile.FilterIndex = 2;
            opendialogfile.RestoreDirectory = true;
            if (opendialogfile.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                fastColoredTextBox1.Text = "";
                System.IO.Stream stream;
                if ((stream = opendialogfile.OpenFile()) == null)
                    return;
                using (stream)
                    this.fastColoredTextBox1.Text = System.IO.File.ReadAllText(opendialogfile.FileName);
            }
            catch (Exception)
            {
                int num = (int)MessageBox.Show("An unexpected error has occured", "OOF!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void flatButton6_Click(object sender, EventArgs e)
        {
            module.LaunchExploit();
        }

        private void flatButton7_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = (Color.Red);
            formSkin1.Refresh();
        }

        private void flatButton8_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = (Color.Blue);
            formSkin1.Refresh();
        }

        private void flatButton9_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = (Color.Gray);
            formSkin1.Refresh();
        }

        private void flatButton10_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = (Color.Purple);
            formSkin1.Refresh();
        }

        private void flatButton11_Click(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void flatButton12_Click(object sender, EventArgs e)
        {
            TopMost = false;
        }

        private void flatButton13_Click(object sender, EventArgs e)
        {
            Process[] roblox = Process.GetProcesses();

            foreach (Process openedroblox in roblox)

            {

                bool flag = openedroblox.ProcessName == "RobloxPlayerBeta";

                if (flag)

                {

                    openedroblox.Kill();

                }

            }
        }

        private void flatButton14_Click(object sender, EventArgs e)
        {
            Process[] roblox = Process.GetProcesses();

            foreach (Process openedroblox in roblox)

            {

                bool flag = openedroblox.ProcessName == "RobloxPlayerBeta";

                if (flag)

                {

                    openedroblox.Kill();

                }

            }
        }

        private void flatButton15_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.lua");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = File.ReadAllText($"./Scripts/{listBox1.SelectedItem}");
        }

        private void flatButton16_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = (Color.LightGreen);
            formSkin1.Refresh();
        }

        private void flatButton17_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Txt Files (*.txt)|*.txt|Lua Files (*.lua)|*.lua|All Files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream s = sfd.OpenFile();
                StreamWriter sw = new StreamWriter(s);
                sw.Write(fastColoredTextBox1.Text);
                sw.Close();
            }
        }

        private void flatButton18_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = (Color.Orange);
            formSkin1.Refresh();
        }

        private void flatButton19_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = (Color.Yellow);
            formSkin1.Refresh();
        }
    }
}
