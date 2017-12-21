namespace Aquarium
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonHugerOn = new System.Windows.Forms.Button();
            this.buttonHungerOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonHugerOn
            // 
            this.buttonHugerOn.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHugerOn.Location = new System.Drawing.Point(868, 30);
            this.buttonHugerOn.Name = "buttonHugerOn";
            this.buttonHugerOn.Size = new System.Drawing.Size(173, 51);
            this.buttonHugerOn.TabIndex = 0;
            this.buttonHugerOn.Text = "Hunger indicator on/off";
            this.buttonHugerOn.UseVisualStyleBackColor = true;
            // 
            // buttonHungerOff
            // 
            this.buttonHungerOff.Location = new System.Drawing.Point(868, 30);
            this.buttonHungerOff.Name = "buttonHungerOff";
            this.buttonHungerOff.Size = new System.Drawing.Size(173, 51);
            this.buttonHungerOff.TabIndex = 1;
            this.buttonHungerOff.Text = "Hunger indicator on/off";
            this.buttonHungerOff.UseVisualStyleBackColor = true;
            this.buttonHungerOff.Click += new System.EventHandler(this.buttonHungerOff_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aquarium.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.buttonHungerOff);
            this.Controls.Add(this.buttonHugerOn);
            this.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aquarium";
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Button buttonHugerOn;
        private System.Windows.Forms.Button buttonHungerOff;
    }
}

