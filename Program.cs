using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MediaControl
{
	internal static class Program
	{
		#region Atributes
		public static bool isPlaying = false;
		#endregion
		/// <summary>
		/// Punto de entrada principal para la aplicación.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			#region Menu
			ContextMenu contextMenu = new ContextMenu();
			MenuItem contextItemSettings = new MenuItem();
			MenuItem contextItemExit = new MenuItem();
			contextItemSettings.Text = "&Ajustes";
			contextItemExit.Text = "&Salir";
			contextMenu.MenuItems.Add(contextItemSettings);
			contextMenu.MenuItems.Add(contextItemExit);
			#endregion

			#region Icons
			//Creacion Iconos
			NotifyIcon fowardIcon = new NotifyIcon();
			fowardIcon.Text = "Avanzar";
			fowardIcon.Icon = new Icon(@"../../Images/foward.ico");
			fowardIcon.Visible = true;

			NotifyIcon playIcon = new NotifyIcon();
			playIcon.Text = "Reproducir/Pausar";
			playIcon.Icon = new Icon(@"../../Images/play.ico");
			playIcon.Visible = true;
			playIcon.ContextMenu = contextMenu;

			NotifyIcon previousIcon = new NotifyIcon();
			previousIcon.Text = "Retroceder";
			previousIcon.Icon = new Icon(@"../../Images/previous.ico");
			previousIcon.Visible = true;

			NotifyIcon muteIcon = new NotifyIcon();
			muteIcon.Text = "Silenciar";
			muteIcon.Icon = new Icon(@"../../Images/mute.ico");
			muteIcon.Visible = true;

			NotifyIcon volumeUpIcon = new NotifyIcon();
			volumeUpIcon.Text = "Subir volumen";
			volumeUpIcon.Icon = new Icon(@"../../Images/volumeUp.ico");
			volumeUpIcon.Visible = true;

			NotifyIcon volumeDownIcon = new NotifyIcon();
			volumeDownIcon.Text = "Bajar volumen";
			volumeDownIcon.Icon = new Icon(@"../../Images/volumeDown.ico");
			volumeDownIcon.Visible = true;
			#endregion

			#region	Events	
			playIcon.MouseClick += new MouseEventHandler(PlayIcon_Click);
			fowardIcon.MouseClick += new MouseEventHandler(FowardIcon_Click);
			previousIcon.MouseClick += new MouseEventHandler(PreviousIcon_Click);
			muteIcon.MouseClick += new MouseEventHandler(MuteIcon_Click);
			volumeUpIcon.MouseClick += new MouseEventHandler(VolumeUpIcon_Click);
			volumeDownIcon.MouseClick += new MouseEventHandler(VolumeDownIcon_Click);
			contextItemSettings.Click += new EventHandler(contextMenuSettings_Click);
			contextItemExit.Click += new EventHandler(contextMenuExit_Click);
			#endregion
			Application.Run();
		}
		#region Voids
		private static void VolumeDownIcon_Click(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				SendKey(VirtualKeyCodes.VOLUME_DOWN);
		}
		private static void VolumeUpIcon_Click(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				SendKey(VirtualKeyCodes.VOLUME_UP);
		}
		private static void MuteIcon_Click(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				SendKey(VirtualKeyCodes.VOLUME_MUTE);
		}
		private static void PreviousIcon_Click(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				SendKey(VirtualKeyCodes.PREVIOUS);
		}
		private static void FowardIcon_Click(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				SendKey(VirtualKeyCodes.FOWARD);
		}
		private static void PlayIcon_Click(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				SendKey(VirtualKeyCodes.PLAY_PAUSE);
		}
		internal static void SendKey(VirtualKeyCodes virtualKeyCode)
		{
			keybd_event((uint)virtualKeyCode, 0, 0, 0);
		}
		private static void contextMenuExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private static void contextMenuSettings_Click(object sender, EventArgs e)
		{
			Form settings = new Settings();
			settings.ShowDialog();
		}

		[DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
		internal static extern void keybd_event(uint bVk, uint bScan, uint dwFlags, uint dwExtraInfo);
		#endregion
		internal enum VirtualKeyCodes
		: uint
		{
			VOLUME_MUTE = 0xAD,
			VOLUME_DOWN = 0xAE,
			VOLUME_UP = 0xAF,
			FOWARD = 0xB0,
			PREVIOUS = 0xB1,
			STOP = 0xB2,
			PLAY_PAUSE = 0xB3,
		}
	}
}
