namespace pizzaaaa
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
            this.button1 = new System.Windows.Forms.Button();
            this.inputLabel = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.outPut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputLabel
            // 
            this.inputLabel.Location = new System.Drawing.Point(178, 53);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(113, 20);
            this.inputLabel.TabIndex = 1;
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(33, 228);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 20);
            this.outputLabel.TabIndex = 2;
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(33, 53);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(139, 27);
            this.label.TabIndex = 3;
            this.label.Text = "Number of toppings";
            // 
            // outPut
            // 
            this.outPut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outPut.Location = new System.Drawing.Point(43, 192);
            this.outPut.Name = "outPut";
            this.outPut.Size = new System.Drawing.Size(221, 56);
            this.outPut.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(328, 286);
            this.Controls.Add(this.outPut);
            this.Controls.Add(this.label);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputLabel;
        private System.Windows.Forms.TextBox outputLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label outPut;
    }
}

