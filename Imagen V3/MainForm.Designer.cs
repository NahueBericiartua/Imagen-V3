/*
 * Created by SharpDevelop.
 * User: Nahue
 * Date: 9/10/2021
 * Time: 18:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Imagen_V3
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pic_1;
		private System.Windows.Forms.PictureBox pic_2;
		private System.Windows.Forms.PictureBox pic_3;
		private System.Windows.Forms.PictureBox pic_4;
		private System.Windows.Forms.PictureBox pic_5;
		private System.Windows.Forms.PictureBox pic_centro;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pic_1 = new System.Windows.Forms.PictureBox();
			this.pic_2 = new System.Windows.Forms.PictureBox();
			this.pic_3 = new System.Windows.Forms.PictureBox();
			this.pic_4 = new System.Windows.Forms.PictureBox();
			this.pic_5 = new System.Windows.Forms.PictureBox();
			this.pic_centro = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pic_1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_centro)).BeginInit();
			this.SuspendLayout();
			// 
			// pic_1
			// 
			this.pic_1.Image = ((System.Drawing.Image)(resources.GetObject("pic_1.Image")));
			this.pic_1.Location = new System.Drawing.Point(12, 12);
			this.pic_1.Name = "pic_1";
			this.pic_1.Size = new System.Drawing.Size(79, 70);
			this.pic_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_1.TabIndex = 0;
			this.pic_1.TabStop = false;
			this.pic_1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// pic_2
			// 
			this.pic_2.Image = ((System.Drawing.Image)(resources.GetObject("pic_2.Image")));
			this.pic_2.Location = new System.Drawing.Point(12, 88);
			this.pic_2.Name = "pic_2";
			this.pic_2.Size = new System.Drawing.Size(79, 70);
			this.pic_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_2.TabIndex = 1;
			this.pic_2.TabStop = false;
			this.pic_2.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// pic_3
			// 
			this.pic_3.Image = ((System.Drawing.Image)(resources.GetObject("pic_3.Image")));
			this.pic_3.Location = new System.Drawing.Point(12, 164);
			this.pic_3.Name = "pic_3";
			this.pic_3.Size = new System.Drawing.Size(79, 70);
			this.pic_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_3.TabIndex = 2;
			this.pic_3.TabStop = false;
			this.pic_3.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// pic_4
			// 
			this.pic_4.Image = ((System.Drawing.Image)(resources.GetObject("pic_4.Image")));
			this.pic_4.Location = new System.Drawing.Point(12, 240);
			this.pic_4.Name = "pic_4";
			this.pic_4.Size = new System.Drawing.Size(79, 70);
			this.pic_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_4.TabIndex = 3;
			this.pic_4.TabStop = false;
			this.pic_4.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// pic_5
			// 
			this.pic_5.Image = ((System.Drawing.Image)(resources.GetObject("pic_5.Image")));
			this.pic_5.Location = new System.Drawing.Point(12, 316);
			this.pic_5.Name = "pic_5";
			this.pic_5.Size = new System.Drawing.Size(79, 70);
			this.pic_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_5.TabIndex = 4;
			this.pic_5.TabStop = false;
			this.pic_5.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// pic_centro
			// 
			this.pic_centro.Location = new System.Drawing.Point(97, 12);
			this.pic_centro.Name = "pic_centro";
			this.pic_centro.Size = new System.Drawing.Size(323, 374);
			this.pic_centro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_centro.TabIndex = 5;
			this.pic_centro.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(432, 395);
			this.Controls.Add(this.pic_centro);
			this.Controls.Add(this.pic_5);
			this.Controls.Add(this.pic_4);
			this.Controls.Add(this.pic_3);
			this.Controls.Add(this.pic_2);
			this.Controls.Add(this.pic_1);
			this.Name = "MainForm";
			this.Text = "Imagen V3";
			((System.ComponentModel.ISupportInitialize)(this.pic_1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_centro)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
