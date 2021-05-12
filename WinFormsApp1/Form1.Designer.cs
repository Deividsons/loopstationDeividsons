
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.waveViewer1 = new NAudio.Gui.WaveViewer();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1031, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.AccessibleName = "Damn";
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
			this.toolStripMenuItem1.Text = "Open";
			// 
			// waveViewer1
			// 
			this.waveViewer1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.waveViewer1.Location = new System.Drawing.Point(110, 39);
			this.waveViewer1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.waveViewer1.Name = "waveViewer1";
			this.waveViewer1.SamplesPerPixel = 128;
			this.waveViewer1.Size = new System.Drawing.Size(445, 126);
			this.waveViewer1.StartPosition = ((long)(0));
			this.waveViewer1.TabIndex = 1;
			this.waveViewer1.WaveStream = null;
			// 
			// button1 Play
			// 
			this.button1.Location = new System.Drawing.Point(110, 198);
			this.button1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(79, 21);
			this.button1.TabIndex = 2;
			this.button1.Text = "Play";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2 Stop playing/recording
			// 
			this.button2.Location = new System.Drawing.Point(238, 198);
			this.button2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(79, 21);
			this.button2.TabIndex = 3;
			this.button2.Text = "Stop";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 39);
			this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "Filename";
			// 
			// button3 Record
			// 
			this.button3.Location = new System.Drawing.Point(391, 198);
			this.button3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(79, 21);
			this.button3.TabIndex = 5;
			this.button3.Text = "Record";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1031, 538);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.waveViewer1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private NAudio.Gui.WaveViewer waveViewer1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
	}
}

