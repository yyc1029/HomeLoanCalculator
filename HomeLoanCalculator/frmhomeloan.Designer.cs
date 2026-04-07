namespace HomeLoanCalculator
{
    partial class frmhomeloan
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGP = new System.Windows.Forms.TextBox();
            this.txtLT = new System.Windows.Forms.TextBox();
            this.txtAIR = new System.Windows.Forms.TextBox();
            this.txtIDP = new System.Windows.Forms.TextBox();
            this.txtTHP = new System.Windows.Forms.TextBox();
            this.lblGP = new System.Windows.Forms.Label();
            this.lblLT = new System.Windows.Forms.Label();
            this.lblAIR = new System.Windows.Forms.Label();
            this.lblDP = new System.Windows.Forms.Label();
            this.lblTHP = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTAPMResult = new System.Windows.Forms.Label();
            this.lblTAPM = new System.Windows.Forms.Label();
            this.lblTPAResult = new System.Windows.Forms.Label();
            this.lblTIEResult = new System.Windows.Forms.Label();
            this.lblFIIResult = new System.Windows.Forms.Label();
            this.lblFIPResult = new System.Windows.Forms.Label();
            this.lblMPAIResult = new System.Windows.Forms.Label();
            this.lblMPAPResult = new System.Windows.Forms.Label();
            this.lblTotalResult = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTPA = new System.Windows.Forms.Label();
            this.lblTIE = new System.Windows.Forms.Label();
            this.lblFIP = new System.Windows.Forms.Label();
            this.lblFII = new System.Windows.Forms.Label();
            this.lblMPAI = new System.Windows.Forms.Label();
            this.lblMPAP = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btncount = new System.Windows.Forms.Button();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.grpInput.Controls.Add(this.label5);
            this.grpInput.Controls.Add(this.label4);
            this.grpInput.Controls.Add(this.label3);
            this.grpInput.Controls.Add(this.label2);
            this.grpInput.Controls.Add(this.label1);
            this.grpInput.Controls.Add(this.txtGP);
            this.grpInput.Controls.Add(this.txtLT);
            this.grpInput.Controls.Add(this.txtAIR);
            this.grpInput.Controls.Add(this.txtIDP);
            this.grpInput.Controls.Add(this.txtTHP);
            this.grpInput.Controls.Add(this.lblGP);
            this.grpInput.Controls.Add(this.lblLT);
            this.grpInput.Controls.Add(this.lblAIR);
            this.grpInput.Controls.Add(this.lblDP);
            this.grpInput.Controls.Add(this.lblTHP);
            this.grpInput.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.grpInput.Location = new System.Drawing.Point(26, 12);
            this.grpInput.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grpInput.Name = "grpInput";
            this.grpInput.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grpInput.Size = new System.Drawing.Size(483, 456);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "貸款參數設定";
            this.grpInput.Enter += new System.EventHandler(this.grpInput_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 34);
            this.label5.TabIndex = 14;
            this.label5.Text = "年";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 34);
            this.label4.TabIndex = 13;
            this.label4.Text = "年";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 34);
            this.label3.TabIndex = 12;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 34);
            this.label2.TabIndex = 11;
            this.label2.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "元";
            // 
            // txtGP
            // 
            this.txtGP.Location = new System.Drawing.Point(204, 324);
            this.txtGP.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtGP.Name = "txtGP";
            this.txtGP.Size = new System.Drawing.Size(199, 43);
            this.txtGP.TabIndex = 4;
            this.txtGP.Text = "0";
            this.txtGP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLT
            // 
            this.txtLT.Location = new System.Drawing.Point(204, 264);
            this.txtLT.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtLT.Name = "txtLT";
            this.txtLT.Size = new System.Drawing.Size(199, 43);
            this.txtLT.TabIndex = 3;
            this.txtLT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAIR
            // 
            this.txtAIR.Location = new System.Drawing.Point(204, 204);
            this.txtAIR.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtAIR.Name = "txtAIR";
            this.txtAIR.Size = new System.Drawing.Size(199, 43);
            this.txtAIR.TabIndex = 2;
            this.txtAIR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIDP
            // 
            this.txtIDP.Location = new System.Drawing.Point(204, 144);
            this.txtIDP.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtIDP.Name = "txtIDP";
            this.txtIDP.Size = new System.Drawing.Size(199, 43);
            this.txtIDP.TabIndex = 1;
            this.txtIDP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTHP
            // 
            this.txtTHP.Location = new System.Drawing.Point(204, 84);
            this.txtTHP.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtTHP.Name = "txtTHP";
            this.txtTHP.Size = new System.Drawing.Size(199, 43);
            this.txtTHP.TabIndex = 0;
            this.txtTHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGP
            // 
            this.lblGP.AutoSize = true;
            this.lblGP.Location = new System.Drawing.Point(24, 326);
            this.lblGP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGP.Name = "lblGP";
            this.lblGP.Size = new System.Drawing.Size(96, 34);
            this.lblGP.TabIndex = 4;
            this.lblGP.Text = "寬限期";
            // 
            // lblLT
            // 
            this.lblLT.AutoSize = true;
            this.lblLT.Location = new System.Drawing.Point(24, 266);
            this.lblLT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLT.Name = "lblLT";
            this.lblLT.Size = new System.Drawing.Size(123, 34);
            this.lblLT.TabIndex = 3;
            this.lblLT.Text = "貸款年限";
            // 
            // lblAIR
            // 
            this.lblAIR.AutoSize = true;
            this.lblAIR.Location = new System.Drawing.Point(24, 206);
            this.lblAIR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAIR.Name = "lblAIR";
            this.lblAIR.Size = new System.Drawing.Size(123, 34);
            this.lblAIR.TabIndex = 2;
            this.lblAIR.Text = "貸款利率";
            // 
            // lblDP
            // 
            this.lblDP.AutoSize = true;
            this.lblDP.Location = new System.Drawing.Point(24, 152);
            this.lblDP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDP.Name = "lblDP";
            this.lblDP.Size = new System.Drawing.Size(150, 34);
            this.lblDP.TabIndex = 1;
            this.lblDP.Text = "自備款比例";
            // 
            // lblTHP
            // 
            this.lblTHP.AutoSize = true;
            this.lblTHP.Location = new System.Drawing.Point(24, 90);
            this.lblTHP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTHP.Name = "lblTHP";
            this.lblTHP.Size = new System.Drawing.Size(123, 34);
            this.lblTHP.TabIndex = 0;
            this.lblTHP.Text = "房屋總價";
            // 
            // grpOutput
            // 
            this.grpOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.grpOutput.Controls.Add(this.panel1);
            this.grpOutput.Controls.Add(this.label15);
            this.grpOutput.Controls.Add(this.lblTAPMResult);
            this.grpOutput.Controls.Add(this.lblTAPM);
            this.grpOutput.Controls.Add(this.lblTPAResult);
            this.grpOutput.Controls.Add(this.lblTIEResult);
            this.grpOutput.Controls.Add(this.lblFIIResult);
            this.grpOutput.Controls.Add(this.lblFIPResult);
            this.grpOutput.Controls.Add(this.lblMPAIResult);
            this.grpOutput.Controls.Add(this.lblMPAPResult);
            this.grpOutput.Controls.Add(this.lblTotalResult);
            this.grpOutput.Controls.Add(this.label12);
            this.grpOutput.Controls.Add(this.label11);
            this.grpOutput.Controls.Add(this.label10);
            this.grpOutput.Controls.Add(this.label9);
            this.grpOutput.Controls.Add(this.label8);
            this.grpOutput.Controls.Add(this.label7);
            this.grpOutput.Controls.Add(this.label6);
            this.grpOutput.Controls.Add(this.lblTPA);
            this.grpOutput.Controls.Add(this.lblTIE);
            this.grpOutput.Controls.Add(this.lblFIP);
            this.grpOutput.Controls.Add(this.lblFII);
            this.grpOutput.Controls.Add(this.lblMPAI);
            this.grpOutput.Controls.Add(this.lblMPAP);
            this.grpOutput.Controls.Add(this.lblTotal);
            this.grpOutput.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.grpOutput.Location = new System.Drawing.Point(600, 12);
            this.grpOutput.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.grpOutput.Size = new System.Drawing.Size(533, 456);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "計算結果分析";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(22, 238);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 2);
            this.panel1.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(466, 186);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 34);
            this.label15.TabIndex = 37;
            this.label15.Text = "元";
            // 
            // lblTAPMResult
            // 
            this.lblTAPMResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.lblTAPMResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTAPMResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTAPMResult.Location = new System.Drawing.Point(212, 186);
            this.lblTAPMResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTAPMResult.Name = "lblTAPMResult";
            this.lblTAPMResult.Size = new System.Drawing.Size(245, 40);
            this.lblTAPMResult.TabIndex = 36;
            this.lblTAPMResult.Text = "               ";
            this.lblTAPMResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTAPM
            // 
            this.lblTAPM.AutoSize = true;
            this.lblTAPM.Location = new System.Drawing.Point(13, 190);
            this.lblTAPM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTAPM.Name = "lblTAPM";
            this.lblTAPM.Size = new System.Drawing.Size(177, 34);
            this.lblTAPM.TabIndex = 35;
            this.lblTAPM.Text = "每月應繳總額";
            // 
            // lblTPAResult
            // 
            this.lblTPAResult.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblTPAResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTPAResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTPAResult.Location = new System.Drawing.Point(212, 396);
            this.lblTPAResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTPAResult.Name = "lblTPAResult";
            this.lblTPAResult.Size = new System.Drawing.Size(245, 40);
            this.lblTPAResult.TabIndex = 34;
            this.lblTPAResult.Text = "               ";
            this.lblTPAResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTIEResult
            // 
            this.lblTIEResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(238)))));
            this.lblTIEResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTIEResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(60)))), ((int)(((byte)(11)))));
            this.lblTIEResult.Location = new System.Drawing.Point(212, 346);
            this.lblTIEResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTIEResult.Name = "lblTIEResult";
            this.lblTIEResult.Size = new System.Drawing.Size(245, 40);
            this.lblTIEResult.TabIndex = 33;
            this.lblTIEResult.Text = "               ";
            this.lblTIEResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFIIResult
            // 
            this.lblFIIResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.lblFIIResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFIIResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.lblFIIResult.Location = new System.Drawing.Point(212, 296);
            this.lblFIIResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFIIResult.Name = "lblFIIResult";
            this.lblFIIResult.Size = new System.Drawing.Size(245, 40);
            this.lblFIIResult.TabIndex = 32;
            this.lblFIIResult.Text = "               ";
            this.lblFIIResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFIPResult
            // 
            this.lblFIPResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.lblFIPResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFIPResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.lblFIPResult.Location = new System.Drawing.Point(212, 250);
            this.lblFIPResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFIPResult.Name = "lblFIPResult";
            this.lblFIPResult.Size = new System.Drawing.Size(245, 40);
            this.lblFIPResult.TabIndex = 31;
            this.lblFIPResult.Text = "               ";
            this.lblFIPResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMPAIResult
            // 
            this.lblMPAIResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.lblMPAIResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMPAIResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.lblMPAIResult.Location = new System.Drawing.Point(212, 136);
            this.lblMPAIResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMPAIResult.Name = "lblMPAIResult";
            this.lblMPAIResult.Size = new System.Drawing.Size(245, 40);
            this.lblMPAIResult.TabIndex = 30;
            this.lblMPAIResult.Text = "               ";
            this.lblMPAIResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMPAPResult
            // 
            this.lblMPAPResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.lblMPAPResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMPAPResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.lblMPAPResult.Location = new System.Drawing.Point(212, 86);
            this.lblMPAPResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMPAPResult.Name = "lblMPAPResult";
            this.lblMPAPResult.Size = new System.Drawing.Size(245, 40);
            this.lblMPAPResult.TabIndex = 29;
            this.lblMPAPResult.Text = "               ";
            this.lblMPAPResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalResult
            // 
            this.lblTotalResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.lblTotalResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalResult.Location = new System.Drawing.Point(212, 36);
            this.lblTotalResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalResult.Name = "lblTotalResult";
            this.lblTotalResult.Size = new System.Drawing.Size(245, 40);
            this.lblTotalResult.TabIndex = 28;
            this.lblTotalResult.Text = "               ";
            this.lblTotalResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(466, 396);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 34);
            this.label12.TabIndex = 27;
            this.label12.Text = "元";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(466, 346);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 34);
            this.label11.TabIndex = 26;
            this.label11.Text = "元";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(466, 296);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 34);
            this.label10.TabIndex = 25;
            this.label10.Text = "元";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(466, 248);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 34);
            this.label9.TabIndex = 24;
            this.label9.Text = "元";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(466, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 34);
            this.label8.TabIndex = 23;
            this.label8.Text = "元";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 34);
            this.label7.TabIndex = 22;
            this.label7.Text = "元";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 34);
            this.label6.TabIndex = 21;
            this.label6.Text = "元";
            // 
            // lblTPA
            // 
            this.lblTPA.AutoSize = true;
            this.lblTPA.Location = new System.Drawing.Point(13, 400);
            this.lblTPA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTPA.Name = "lblTPA";
            this.lblTPA.Size = new System.Drawing.Size(150, 34);
            this.lblTPA.TabIndex = 17;
            this.lblTPA.Text = "總還款金額";
            // 
            // lblTIE
            // 
            this.lblTIE.AutoSize = true;
            this.lblTIE.Location = new System.Drawing.Point(13, 350);
            this.lblTIE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTIE.Name = "lblTIE";
            this.lblTIE.Size = new System.Drawing.Size(150, 34);
            this.lblTIE.TabIndex = 15;
            this.lblTIE.Text = "總利息支出";
            // 
            // lblFIP
            // 
            this.lblFIP.AutoSize = true;
            this.lblFIP.Location = new System.Drawing.Point(13, 250);
            this.lblFIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFIP.Name = "lblFIP";
            this.lblFIP.Size = new System.Drawing.Size(123, 34);
            this.lblFIP.TabIndex = 14;
            this.lblFIP.Text = "首期本金";
            // 
            // lblFII
            // 
            this.lblFII.AutoSize = true;
            this.lblFII.Location = new System.Drawing.Point(13, 300);
            this.lblFII.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFII.Name = "lblFII";
            this.lblFII.Size = new System.Drawing.Size(123, 34);
            this.lblFII.TabIndex = 13;
            this.lblFII.Text = "首期利息";
            // 
            // lblMPAI
            // 
            this.lblMPAI.AutoSize = true;
            this.lblMPAI.Location = new System.Drawing.Point(13, 140);
            this.lblMPAI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMPAI.Name = "lblMPAI";
            this.lblMPAI.Size = new System.Drawing.Size(177, 34);
            this.lblMPAI.TabIndex = 12;
            this.lblMPAI.Text = "每月應繳利息";
            // 
            // lblMPAP
            // 
            this.lblMPAP.AutoSize = true;
            this.lblMPAP.Location = new System.Drawing.Point(13, 90);
            this.lblMPAP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMPAP.Name = "lblMPAP";
            this.lblMPAP.Size = new System.Drawing.Size(177, 34);
            this.lblMPAP.TabIndex = 11;
            this.lblMPAP.Text = "每月應繳本金";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(13, 40);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(150, 34);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "貸款總金額";
            // 
            // btncount
            // 
            this.btncount.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btncount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncount.ForeColor = System.Drawing.Color.White;
            this.btncount.Location = new System.Drawing.Point(520, 28);
            this.btncount.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btncount.Name = "btncount";
            this.btncount.Size = new System.Drawing.Size(69, 440);
            this.btncount.TabIndex = 5;
            this.btncount.Text = "計算";
            this.btncount.UseVisualStyleBackColor = false;
            this.btncount.Click += new System.EventHandler(this.btncount_Click);
            // 
            // frmhomeloan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1157, 476);
            this.Controls.Add(this.btncount);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(68)))), ((int)(((byte)(124)))));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "frmhomeloan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "個人房貸試算器";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblAIR;
        private System.Windows.Forms.Label lblDP;
        private System.Windows.Forms.Label lblTHP;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Label lblLT;
        private System.Windows.Forms.TextBox txtIDP;
        private System.Windows.Forms.TextBox txtTHP;
        private System.Windows.Forms.Label lblGP;
        private System.Windows.Forms.TextBox txtGP;
        private System.Windows.Forms.TextBox txtLT;
        private System.Windows.Forms.TextBox txtAIR;
        private System.Windows.Forms.Label lblFII;
        private System.Windows.Forms.Label lblMPAI;
        private System.Windows.Forms.Label lblMPAP;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTPA;
        private System.Windows.Forms.Label lblTIE;
        private System.Windows.Forms.Label lblFIP;
        private System.Windows.Forms.Button btncount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTPAResult;
        private System.Windows.Forms.Label lblTIEResult;
        private System.Windows.Forms.Label lblFIIResult;
        private System.Windows.Forms.Label lblFIPResult;
        private System.Windows.Forms.Label lblMPAIResult;
        private System.Windows.Forms.Label lblMPAPResult;
        private System.Windows.Forms.Label lblTotalResult;
        private System.Windows.Forms.Label lblTAPM;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTAPMResult;
        private System.Windows.Forms.Panel panel1;
    }
}

