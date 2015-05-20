namespace project
{
    partial class todayEvent
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
            this.labelEventsList = new System.Windows.Forms.Label();
            this.textBoxEventsList = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEventsList
            // 
            this.labelEventsList.AutoSize = true;
            this.labelEventsList.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEventsList.Location = new System.Drawing.Point(98, 27);
            this.labelEventsList.Name = "labelEventsList";
            this.labelEventsList.Size = new System.Drawing.Size(295, 27);
            this.labelEventsList.TabIndex = 0;
            this.labelEventsList.Text = "Список событий на сегодня";
            // 
            // textBoxEventsList
            // 
            this.textBoxEventsList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxEventsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEventsList.Location = new System.Drawing.Point(47, 71);
            this.textBoxEventsList.Multiline = true;
            this.textBoxEventsList.Name = "textBoxEventsList";
            this.textBoxEventsList.ReadOnly = true;
            this.textBoxEventsList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxEventsList.Size = new System.Drawing.Size(433, 409);
            this.textBoxEventsList.TabIndex = 1;
            this.textBoxEventsList.Text = "На сегодняшний день нет событий";
            this.textBoxEventsList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(199, 504);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(101, 27);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // todayEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(529, 551);
            this.ControlBox = false;
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxEventsList);
            this.Controls.Add(this.labelEventsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "todayEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сегодняшние события";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEventsList;
        private System.Windows.Forms.TextBox textBoxEventsList;
        private System.Windows.Forms.Button buttonOK;
    }
}