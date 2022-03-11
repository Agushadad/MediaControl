namespace MediaControl
{
	partial class Settings
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
			this.btnOk = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.chkStartUp = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnOk.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnOk.Location = new System.Drawing.Point(23, 41);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 41);
			this.btnOk.TabIndex = 0;
			this.btnOk.Text = "Aceptar";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnExit.Location = new System.Drawing.Point(133, 41);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 41);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "Salir";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// chkStartUp
			// 
			this.chkStartUp.AutoSize = true;
			this.chkStartUp.Location = new System.Drawing.Point(55, 12);
			this.chkStartUp.Name = "chkStartUp";
			this.chkStartUp.Size = new System.Drawing.Size(122, 17);
			this.chkStartUp.TabIndex = 2;
			this.chkStartUp.Text = "Iniciar con Windows";
			this.chkStartUp.UseVisualStyleBackColor = true;
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(226, 94);
			this.Controls.Add(this.chkStartUp);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnOk);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Settings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ajustes";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.CheckBox chkStartUp;
	}
}

