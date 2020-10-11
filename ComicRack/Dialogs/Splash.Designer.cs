﻿using cYo.Common.ComponentModel;
using cYo.Common.Net;
using System.ComponentModel;
using System.Threading;

namespace cYo.Projects.ComicRack.Viewer.Dialogs
{
    public partial class Splash
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				base.Surface.SafeDispose();
				initialized.Close();
				components?.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			payPalImage = new cYo.Common.Net.WebImage(components);
			SuspendLayout();
			payPalImage.CheckIntervall = System.TimeSpan.Parse("7.00:00:00");
			payPalImage.Name = "DonateImage";
			payPalImage.Uri = new System.Uri("https://www.paypal.com/en_US/i/btn/x-click-but04.gif", System.UriKind.Absolute);
			payPalImage.ImageLoaded += new System.EventHandler(payPalImage_ImageLoaded);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			base.ClientSize = new System.Drawing.Size(600, 300);
			Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Splash";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			base.TopMost = true;
			ResumeLayout(false);
		}

		private readonly EventWaitHandle initialized = new EventWaitHandle(initialState: false, EventResetMode.ManualReset);

		private IContainer components;

		private WebImage payPalImage;
	}
}
