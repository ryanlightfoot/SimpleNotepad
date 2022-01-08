using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SimpleNotepad
{
    public partial class Form1 : Form
    {


        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog FontDialog;

        public Form1()
        {
            InitializeComponent();
        }

        float inc = 1;
        float dec = 1;
        float fontSize;
        bool bflag = true;
        //Makes new File
        private void NewFile()
        {

            try
            {
                if (!string.IsNullOrEmpty(this.MaintxtB.Text))
                {
                    
                }
            } 
            catch(Exception ex)
            {

            }
            finally
            {

            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MaintxtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefiledialog1 = new SaveFileDialog();

            savefiledialog1.ShowDialog();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFD = new SaveFileDialog();

            saveFD.Filter = "Text document|*.rtf";
            saveFD.DefaultExt = "*.rtf";
            saveFD.Title = "Save your text document";

            saveFD.ShowDialog();

            if(saveFD.FileName != "")
            {
                FileStream fs = (FileStream)saveFD.OpenFile();

                fs.Close();

                MaintxtB.SaveFile(saveFD.FileName);
            }

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void increaseFontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(bflag == true)
            {
                fontSize = MaintxtB.Font.Size;
                bflag = false;
            }

            fontSize = fontSize + inc;
            MaintxtB.SelectionFont = new Font(Font.FontFamily, fontSize);
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintxtB.BackColor =  ColorTranslator.FromHtml("#000000");
            MaintxtB.ForeColor = ColorTranslator.FromHtml("#E5E5E5");
            mainMenuS.BackColor = ColorTranslator.FromHtml("#14213D");
            mainMenuS.ForeColor = ColorTranslator.FromHtml("#E5E5E5");

        }

        private void decreaseFontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(bflag == true)
            {
                fontSize = MaintxtB.Font.Size;
                bflag = false;
            }

            fontSize = fontSize - dec;
            MaintxtB.SelectionFont = new Font(Font.FontFamily, fontSize);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MaintxtB.Text = File.ReadAllText(openFileDialog1.FileName);
            } 
        }
    }
}
