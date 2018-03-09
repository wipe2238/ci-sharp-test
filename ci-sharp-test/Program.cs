using System;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ci_sharp_test
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			JsonTextReader reader = null;
			reader = default( JsonTextReader );

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new Forms.Main() );
		}
	}
}
