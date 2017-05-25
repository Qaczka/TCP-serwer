namespace TCP_serwer
{
    partial class Form1
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
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.adress = new System.Windows.Forms.TextBox();
            this.info_feed = new System.Windows.Forms.ListBox();
            this.port = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.port)).BeginInit();
            this.SuspendLayout();
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(507, 569);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 0;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(123, 569);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 1;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            // 
            // adress
            // 
            this.adress.Location = new System.Drawing.Point(49, 17);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(325, 22);
            this.adress.TabIndex = 2;
            this.adress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // info_feed
            // 
            this.info_feed.FormattingEnabled = true;
            this.info_feed.ItemHeight = 16;
            this.info_feed.Location = new System.Drawing.Point(49, 120);
            this.info_feed.Name = "info_feed";
            this.info_feed.Size = new System.Drawing.Size(756, 404);
            this.info_feed.TabIndex = 3;
            this.info_feed.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(462, 17);
            this.port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(413, 22);
            this.port.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 621);
            this.Controls.Add(this.port);
            this.Controls.Add(this.info_feed);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.start);
            this.Controls.Add(this.stop);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.ListBox info_feed;
        private System.Windows.Forms.NumericUpDown port;
    }
}

