namespace WindowsFormsApp1
{
    partial class CatchAGenie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatchAGenie));
            this.Genie = new System.Windows.Forms.PictureBox();
            this.Lamp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Genie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lamp)).BeginInit();
            this.SuspendLayout();
            // 
            // Genie
            // 
            this.Genie.Image = ((System.Drawing.Image)(resources.GetObject("Genie.Image")));
            this.Genie.Location = new System.Drawing.Point(218, 132);
            this.Genie.Name = "Genie";
            this.Genie.Size = new System.Drawing.Size(100, 50);
            this.Genie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Genie.TabIndex = 0;
            this.Genie.TabStop = false;
            this.Genie.Visible = false;
            this.Genie.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Genie_MouseMove);
            // 
            // Lamp
            // 
            this.Lamp.Image = ((System.Drawing.Image)(resources.GetObject("Lamp.Image")));
            this.Lamp.Location = new System.Drawing.Point(120, 188);
            this.Lamp.Name = "Lamp";
            this.Lamp.Size = new System.Drawing.Size(102, 67);
            this.Lamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lamp.TabIndex = 1;
            this.Lamp.TabStop = false;
            this.Lamp.Click += new System.EventHandler(this.Lamp_Click);
            this.Lamp.DoubleClick += new System.EventHandler(this.Lamp_DoubleClick);
            // 
            // CatchAGenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 388);
            this.Controls.Add(this.Lamp);
            this.Controls.Add(this.Genie);
            this.Name = "CatchAGenie";
            this.Text = "CatchAGenie";
            ((System.ComponentModel.ISupportInitialize)(this.Genie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lamp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Genie;
        private System.Windows.Forms.PictureBox Lamp;
    }
}