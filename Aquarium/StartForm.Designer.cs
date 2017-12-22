namespace Aquarium
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.StartGameButton = new System.Windows.Forms.Button();
            this.AuthorsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartGameButton
            // 
            this.StartGameButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StartGameButton.Font = new System.Drawing.Font("Super Mario 286(RUS BY LYAJKA)", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGameButton.Location = new System.Drawing.Point(267, 136);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(263, 62);
            this.StartGameButton.TabIndex = 0;
            this.StartGameButton.Text = "Start Game";
            this.StartGameButton.UseVisualStyleBackColor = false;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // AuthorsButton
            // 
            this.AuthorsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AuthorsButton.Font = new System.Drawing.Font("Super Mario 286(RUS BY LYAJKA)", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorsButton.Location = new System.Drawing.Point(267, 229);
            this.AuthorsButton.Name = "AuthorsButton";
            this.AuthorsButton.Size = new System.Drawing.Size(263, 62);
            this.AuthorsButton.TabIndex = 1;
            this.AuthorsButton.Text = "Authors";
            this.AuthorsButton.UseVisualStyleBackColor = false;
            this.AuthorsButton.Click += new System.EventHandler(this.AuthorsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitButton.Font = new System.Drawing.Font("Super Mario 286(RUS BY LYAJKA)", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(267, 317);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(263, 62);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartForm
            // 
            this.BackgroundImage = global::Aquarium.Properties.Resources.background_startForm;
            this.ClientSize = new System.Drawing.Size(784, 601);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AuthorsButton);
            this.Controls.Add(this.StartGameButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 640);
            this.MinimumSize = new System.Drawing.Size(800, 640);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aquaruim";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Button AuthorsButton;
        private System.Windows.Forms.Button ExitButton;
    }
}