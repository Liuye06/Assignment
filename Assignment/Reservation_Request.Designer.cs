namespace Assignment
{
    partial class Reservation_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation_Main));
            this.btnHall3 = new System.Windows.Forms.Button();
            this.btnHall2 = new System.Windows.Forms.Button();
            this.btnHall1 = new System.Windows.Forms.Button();
            this.lbl_Reservations_Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pb_hall1_p1 = new System.Windows.Forms.PictureBox();
            this.pb_hall2_p1 = new System.Windows.Forms.PictureBox();
            this.pb_hall3_p1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hall1_p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hall2_p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hall3_p1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHall3
            // 
            this.btnHall3.Location = new System.Drawing.Point(138, 572);
            this.btnHall3.Name = "btnHall3";
            this.btnHall3.Size = new System.Drawing.Size(141, 55);
            this.btnHall3.TabIndex = 8;
            this.btnHall3.Text = "Hall 3";
            this.btnHall3.UseVisualStyleBackColor = true;
            this.btnHall3.Click += new System.EventHandler(this.btnHall3_Click);
            // 
            // btnHall2
            // 
            this.btnHall2.Location = new System.Drawing.Point(516, 261);
            this.btnHall2.Name = "btnHall2";
            this.btnHall2.Size = new System.Drawing.Size(141, 55);
            this.btnHall2.TabIndex = 7;
            this.btnHall2.Text = "Hall 2";
            this.btnHall2.UseVisualStyleBackColor = true;
            this.btnHall2.Click += new System.EventHandler(this.btnHall2_Click);
            // 
            // btnHall1
            // 
            this.btnHall1.Location = new System.Drawing.Point(137, 261);
            this.btnHall1.Name = "btnHall1";
            this.btnHall1.Size = new System.Drawing.Size(141, 55);
            this.btnHall1.TabIndex = 6;
            this.btnHall1.Text = "Hall 1";
            this.btnHall1.UseVisualStyleBackColor = true;
            this.btnHall1.Click += new System.EventHandler(this.btnHall1_Click);
            // 
            // lbl_Reservations_Title
            // 
            this.lbl_Reservations_Title.AutoSize = true;
            this.lbl_Reservations_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reservations_Title.Location = new System.Drawing.Point(47, 50);
            this.lbl_Reservations_Title.Name = "lbl_Reservations_Title";
            this.lbl_Reservations_Title.Size = new System.Drawing.Size(160, 31);
            this.lbl_Reservations_Title.TabIndex = 9;
            this.lbl_Reservations_Title.Text = "Reservation";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pb_hall3_p1);
            this.panel1.Controls.Add(this.pb_hall2_p1);
            this.panel1.Controls.Add(this.pb_hall1_p1);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.lbl_Reservations_Title);
            this.panel1.Controls.Add(this.btnHall1);
            this.panel1.Controls.Add(this.btnHall3);
            this.panel1.Controls.Add(this.btnHall2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 702);
            this.panel1.TabIndex = 10;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(0, 0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(67, 38);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "<";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // pb_hall1_p1
            // 
            this.pb_hall1_p1.Image = ((System.Drawing.Image)(resources.GetObject("pb_hall1_p1.Image")));
            this.pb_hall1_p1.Location = new System.Drawing.Point(102, 99);
            this.pb_hall1_p1.Name = "pb_hall1_p1";
            this.pb_hall1_p1.Size = new System.Drawing.Size(217, 142);
            this.pb_hall1_p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_hall1_p1.TabIndex = 11;
            this.pb_hall1_p1.TabStop = false;
            // 
            // pb_hall2_p1
            // 
            this.pb_hall2_p1.Image = ((System.Drawing.Image)(resources.GetObject("pb_hall2_p1.Image")));
            this.pb_hall2_p1.Location = new System.Drawing.Point(474, 99);
            this.pb_hall2_p1.Name = "pb_hall2_p1";
            this.pb_hall2_p1.Size = new System.Drawing.Size(217, 142);
            this.pb_hall2_p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_hall2_p1.TabIndex = 12;
            this.pb_hall2_p1.TabStop = false;
            // 
            // pb_hall3_p1
            // 
            this.pb_hall3_p1.Image = ((System.Drawing.Image)(resources.GetObject("pb_hall3_p1.Image")));
            this.pb_hall3_p1.Location = new System.Drawing.Point(100, 411);
            this.pb_hall3_p1.Name = "pb_hall3_p1";
            this.pb_hall3_p1.Size = new System.Drawing.Size(219, 142);
            this.pb_hall3_p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_hall3_p1.TabIndex = 11;
            this.pb_hall3_p1.TabStop = false;
            // 
            // Reservation_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Reservation_Main";
            this.Text = "Reservation_Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hall1_p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hall2_p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hall3_p1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHall3;
        private System.Windows.Forms.Button btnHall2;
        private System.Windows.Forms.Button btnHall1;
        private System.Windows.Forms.Label lbl_Reservations_Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PictureBox pb_hall1_p1;
        private System.Windows.Forms.PictureBox pb_hall2_p1;
        private System.Windows.Forms.PictureBox pb_hall3_p1;
    }
}