partial class frmMain
{
    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConvertFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFirstZipCode = new System.Windows.Forms.TextBox();
            this.txtSecondZipCode = new System.Windows.Forms.TextBox();
            this.txtFirstCity = new System.Windows.Forms.TextBox();
            this.txtSecondCity = new System.Windows.Forms.TextBox();
            this.txtFirstState = new System.Windows.Forms.TextBox();
            this.txtSecondState = new System.Windows.Forms.TextBox();
            this.txtDistanceInKM = new System.Windows.Forms.TextBox();
            this.txtDistanceInMiles = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Converter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Click the button to convert your text file to binary format.";
            // 
            // btnConvertFile
            // 
            this.btnConvertFile.Location = new System.Drawing.Point(51, 94);
            this.btnConvertFile.Name = "btnConvertFile";
            this.btnConvertFile.Size = new System.Drawing.Size(111, 23);
            this.btnConvertFile.TabIndex = 2;
            this.btnConvertFile.Text = "File Convert";
            this.btnConvertFile.UseVisualStyleBackColor = true;
            this.btnConvertFile.Click += new System.EventHandler(this.btnConvertFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter two zip codes, then click the button below to calculate the distance betwee" +
    "n them.\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Distance Calculator:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Zip Code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(166, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "City:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(386, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "State";
            // 
            // txtFirstZipCode
            // 
            this.txtFirstZipCode.Location = new System.Drawing.Point(28, 235);
            this.txtFirstZipCode.Name = "txtFirstZipCode";
            this.txtFirstZipCode.Size = new System.Drawing.Size(100, 20);
            this.txtFirstZipCode.TabIndex = 8;
            // 
            // txtSecondZipCode
            // 
            this.txtSecondZipCode.Location = new System.Drawing.Point(28, 261);
            this.txtSecondZipCode.Name = "txtSecondZipCode";
            this.txtSecondZipCode.Size = new System.Drawing.Size(100, 20);
            this.txtSecondZipCode.TabIndex = 9;
            // 
            // txtFirstCity
            // 
            this.txtFirstCity.Location = new System.Drawing.Point(169, 235);
            this.txtFirstCity.Name = "txtFirstCity";
            this.txtFirstCity.ReadOnly = true;
            this.txtFirstCity.Size = new System.Drawing.Size(190, 20);
            this.txtFirstCity.TabIndex = 10;
            this.txtFirstCity.TabStop = false;
            // 
            // txtSecondCity
            // 
            this.txtSecondCity.Location = new System.Drawing.Point(169, 260);
            this.txtSecondCity.Name = "txtSecondCity";
            this.txtSecondCity.ReadOnly = true;
            this.txtSecondCity.Size = new System.Drawing.Size(190, 20);
            this.txtSecondCity.TabIndex = 11;
            this.txtSecondCity.TabStop = false;
            // 
            // txtFirstState
            // 
            this.txtFirstState.Location = new System.Drawing.Point(389, 234);
            this.txtFirstState.Name = "txtFirstState";
            this.txtFirstState.ReadOnly = true;
            this.txtFirstState.Size = new System.Drawing.Size(71, 20);
            this.txtFirstState.TabIndex = 12;
            this.txtFirstState.TabStop = false;
            // 
            // txtSecondState
            // 
            this.txtSecondState.Location = new System.Drawing.Point(389, 260);
            this.txtSecondState.Name = "txtSecondState";
            this.txtSecondState.ReadOnly = true;
            this.txtSecondState.Size = new System.Drawing.Size(71, 20);
            this.txtSecondState.TabIndex = 13;
            this.txtSecondState.TabStop = false;
            // 
            // txtDistanceInKM
            // 
            this.txtDistanceInKM.Location = new System.Drawing.Point(389, 305);
            this.txtDistanceInKM.Name = "txtDistanceInKM";
            this.txtDistanceInKM.ReadOnly = true;
            this.txtDistanceInKM.Size = new System.Drawing.Size(71, 20);
            this.txtDistanceInKM.TabIndex = 14;
            this.txtDistanceInKM.TabStop = false;
            // 
            // txtDistanceInMiles
            // 
            this.txtDistanceInMiles.Location = new System.Drawing.Point(389, 331);
            this.txtDistanceInMiles.Name = "txtDistanceInMiles";
            this.txtDistanceInMiles.ReadOnly = true;
            this.txtDistanceInMiles.Size = new System.Drawing.Size(71, 20);
            this.txtDistanceInMiles.TabIndex = 15;
            this.txtDistanceInMiles.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(349, 372);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(324, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "km";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(324, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "miles";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(253, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Distance:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(25, 303);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(111, 23);
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(495, 421);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtDistanceInMiles);
            this.Controls.Add(this.txtDistanceInKM);
            this.Controls.Add(this.txtSecondState);
            this.Controls.Add(this.txtFirstState);
            this.Controls.Add(this.txtSecondCity);
            this.Controls.Add(this.txtFirstCity);
            this.Controls.Add(this.txtSecondZipCode);
            this.Controls.Add(this.txtFirstZipCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConvertFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnConvertFile;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtFirstZipCode;
    private System.Windows.Forms.TextBox txtSecondZipCode;
    private System.Windows.Forms.TextBox txtFirstCity;
    private System.Windows.Forms.TextBox txtSecondCity;
    private System.Windows.Forms.TextBox txtFirstState;
    private System.Windows.Forms.TextBox txtSecondState;
    private System.Windows.Forms.TextBox txtDistanceInKM;
    private System.Windows.Forms.TextBox txtDistanceInMiles;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Button btnCalculate;
}