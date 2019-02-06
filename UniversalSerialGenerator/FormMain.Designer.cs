namespace UniversalSerialGenerator
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pnlTopSeperator = new System.Windows.Forms.Panel();
            this.tbGeneratedSerial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numCharsPerSections = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numSections = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSeperator = new System.Windows.Forms.TextBox();
            this.lblOtherOptions = new System.Windows.Forms.Label();
            this.optOnlyUpperCase = new System.Windows.Forms.RadioButton();
            this.optOnlyLowerCase = new System.Windows.Forms.RadioButton();
            this.btnGen = new System.Windows.Forms.Button();
            this.chkSpecificStart = new System.Windows.Forms.CheckBox();
            this.tbSpecificStart = new System.Windows.Forms.TextBox();
            this.optUpperAndLowerCase = new System.Windows.Forms.RadioButton();
            this.optOnlyNumbers = new System.Windows.Forms.RadioButton();
            this.optOnlyLetters = new System.Windows.Forms.RadioButton();
            this.optLettersAndNumbers = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkSpecificEnd = new System.Windows.Forms.CheckBox();
            this.tbSpecificEnd = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCharsPerSections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSections)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopSeperator
            // 
            this.pnlTopSeperator.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTopSeperator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopSeperator.Location = new System.Drawing.Point(0, 0);
            this.pnlTopSeperator.Name = "pnlTopSeperator";
            this.pnlTopSeperator.Size = new System.Drawing.Size(468, 1);
            this.pnlTopSeperator.TabIndex = 0;
            // 
            // tbGeneratedSerial
            // 
            this.tbGeneratedSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbGeneratedSerial.BackColor = System.Drawing.Color.White;
            this.tbGeneratedSerial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGeneratedSerial.Font = new System.Drawing.Font("Segoe UI Semilight", 12.25F);
            this.tbGeneratedSerial.Location = new System.Drawing.Point(4, 185);
            this.tbGeneratedSerial.MaxLength = 999999999;
            this.tbGeneratedSerial.Name = "tbGeneratedSerial";
            this.tbGeneratedSerial.ReadOnly = true;
            this.tbGeneratedSerial.Size = new System.Drawing.Size(462, 22);
            this.tbGeneratedSerial.TabIndex = 1;
            this.tbGeneratedSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "How many chars per section?";
            // 
            // numCharsPerSections
            // 
            this.numCharsPerSections.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCharsPerSections.BackColor = System.Drawing.Color.White;
            this.numCharsPerSections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numCharsPerSections.Location = new System.Drawing.Point(383, 12);
            this.numCharsPerSections.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numCharsPerSections.Name = "numCharsPerSections";
            this.numCharsPerSections.Size = new System.Drawing.Size(72, 22);
            this.numCharsPerSections.TabIndex = 3;
            this.numCharsPerSections.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCharsPerSections.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "How many sections?";
            // 
            // numSections
            // 
            this.numSections.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numSections.BackColor = System.Drawing.Color.White;
            this.numSections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numSections.Location = new System.Drawing.Point(383, 40);
            this.numSections.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numSections.Name = "numSections";
            this.numSections.Size = new System.Drawing.Size(72, 22);
            this.numSections.TabIndex = 5;
            this.numSections.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSections.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Section seperator? (char)";
            // 
            // tbSeperator
            // 
            this.tbSeperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSeperator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSeperator.Location = new System.Drawing.Point(383, 68);
            this.tbSeperator.MaxLength = 1;
            this.tbSeperator.Name = "tbSeperator";
            this.tbSeperator.Size = new System.Drawing.Size(72, 22);
            this.tbSeperator.TabIndex = 7;
            this.tbSeperator.Text = "-";
            this.tbSeperator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOtherOptions
            // 
            this.lblOtherOptions.AutoSize = true;
            this.lblOtherOptions.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblOtherOptions.Location = new System.Drawing.Point(12, 98);
            this.lblOtherOptions.Name = "lblOtherOptions";
            this.lblOtherOptions.Size = new System.Drawing.Size(98, 19);
            this.lblOtherOptions.TabIndex = 8;
            this.lblOtherOptions.Text = "Other options:";
            // 
            // optOnlyUpperCase
            // 
            this.optOnlyUpperCase.AutoSize = true;
            this.optOnlyUpperCase.Checked = true;
            this.optOnlyUpperCase.Location = new System.Drawing.Point(116, 100);
            this.optOnlyUpperCase.Name = "optOnlyUpperCase";
            this.optOnlyUpperCase.Size = new System.Drawing.Size(105, 17);
            this.optOnlyUpperCase.TabIndex = 9;
            this.optOnlyUpperCase.TabStop = true;
            this.optOnlyUpperCase.Text = "Only uppercase";
            this.optOnlyUpperCase.UseVisualStyleBackColor = true;
            // 
            // optOnlyLowerCase
            // 
            this.optOnlyLowerCase.AutoSize = true;
            this.optOnlyLowerCase.Location = new System.Drawing.Point(223, 100);
            this.optOnlyLowerCase.Name = "optOnlyLowerCase";
            this.optOnlyLowerCase.Size = new System.Drawing.Size(103, 17);
            this.optOnlyLowerCase.TabIndex = 10;
            this.optOnlyLowerCase.Text = "Only lowercase";
            this.optOnlyLowerCase.UseVisualStyleBackColor = true;
            // 
            // btnGen
            // 
            this.btnGen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGen.Location = new System.Drawing.Point(156, 230);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 11;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // chkSpecificStart
            // 
            this.chkSpecificStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkSpecificStart.AutoSize = true;
            this.chkSpecificStart.Location = new System.Drawing.Point(16, 152);
            this.chkSpecificStart.Name = "chkSpecificStart";
            this.chkSpecificStart.Size = new System.Drawing.Size(94, 17);
            this.chkSpecificStart.TabIndex = 12;
            this.chkSpecificStart.Text = "Specific start:";
            this.chkSpecificStart.UseVisualStyleBackColor = true;
            this.chkSpecificStart.CheckedChanged += new System.EventHandler(this.chkSpecificStart_CheckedChanged);
            // 
            // tbSpecificStart
            // 
            this.tbSpecificStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbSpecificStart.Enabled = false;
            this.tbSpecificStart.Location = new System.Drawing.Point(109, 150);
            this.tbSpecificStart.Name = "tbSpecificStart";
            this.tbSpecificStart.Size = new System.Drawing.Size(112, 22);
            this.tbSpecificStart.TabIndex = 13;
            // 
            // optUpperAndLowerCase
            // 
            this.optUpperAndLowerCase.AutoSize = true;
            this.optUpperAndLowerCase.Location = new System.Drawing.Point(332, 100);
            this.optUpperAndLowerCase.Name = "optUpperAndLowerCase";
            this.optUpperAndLowerCase.Size = new System.Drawing.Size(125, 17);
            this.optUpperAndLowerCase.TabIndex = 14;
            this.optUpperAndLowerCase.Text = "Upper && Lowercase";
            this.optUpperAndLowerCase.UseVisualStyleBackColor = true;
            // 
            // optOnlyNumbers
            // 
            this.optOnlyNumbers.AutoSize = true;
            this.optOnlyNumbers.Location = new System.Drawing.Point(126, 0);
            this.optOnlyNumbers.Name = "optOnlyNumbers";
            this.optOnlyNumbers.Size = new System.Drawing.Size(97, 17);
            this.optOnlyNumbers.TabIndex = 15;
            this.optOnlyNumbers.Text = "Only numbers";
            this.optOnlyNumbers.UseVisualStyleBackColor = true;
            this.optOnlyNumbers.CheckedChanged += new System.EventHandler(this.optOnlyNumbers_CheckedChanged);
            // 
            // optOnlyLetters
            // 
            this.optOnlyLetters.AutoSize = true;
            this.optOnlyLetters.Location = new System.Drawing.Point(229, 0);
            this.optOnlyLetters.Name = "optOnlyLetters";
            this.optOnlyLetters.Size = new System.Drawing.Size(84, 17);
            this.optOnlyLetters.TabIndex = 16;
            this.optOnlyLetters.Text = "Only letters";
            this.optOnlyLetters.UseVisualStyleBackColor = true;
            // 
            // optLettersAndNumbers
            // 
            this.optLettersAndNumbers.AutoSize = true;
            this.optLettersAndNumbers.Checked = true;
            this.optLettersAndNumbers.Location = new System.Drawing.Point(0, 0);
            this.optLettersAndNumbers.Name = "optLettersAndNumbers";
            this.optLettersAndNumbers.Size = new System.Drawing.Size(120, 17);
            this.optLettersAndNumbers.TabIndex = 17;
            this.optLettersAndNumbers.TabStop = true;
            this.optLettersAndNumbers.Text = "Letters && Numbers";
            this.optLettersAndNumbers.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.optLettersAndNumbers);
            this.panel1.Controls.Add(this.optOnlyLetters);
            this.panel1.Controls.Add(this.optOnlyNumbers);
            this.panel1.Location = new System.Drawing.Point(116, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 17);
            this.panel1.TabIndex = 18;
            // 
            // chkSpecificEnd
            // 
            this.chkSpecificEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkSpecificEnd.AutoSize = true;
            this.chkSpecificEnd.Location = new System.Drawing.Point(247, 152);
            this.chkSpecificEnd.Name = "chkSpecificEnd";
            this.chkSpecificEnd.Size = new System.Drawing.Size(91, 17);
            this.chkSpecificEnd.TabIndex = 12;
            this.chkSpecificEnd.Text = "Specific end:";
            this.chkSpecificEnd.UseVisualStyleBackColor = true;
            this.chkSpecificEnd.CheckedChanged += new System.EventHandler(this.chkSpecificEnd_CheckedChanged);
            // 
            // tbSpecificEnd
            // 
            this.tbSpecificEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSpecificEnd.Enabled = false;
            this.tbSpecificEnd.Location = new System.Drawing.Point(337, 150);
            this.tbSpecificEnd.Name = "tbSpecificEnd";
            this.tbSpecificEnd.Size = new System.Drawing.Size(112, 22);
            this.tbSpecificEnd.TabIndex = 13;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Location = new System.Drawing.Point(237, 230);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 11;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(468, 277);
            this.Controls.Add(this.optUpperAndLowerCase);
            this.Controls.Add(this.tbSpecificEnd);
            this.Controls.Add(this.chkSpecificEnd);
            this.Controls.Add(this.tbSpecificStart);
            this.Controls.Add(this.chkSpecificStart);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.optOnlyLowerCase);
            this.Controls.Add(this.optOnlyUpperCase);
            this.Controls.Add(this.lblOtherOptions);
            this.Controls.Add(this.tbSeperator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numSections);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numCharsPerSections);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGeneratedSerial);
            this.Controls.Add(this.pnlTopSeperator);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Universal Serial Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCharsPerSections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSections)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopSeperator;
        private System.Windows.Forms.TextBox tbGeneratedSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCharsPerSections;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSections;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSeperator;
        private System.Windows.Forms.Label lblOtherOptions;
        private System.Windows.Forms.RadioButton optOnlyUpperCase;
        private System.Windows.Forms.RadioButton optOnlyLowerCase;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.CheckBox chkSpecificStart;
        private System.Windows.Forms.TextBox tbSpecificStart;
        private System.Windows.Forms.RadioButton optUpperAndLowerCase;
        private System.Windows.Forms.RadioButton optOnlyNumbers;
        private System.Windows.Forms.RadioButton optOnlyLetters;
        private System.Windows.Forms.RadioButton optLettersAndNumbers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkSpecificEnd;
        private System.Windows.Forms.TextBox tbSpecificEnd;
        private System.Windows.Forms.Button btnCopy;
    }
}

