namespace MoladWithSearch
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnSearchJewish = new System.Windows.Forms.Button();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtMolad = new System.Windows.Forms.TextBox();
            this.btnSearchEnglish = new System.Windows.Forms.Button();
            this.btnCurrent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(442, 236);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(301, 84);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(48, 236);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(301, 84);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click_1);
            // 
            // btnSearchJewish
            // 
            this.btnSearchJewish.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchJewish.Location = new System.Drawing.Point(48, 339);
            this.btnSearchJewish.Name = "btnSearchJewish";
            this.btnSearchJewish.Size = new System.Drawing.Size(301, 80);
            this.btnSearchJewish.TabIndex = 2;
            this.btnSearchJewish.Text = "Jewish Search";
            this.btnSearchJewish.UseVisualStyleBackColor = true;
            this.btnSearchJewish.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtMonth
            // 
            this.txtMonth.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonth.Location = new System.Drawing.Point(226, 39);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.ReadOnly = true;
            this.txtMonth.Size = new System.Drawing.Size(651, 50);
            this.txtMonth.TabIndex = 3;
            this.txtMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMolad
            // 
            this.txtMolad.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMolad.Location = new System.Drawing.Point(48, 147);
            this.txtMolad.Name = "txtMolad";
            this.txtMolad.ReadOnly = true;
            this.txtMolad.Size = new System.Drawing.Size(1006, 50);
            this.txtMolad.TabIndex = 4;
            this.txtMolad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearchEnglish
            // 
            this.btnSearchEnglish.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEnglish.Location = new System.Drawing.Point(442, 339);
            this.btnSearchEnglish.Name = "btnSearchEnglish";
            this.btnSearchEnglish.Size = new System.Drawing.Size(301, 80);
            this.btnSearchEnglish.TabIndex = 5;
            this.btnSearchEnglish.Text = "English Search";
            this.btnSearchEnglish.UseVisualStyleBackColor = true;
            this.btnSearchEnglish.Click += new System.EventHandler(this.btnSearchEnglish_Click);
            // 
            // btnCurrent
            // 
            this.btnCurrent.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Italic);
            this.btnCurrent.Location = new System.Drawing.Point(821, 236);
            this.btnCurrent.Name = "btnCurrent";
            this.btnCurrent.Size = new System.Drawing.Size(233, 183);
            this.btnCurrent.TabIndex = 6;
            this.btnCurrent.Text = "Current Molad";
            this.btnCurrent.UseVisualStyleBackColor = true;
            this.btnCurrent.Click += new System.EventHandler(this.btnCurrent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 450);
            this.Controls.Add(this.btnCurrent);
            this.Controls.Add(this.btnSearchEnglish);
            this.Controls.Add(this.txtMolad);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.btnSearchJewish);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnSearchJewish;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtMolad;
        private System.Windows.Forms.Button btnSearchEnglish;
        private System.Windows.Forms.Button btnCurrent;
    }
}

