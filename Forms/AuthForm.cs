using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knowledge_Testing.Forms
{
	public partial class AuthForm : Form
	{
		public AuthForm()
		{
			InitializeComponent();
		}

		private void buttonEnter_Click(object sender, EventArgs e)
		{
			if (login()) {
				Close();
			} else {
				MessageBox.Show("Неверный логин или пароль!", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool login()
		{
			return false;
		}
	}
}
