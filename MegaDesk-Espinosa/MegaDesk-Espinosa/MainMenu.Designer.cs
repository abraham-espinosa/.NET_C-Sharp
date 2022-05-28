
namespace MegaDesk_Espinosa
{
    partial class MainMenu
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
            this.AddQuoteButton = new System.Windows.Forms.Button();
            this.ViewQuoteButton = new System.Windows.Forms.Button();
            this.SearchQuoteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddQuoteButton
            // 
            this.AddQuoteButton.Location = new System.Drawing.Point(19, 12);
            this.AddQuoteButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddQuoteButton.Name = "AddQuoteButton";
            this.AddQuoteButton.Size = new System.Drawing.Size(89, 48);
            this.AddQuoteButton.TabIndex = 0;
            this.AddQuoteButton.Text = "Add New Quote";
            this.AddQuoteButton.UseVisualStyleBackColor = true;
            this.AddQuoteButton.Click += new System.EventHandler(this.AddQuoteButton_Click);
            // 
            // ViewQuoteButton
            // 
            this.ViewQuoteButton.Location = new System.Drawing.Point(166, 13);
            this.ViewQuoteButton.Margin = new System.Windows.Forms.Padding(2);
            this.ViewQuoteButton.Name = "ViewQuoteButton";
            this.ViewQuoteButton.Size = new System.Drawing.Size(89, 48);
            this.ViewQuoteButton.TabIndex = 1;
            this.ViewQuoteButton.Text = "View Quotes";
            this.ViewQuoteButton.UseVisualStyleBackColor = true;
            this.ViewQuoteButton.Click += new System.EventHandler(this.ViewQuoteButton_Click);
            // 
            // SearchQuoteButton
            // 
            this.SearchQuoteButton.Location = new System.Drawing.Point(317, 13);
            this.SearchQuoteButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchQuoteButton.Name = "SearchQuoteButton";
            this.SearchQuoteButton.Size = new System.Drawing.Size(89, 48);
            this.SearchQuoteButton.TabIndex = 2;
            this.SearchQuoteButton.Text = "Search Quotes";
            this.SearchQuoteButton.UseVisualStyleBackColor = true;
            this.SearchQuoteButton.Click += new System.EventHandler(this.SearchQuotesButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(461, 11);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(89, 48);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MegaDesk_Espinosa.Properties.Resources.desk_icon;
            this.pictureBox1.Location = new System.Drawing.Point(38, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(585, 461);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchQuoteButton);
            this.Controls.Add(this.ViewQuoteButton);
            this.Controls.Add(this.AddQuoteButton);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddQuoteButton;
        private System.Windows.Forms.Button ViewQuoteButton;
        private System.Windows.Forms.Button SearchQuoteButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

