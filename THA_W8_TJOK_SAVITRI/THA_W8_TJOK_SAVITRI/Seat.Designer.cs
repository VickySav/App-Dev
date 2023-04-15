namespace THA_W8_TJOK_SAVITRI
{
    partial class Seat
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonReserve = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelJudul = new System.Windows.Forms.Label();
            this.labelJam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.DimGray;
            this.buttonBack.Location = new System.Drawing.Point(623, 225);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 34);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonReserve
            // 
            this.buttonReserve.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReserve.ForeColor = System.Drawing.Color.DimGray;
            this.buttonReserve.Location = new System.Drawing.Point(623, 265);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(75, 34);
            this.buttonReserve.TabIndex = 31;
            this.buttonReserve.Text = "Reserve";
            this.buttonReserve.UseVisualStyleBackColor = true;
            this.buttonReserve.Click += new System.EventHandler(this.buttonReserve_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.DimGray;
            this.buttonReset.Location = new System.Drawing.Point(623, 305);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 34);
            this.buttonReset.TabIndex = 32;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.ForeColor = System.Drawing.Color.DimGray;
            this.labelJudul.Location = new System.Drawing.Point(561, 152);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(67, 20);
            this.labelJudul.TabIndex = 33;
            this.labelJudul.Text = "JUDUL";
            // 
            // labelJam
            // 
            this.labelJam.AutoSize = true;
            this.labelJam.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJam.ForeColor = System.Drawing.Color.DimGray;
            this.labelJam.Location = new System.Drawing.Point(561, 183);
            this.labelJam.Name = "labelJam";
            this.labelJam.Size = new System.Drawing.Size(46, 20);
            this.labelJam.TabIndex = 34;
            this.labelJam.Text = "JAM";
            // 
            // Seat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(778, 430);
            this.Controls.Add(this.labelJam);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonReserve);
            this.Controls.Add(this.buttonBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Seat";
            this.Text = "Seat";
            this.Load += new System.EventHandler(this.Seat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonReserve;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Label labelJam;
    }
}