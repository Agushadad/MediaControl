using System;
using Microsoft.Win32;
using System.Windows.Forms;

namespace MediaControl
{
	public partial class Settings : Form
	{
		RegistryKey rk = Registry.CurrentUser.OpenSubKey
				("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
		public Settings()
		{
			InitializeComponent();
			chkStartUp.Checked = (rk.GetValue("MediaControl") != null); ;
		}
		private void SetStartup()
		{			
			if (chkStartUp.Checked)
				rk.SetValue("MediaControl", Application.ExecutablePath);
			else
				rk.DeleteValue("MediaControl", false);

		}
		#region Events
		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btnOk_Click(object sender, EventArgs e)
		{
			SetStartup();
			this.Dispose();
		}
		#endregion
	}
}
