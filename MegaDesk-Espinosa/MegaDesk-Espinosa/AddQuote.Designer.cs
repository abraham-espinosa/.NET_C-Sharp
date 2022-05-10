
namespace MegaDesk_Espinosa
{
    partial class AddQuote
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customer_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.TextBox();
            this.depth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.drawer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.surface_material = new System.Windows.Forms.ComboBox();
            this.rush_days = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SubmitOrderButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 657);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full name:";
            // 
            // customer_name
            // 
            this.customer_name.Location = new System.Drawing.Point(66, 175);
            this.customer_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(182, 26);
            this.customer_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(348, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width of desk:";
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(352, 175);
            this.width.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(182, 26);
            this.width.TabIndex = 4;
            this.width.Validating += new System.ComponentModel.CancelEventHandler(this.width_Validating);
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(630, 175);
            this.depth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(182, 26);
            this.depth.TabIndex = 6;
            this.depth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depth_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(626, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Depth of desk:";
            // 
            // drawer
            // 
            this.drawer.FormattingEnabled = true;
            this.drawer.Location = new System.Drawing.Point(66, 292);
            this.drawer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drawer.Name = "drawer";
            this.drawer.Size = new System.Drawing.Size(182, 28);
            this.drawer.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(64, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number of drawer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(348, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Material type:";
            // 
            // surface_material
            // 
            this.surface_material.FormattingEnabled = true;
            this.surface_material.Location = new System.Drawing.Point(352, 292);
            this.surface_material.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.surface_material.Name = "surface_material";
            this.surface_material.Size = new System.Drawing.Size(182, 28);
            this.surface_material.TabIndex = 9;
            // 
            // rush_days
            // 
            this.rush_days.FormattingEnabled = true;
            this.rush_days.Location = new System.Drawing.Point(630, 292);
            this.rush_days.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rush_days.Name = "rush_days";
            this.rush_days.Size = new System.Drawing.Size(182, 28);
            this.rush_days.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(626, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Order processing time:";
            // 
            // SubmitOrderButton
            // 
            this.SubmitOrderButton.Location = new System.Drawing.Point(330, 455);
            this.SubmitOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubmitOrderButton.Name = "SubmitOrderButton";
            this.SubmitOrderButton.Size = new System.Drawing.Size(225, 98);
            this.SubmitOrderButton.TabIndex = 13;
            this.SubmitOrderButton.Text = "Submit Order";
            this.SubmitOrderButton.UseVisualStyleBackColor = true;
            this.SubmitOrderButton.Click += new System.EventHandler(this.SubmitOrderButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(66, 49);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(44, 20);
            this.dateLabel.TabIndex = 14;
            this.dateLabel.Text = "Date";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(885, 720);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.SubmitOrderButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rush_days);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.surface_material);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.drawer);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.width);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customer_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customer_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox drawer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox surface_material;
        private System.Windows.Forms.ComboBox rush_days;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SubmitOrderButton;
        private System.Windows.Forms.Label dateLabel;
    }
}