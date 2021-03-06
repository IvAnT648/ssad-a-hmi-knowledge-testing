﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Knowledge_Testing;

namespace Knowledge_Testing.Forms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			var loginForm = new AuthForm();
			loginForm.ShowDialog();
			if (!Program.IsLoggedIn()) {
				Application.Exit();
			}
		}
	}
}
