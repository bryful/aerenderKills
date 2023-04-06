namespace aerenderKills
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			listBox1 = new ListBox();
			btnRescan = new Button();
			btnKill = new Button();
			btnClose = new Button();
			label1 = new Label();
			SuspendLayout();
			// 
			// listBox1
			// 
			listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Location = new Point(12, 38);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(275, 124);
			listBox1.TabIndex = 0;
			// 
			// btnRescan
			// 
			btnRescan.Location = new Point(12, 9);
			btnRescan.Name = "btnRescan";
			btnRescan.Size = new Size(75, 23);
			btnRescan.TabIndex = 1;
			btnRescan.Text = "Rescan";
			btnRescan.UseVisualStyleBackColor = true;
			// 
			// btnKill
			// 
			btnKill.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnKill.Location = new Point(174, 170);
			btnKill.Name = "btnKill";
			btnKill.Size = new Size(113, 23);
			btnKill.TabIndex = 2;
			btnKill.Text = "Kill aerender";
			btnKill.UseVisualStyleBackColor = true;
			// 
			// btnClose
			// 
			btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnClose.Location = new Point(98, 170);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(70, 23);
			btnClose.TabIndex = 3;
			btnClose.Text = "close";
			btnClose.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(99, 13);
			label1.Name = "label1";
			label1.Size = new Size(38, 15);
			label1.TabIndex = 4;
			label1.Text = "label1";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(303, 205);
			Controls.Add(label1);
			Controls.Add(btnClose);
			Controls.Add(btnKill);
			Controls.Add(btnRescan);
			Controls.Add(listBox1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Form1";
			Text = "aerenderKills";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListBox listBox1;
		private Button btnRescan;
		private Button btnKill;
		private Button btnClose;
		private Label label1;
	}
}