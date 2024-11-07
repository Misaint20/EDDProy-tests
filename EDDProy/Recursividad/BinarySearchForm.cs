﻿using System;
using System.Windows.Forms;

namespace Algoritmos_recursividad
{
    public partial class BinarySearchForm : Form
    {
        public BinarySearchForm()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            int size;
            if (int.TryParse(arreglo.Text, out size))
            {
                ArrayItems arrayItems = new ArrayItems(size);
                arrayItems.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa números válidos.");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
