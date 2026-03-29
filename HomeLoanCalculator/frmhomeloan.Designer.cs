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
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lblTHP = new System.Windows.Forms.Label();
            this.lblDP = new System.Windows.Forms.Label();
            this.lblAIR = new System.Windows.Forms.Label();
            this.lblLT = new System.Windows.Forms.Label();
            this.lblGP = new System.Windows.Forms.Label();
            this.txtTHP = new System.Windows.Forms.TextBox();
            this.txtIDP = new System.Windows.Forms.TextBox();
            this.txtAIR = new System.Windows.Forms.TextBox();
            this.txtLT = new System.Windows.Forms.TextBox();
            this.txtGP = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMPAP = new System.Windows.Forms.Label();
            this.lblMPAI = new System.Windows.Forms.Label();
            this.lblFII = new System.Windows.Forms.Label();
            this.lblFIP = new System.Windows.Forms.Label();
            this.lblTIE = new System.Windows.Forms.Label();
            this.lblTPA = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtMPAP = new System.Windows.Forms.TextBox();
            this.txtMPAI = new System.Windows.Forms.TextBox();
            this.txtFIP = new System.Windows.Forms.TextBox();
            this.txtFII = new System.Windows.Forms.TextBox();
            this.txtTIE = new System.Windows.Forms.TextBox();
            this.txtTPA = new System.Windows.Forms.TextBox();
            this.btncount = new System.Windows.Forms.Button();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
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
            this.grpInput.Font = new System.Drawing.Font("新細明體", 10F);
            this.grpInput.Location = new System.Drawing.Point(26, 22);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(569, 350);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "輸入";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.txtTPA);
            this.grpOutput.Controls.Add(this.txtTIE);
            this.grpOutput.Controls.Add(this.txtFII);
            this.grpOutput.Controls.Add(this.txtFIP);
            this.grpOutput.Controls.Add(this.txtMPAI);
            this.grpOutput.Controls.Add(this.txtMPAP);
            this.grpOutput.Controls.Add(this.txtTotal);
            this.grpOutput.Controls.Add(this.lblTPA);
            this.grpOutput.Controls.Add(this.lblTIE);
            this.grpOutput.Controls.Add(this.lblFIP);
            this.grpOutput.Controls.Add(this.lblFII);
            this.grpOutput.Controls.Add(this.lblMPAI);
            this.grpOutput.Controls.Add(this.lblMPAP);
            this.grpOutput.Controls.Add(this.lblTotal);
            this.grpOutput.Font = new System.Drawing.Font("新細明體", 10F);
            this.grpOutput.Location = new System.Drawing.Point(789, 22);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(599, 606);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "輸出";
            // 
            // lblTHP
            // 
            this.lblTHP.AutoSize = true;
            this.lblTHP.Location = new System.Drawing.Point(32, 59);
            this.lblTHP.Name = "lblTHP";
            this.lblTHP.Size = new System.Drawing.Size(120, 27);
            this.lblTHP.TabIndex = 0;
            this.lblTHP.Text = "房屋總價";
            // 
            // lblDP
            // 
            this.lblDP.AutoSize = true;
            this.lblDP.Location = new System.Drawing.Point(32, 117);
            this.lblDP.Name = "lblDP";
            this.lblDP.Size = new System.Drawing.Size(147, 27);
            this.lblDP.TabIndex = 1;
            this.lblDP.Text = "自備款比例";
            // 
            // lblAIR
            // 
            this.lblAIR.AutoSize = true;
            this.lblAIR.Location = new System.Drawing.Point(32, 180);
            this.lblAIR.Name = "lblAIR";
            this.lblAIR.Size = new System.Drawing.Size(120, 27);
            this.lblAIR.TabIndex = 2;
            this.lblAIR.Text = "貸款利率";
            // 
            // lblLT
            // 
            this.lblLT.AutoSize = true;
            this.lblLT.Location = new System.Drawing.Point(32, 247);
            this.lblLT.Name = "lblLT";
            this.lblLT.Size = new System.Drawing.Size(120, 27);
            this.lblLT.TabIndex = 3;
            this.lblLT.Text = "貸款年限";
            // 
            // lblGP
            // 
            this.lblGP.AutoSize = true;
            this.lblGP.Location = new System.Drawing.Point(32, 301);
            this.lblGP.Name = "lblGP";
            this.lblGP.Size = new System.Drawing.Size(93, 27);
            this.lblGP.TabIndex = 4;
            this.lblGP.Text = "寬限期";
            // 
            // txtTHP
            // 
            this.txtTHP.Location = new System.Drawing.Point(216, 59);
            this.txtTHP.Name = "txtTHP";
            this.txtTHP.Size = new System.Drawing.Size(313, 39);
            this.txtTHP.TabIndex = 5;
            // 
            // txtIDP
            // 
            this.txtIDP.Location = new System.Drawing.Point(216, 117);
            this.txtIDP.Name = "txtIDP";
            this.txtIDP.Size = new System.Drawing.Size(313, 39);
            this.txtIDP.TabIndex = 6;
            // 
            // txtAIR
            // 
            this.txtAIR.Location = new System.Drawing.Point(216, 180);
            this.txtAIR.Name = "txtAIR";
            this.txtAIR.Size = new System.Drawing.Size(313, 39);
            this.txtAIR.TabIndex = 7;
            // 
            // txtLT
            // 
            this.txtLT.Location = new System.Drawing.Point(216, 244);
            this.txtLT.Name = "txtLT";
            this.txtLT.Size = new System.Drawing.Size(313, 39);
            this.txtLT.TabIndex = 8;
            // 
            // txtGP
            // 
            this.txtGP.Location = new System.Drawing.Point(216, 298);
            this.txtGP.Name = "txtGP";
            this.txtGP.Size = new System.Drawing.Size(313, 39);
            this.txtGP.TabIndex = 9;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(45, 59);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(147, 27);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "貸款總金額";
            // 
            // lblMPAP
            // 
            this.lblMPAP.AutoSize = true;
            this.lblMPAP.Location = new System.Drawing.Point(45, 117);
            this.lblMPAP.Name = "lblMPAP";
            this.lblMPAP.Size = new System.Drawing.Size(174, 27);
            this.lblMPAP.TabIndex = 11;
            this.lblMPAP.Text = "每月應繳本金";
            // 
            // lblMPAI
            // 
            this.lblMPAI.AutoSize = true;
            this.lblMPAI.Location = new System.Drawing.Point(45, 168);
            this.lblMPAI.Name = "lblMPAI";
            this.lblMPAI.Size = new System.Drawing.Size(174, 27);
            this.lblMPAI.TabIndex = 12;
            this.lblMPAI.Text = "每月應繳利息";
            // 
            // lblFII
            // 
            this.lblFII.AutoSize = true;
            this.lblFII.Location = new System.Drawing.Point(45, 298);
            this.lblFII.Name = "lblFII";
            this.lblFII.Size = new System.Drawing.Size(120, 27);
            this.lblFII.TabIndex = 13;
            this.lblFII.Text = "首期利息";
            // 
            // lblFIP
            // 
            this.lblFIP.AutoSize = true;
            this.lblFIP.Location = new System.Drawing.Point(45, 231);
            this.lblFIP.Name = "lblFIP";
            this.lblFIP.Size = new System.Drawing.Size(120, 27);
            this.lblFIP.TabIndex = 14;
            this.lblFIP.Text = "首期本金";
            // 
            // lblTIE
            // 
            this.lblTIE.AutoSize = true;
            this.lblTIE.Location = new System.Drawing.Point(45, 361);
            this.lblTIE.Name = "lblTIE";
            this.lblTIE.Size = new System.Drawing.Size(147, 27);
            this.lblTIE.TabIndex = 15;
            this.lblTIE.Text = "總利息支出";
            // 
            // lblTPA
            // 
            this.lblTPA.AutoSize = true;
            this.lblTPA.Location = new System.Drawing.Point(45, 427);
            this.lblTPA.Name = "lblTPA";
            this.lblTPA.Size = new System.Drawing.Size(147, 27);
            this.lblTPA.TabIndex = 17;
            this.lblTPA.Text = "總還款金額";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(280, 47);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(313, 39);
            this.txtTotal.TabIndex = 10;
            // 
            // txtMPAP
            // 
            this.txtMPAP.Location = new System.Drawing.Point(280, 105);
            this.txtMPAP.Name = "txtMPAP";
            this.txtMPAP.Size = new System.Drawing.Size(313, 39);
            this.txtMPAP.TabIndex = 10;
            // 
            // txtMPAI
            // 
            this.txtMPAI.Location = new System.Drawing.Point(280, 165);
            this.txtMPAI.Name = "txtMPAI";
            this.txtMPAI.Size = new System.Drawing.Size(313, 39);
            this.txtMPAI.TabIndex = 10;
            // 
            // txtFIP
            // 
            this.txtFIP.Location = new System.Drawing.Point(280, 228);
            this.txtFIP.Name = "txtFIP";
            this.txtFIP.Size = new System.Drawing.Size(313, 39);
            this.txtFIP.TabIndex = 10;
            // 
            // txtFII
            // 
            this.txtFII.Location = new System.Drawing.Point(280, 295);
            this.txtFII.Name = "txtFII";
            this.txtFII.Size = new System.Drawing.Size(313, 39);
            this.txtFII.TabIndex = 18;
            // 
            // txtTIE
            // 
            this.txtTIE.Location = new System.Drawing.Point(280, 358);
            this.txtTIE.Name = "txtTIE";
            this.txtTIE.Size = new System.Drawing.Size(313, 39);
            this.txtTIE.TabIndex = 19;
            // 
            // txtTPA
            // 
            this.txtTPA.Location = new System.Drawing.Point(280, 424);
            this.txtTPA.Name = "txtTPA";
            this.txtTPA.Size = new System.Drawing.Size(313, 39);
            this.txtTPA.TabIndex = 20;
            // 
            // btncount
            // 
            this.btncount.Font = new System.Drawing.Font("新細明體", 10F);
            this.btncount.Location = new System.Drawing.Point(618, 269);
            this.btncount.Name = "btncount";
            this.btncount.Size = new System.Drawing.Size(144, 103);
            this.btncount.TabIndex = 2;
            this.btncount.Text = "計算";
            this.btncount.UseVisualStyleBackColor = true;
            this.btncount.Click += new System.EventHandler(this.btncount_Click);
            // 
            // frmhomeloan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 667);
            this.Controls.Add(this.btncount);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
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
        private System.Windows.Forms.TextBox txtTPA;
        private System.Windows.Forms.TextBox txtTIE;
        private System.Windows.Forms.TextBox txtFII;
        private System.Windows.Forms.TextBox txtFIP;
        private System.Windows.Forms.TextBox txtMPAI;
        private System.Windows.Forms.TextBox txtMPAP;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTPA;
        private System.Windows.Forms.Label lblTIE;
        private System.Windows.Forms.Label lblFIP;
        private System.Windows.Forms.Button btncount;
    }
}

