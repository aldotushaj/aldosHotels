﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klProject
{
    public partial class FormLogin : Form
    {

        private bool isDragging = false;
        private Point lastMousePosition;
        public FormLogin()
        {
            InitializeComponent();
            this.MouseDown += MainForm_MouseDown;
            this.MouseMove += MainForm_MouseMove;
            this.MouseUp += MainForm_MouseUp;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastMousePosition = e.Location;
            }
        }

        // Mouse Move Event: Moves the form as the mouse is dragged
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Calculate the movement difference
                var diff = new Point(e.X - lastMousePosition.X, e.Y - lastMousePosition.Y);

                // Move the form by the difference
                this.Location = new Point(this.Left + diff.X, this.Top + diff.Y);
            }
        }

        // Mouse Up Event: Releases the drag
        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}