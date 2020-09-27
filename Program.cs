using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Knowledge_Testing.Forms;
using Knowledge_Testing.Models;

namespace Knowledge_Testing
{
	static class Program
	{
		public static User User = new User();

		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}

		public static bool IsLoggedIn()
		{
			return User.Exists();
		}
	}
}
