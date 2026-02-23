namespace ByteETA.UI
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFile = new Label();
            lblInternet = new Label();
            nupInternetSpeed = new NumericUpDown();
            nupFileSize = new NumericUpDown();
            cbFileUnit = new ComboBox();
            cbInternetUnit = new ComboBox();
            lblFileSize = new Label();
            lblInternetSpeed = new Label();
            lblFileUnit = new Label();
            lblInternetUnit = new Label();
            btnCalculate = new Button();
            ((System.ComponentModel.ISupportInitialize)nupInternetSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupFileSize).BeginInit();
            SuspendLayout();
            // 
            // lblFile
            // 
            lblFile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblFile.AutoSize = true;
            lblFile.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFile.Location = new Point(35, 80);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(41, 20);
            lblFile.TabIndex = 2;
            lblFile.Text = "FILE";
            // 
            // lblInternet
            // 
            lblInternet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblInternet.AutoSize = true;
            lblInternet.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInternet.Location = new Point(35, 150);
            lblInternet.Name = "lblInternet";
            lblInternet.Size = new Size(86, 20);
            lblInternet.TabIndex = 4;
            lblInternet.Text = "INTERNET";
            // 
            // nupInternetSpeed
            // 
            nupInternetSpeed.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nupInternetSpeed.Location = new Point(160, 150);
            nupInternetSpeed.Name = "nupInternetSpeed";
            nupInternetSpeed.Size = new Size(100, 23);
            nupInternetSpeed.TabIndex = 6;
            // 
            // nupFileSize
            // 
            nupFileSize.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nupFileSize.Location = new Point(160, 80);
            nupFileSize.Name = "nupFileSize";
            nupFileSize.Size = new Size(100, 23);
            nupFileSize.TabIndex = 7;
            // 
            // cbFileUnit
            // 
            cbFileUnit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbFileUnit.FormattingEnabled = true;
            cbFileUnit.Location = new Point(275, 80);
            cbFileUnit.Name = "cbFileUnit";
            cbFileUnit.Size = new Size(121, 23);
            cbFileUnit.TabIndex = 8;
            // 
            // cbInternetUnit
            // 
            cbInternetUnit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbInternetUnit.FormattingEnabled = true;
            cbInternetUnit.Location = new Point(275, 150);
            cbInternetUnit.Name = "cbInternetUnit";
            cbInternetUnit.Size = new Size(121, 23);
            cbInternetUnit.TabIndex = 9;
            // 
            // lblFileSize
            // 
            lblFileSize.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblFileSize.AutoSize = true;
            lblFileSize.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFileSize.Location = new Point(192, 50);
            lblFileSize.Name = "lblFileSize";
            lblFileSize.Size = new Size(35, 17);
            lblFileSize.TabIndex = 10;
            lblFileSize.Text = "SIZE";
            // 
            // lblInternetSpeed
            // 
            lblInternetSpeed.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblInternetSpeed.AutoSize = true;
            lblInternetSpeed.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInternetSpeed.Location = new Point(186, 120);
            lblInternetSpeed.Name = "lblInternetSpeed";
            lblInternetSpeed.Size = new Size(48, 17);
            lblInternetSpeed.TabIndex = 11;
            lblInternetSpeed.Text = "SPEED";
            // 
            // lblFileUnit
            // 
            lblFileUnit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblFileUnit.AutoSize = true;
            lblFileUnit.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFileUnit.Location = new Point(315, 50);
            lblFileUnit.Name = "lblFileUnit";
            lblFileUnit.Size = new Size(41, 17);
            lblFileUnit.TabIndex = 12;
            lblFileUnit.Text = "UNIT";
            // 
            // lblInternetUnit
            // 
            lblInternetUnit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblInternetUnit.AutoSize = true;
            lblInternetUnit.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInternetUnit.Location = new Point(315, 120);
            lblInternetUnit.Name = "lblInternetUnit";
            lblInternetUnit.Size = new Size(41, 17);
            lblInternetUnit.TabIndex = 13;
            lblInternetUnit.Text = "UNIT";
            // 
            // btnCalculate
            // 
            btnCalculate.AutoSize = true;
            btnCalculate.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(175, 220);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(90, 27);
            btnCalculate.TabIndex = 14;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 291);
            Controls.Add(btnCalculate);
            Controls.Add(lblInternetUnit);
            Controls.Add(lblFileUnit);
            Controls.Add(lblInternetSpeed);
            Controls.Add(lblFileSize);
            Controls.Add(cbInternetUnit);
            Controls.Add(cbFileUnit);
            Controls.Add(nupFileSize);
            Controls.Add(nupInternetSpeed);
            Controls.Add(lblInternet);
            Controls.Add(lblFile);
            Name = "Form";
            Text = "Download Time Calculator";
            Load += Form_Load;
            ((System.ComponentModel.ISupportInitialize)nupInternetSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupFileSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFile;
        private Label lblInternet;
        private NumericUpDown nupInternetSpeed;
        private NumericUpDown nupFileSize;
        private ComboBox cbFileUnit;
        private ComboBox cbInternetUnit;
        private Label lblFileSize;
        private Label lblInternetSpeed;
        private Label lblFileUnit;
        private Label lblInternetUnit;
        private Button btnCalculate;
    }
}
