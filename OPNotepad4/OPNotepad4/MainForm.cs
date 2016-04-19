/*
 * Created by SharpDevelop.
 * User: daveho8888
 * Date: 4/18/2016
 * Time: 3:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using EPFramework.Forms;
using MetroFramework.Forms;

namespace OPNotepad4
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : MetroForm
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void SaveToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog()==DialogResult.OK)
			{
				string fileName = saveFileDialog1.FileName;
				string fileCont = txtMain.Text;
				File.WriteAllText(fileName, fileCont);
				MessageBox.Show("The file has been saved.");
			}
		}
		void RandOmStuffToolStripMenuItemClick(object sender, EventArgs e)
		{
	
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = txtMain.Text.Trim();
            int wordCount = 0, index = 0;

            while (index < text.Length)
            {
                // check if current char is part of a word
                while (index < text.Length && Char.IsWhiteSpace(text[index]) == false)
                    index++;

                wordCount++;

                // skip whitespace until next word
                while (index < text.Length && Char.IsWhiteSpace(text[index]) == true)
                    index++;
            }
            MessageBox.Show("There are " + wordCount.ToString() + " words in this file.");
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            System.IO.StreamReader OpenFile = new System.IO.StreamReader(openFileDialog1.FileName);
            txtMain.Text = OpenFile.ReadToEnd();
        }

        private void txtMain_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Paste();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Clear();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtMain.ForeColor = colorDialog1.Color;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            txtMain.Font = fontDialog1.Font;
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            Label label = new Label();
            label.Text = "(c) The WhatCubes Team. Developer Team of omnibean and daveho8888. Other repositories on github.";
            label.Font = new Font("Segoe UI", 20);
            label.Dock = DockStyle.Fill;
            form.Controls.Add(label);
            form.Show();
        }
    }
}
