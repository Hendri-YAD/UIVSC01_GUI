namespace WindowsFormsApp1
{
    partial class KillARabbit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KillARabbit));
            this.Rabbit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rabbit
            // 
            this.Rabbit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Rabbit.Image = ((System.Drawing.Image)(resources.GetObject("Rabbit.Image")));
            this.Rabbit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Rabbit.Location = new System.Drawing.Point(88, 68);
            this.Rabbit.Name = "Rabbit";
            this.Rabbit.Size = new System.Drawing.Size(240, 221);
            this.Rabbit.TabIndex = 0;
            this.Rabbit.Text = "Rabbit";
            this.Rabbit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Rabbit.UseVisualStyleBackColor = false;
            this.Rabbit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Rabbit_MouseDown);
            this.Rabbit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Rabbit_MouseUp);
            // 
            // KillARabbit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.Rabbit);
            this.Name = "KillARabbit";
            this.Text = "KillARabbit";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Rabbit;
    }
}