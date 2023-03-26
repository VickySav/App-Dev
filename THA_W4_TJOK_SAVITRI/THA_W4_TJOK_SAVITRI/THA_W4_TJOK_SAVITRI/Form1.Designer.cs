namespace THA_W4_TJOK_SAVITRI
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
            this.btnOpenNextForm = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelFavArtist = new System.Windows.Forms.Label();
            this.textBoxFavArtist = new System.Windows.Forms.TextBox();
            this.checkBoxTheContent = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenNextForm
            // 
            this.btnOpenNextForm.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenNextForm.Location = new System.Drawing.Point(224, 166);
            this.btnOpenNextForm.Name = "btnOpenNextForm";
            this.btnOpenNextForm.Size = new System.Drawing.Size(151, 31);
            this.btnOpenNextForm.TabIndex = 0;
            this.btnOpenNextForm.Text = "Open Next Form";
            this.btnOpenNextForm.UseVisualStyleBackColor = true;
            this.btnOpenNextForm.Click += new System.EventHandler(this.btnOpenNextForm_Click_1);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(47, 38);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(105, 35);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(285, 28);
            this.textBoxName.TabIndex = 2;
            // 
            // labelFavArtist
            // 
            this.labelFavArtist.AutoSize = true;
            this.labelFavArtist.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFavArtist.Location = new System.Drawing.Point(47, 73);
            this.labelFavArtist.Name = "labelFavArtist";
            this.labelFavArtist.Size = new System.Drawing.Size(141, 20);
            this.labelFavArtist.TabIndex = 3;
            this.labelFavArtist.Text = "My Favorite Artist";
            // 
            // textBoxFavArtist
            // 
            this.textBoxFavArtist.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFavArtist.Location = new System.Drawing.Point(197, 68);
            this.textBoxFavArtist.Name = "textBoxFavArtist";
            this.textBoxFavArtist.Size = new System.Drawing.Size(193, 28);
            this.textBoxFavArtist.TabIndex = 4;
            // 
            // checkBoxTheContent
            // 
            this.checkBoxTheContent.AutoSize = true;
            this.checkBoxTheContent.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTheContent.Location = new System.Drawing.Point(81, 119);
            this.checkBoxTheContent.Name = "checkBoxTheContent";
            this.checkBoxTheContent.Size = new System.Drawing.Size(280, 23);
            this.checkBoxTheContent.TabIndex = 6;
            this.checkBoxTheContent.Text = "All of the content I put above is true!";
            this.checkBoxTheContent.UseVisualStyleBackColor = true;
            this.checkBoxTheContent.CheckedChanged += new System.EventHandler(this.checkBoxTheContent_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(81, 166);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 31);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 233);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.checkBoxTheContent);
            this.Controls.Add(this.textBoxFavArtist);
            this.Controls.Add(this.labelFavArtist);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnOpenNextForm);
            this.Name = "Form1";
            this.Text = "Main Windows Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenNextForm;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelFavArtist;
        private System.Windows.Forms.TextBox textBoxFavArtist;
        private System.Windows.Forms.CheckBox checkBoxTheContent;
        private System.Windows.Forms.Button btnSubmit;
    }
}

