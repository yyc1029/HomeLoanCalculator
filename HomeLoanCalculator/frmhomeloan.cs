using System;
using System.Windows.Forms;

namespace HomeLoanCalculator
{
    public partial class frmhomeloan : Form
    {
        public frmhomeloan()
        {
            InitializeComponent();
        }

        private void btncount_Click(object sender, EventArgs e)
        {
            // ── 1. 輸入讀取與驗證 ──────────────────────────────────
            decimal totalHousePrice, downPaymentRate, annualInterestRate;
            int loanTerm, gracePeriod;

            // 房屋總價：不可空白、必須為正整數、上限 10 億
            if (string.IsNullOrWhiteSpace(txtTHP.Text))
            {
                MessageBox.Show("房屋總價不可為空白。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTHP.Focus();
                return;
            }
            if (!decimal.TryParse(txtTHP.Text.Trim(), out totalHousePrice)
                || totalHousePrice < 1
                || totalHousePrice > 1_000_000_000
                || totalHousePrice != Math.Floor(totalHousePrice))
            {
                MessageBox.Show("房屋總價請輸入 1 ~ 1,000,000,000 之間的正整數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTHP.Focus();
                return;
            }

            // 自備款比例：不可空白、0.01 ~ 99.99、最多兩位小數
            if (string.IsNullOrWhiteSpace(txtIDP.Text))
            {
                MessageBox.Show("自備款比例不可為空白。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDP.Focus();
                return;
            }
            if (!decimal.TryParse(txtIDP.Text.Trim(), out downPaymentRate)
                || downPaymentRate < 0.01m
                || downPaymentRate > 99.99m
                || decimal.Round(downPaymentRate, 2) != downPaymentRate)
            {
                MessageBox.Show("自備款比例請輸入 0.01 ~ 99.99 之間的數值（最多小數兩位）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDP.Focus();
                return;
            }

            // 貸款利率：不可空白、0.01 ~ 30、最多兩位小數
            if (string.IsNullOrWhiteSpace(txtAIR.Text))
            {
                MessageBox.Show("貸款利率不可為空白。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAIR.Focus();
                return;
            }
            if (!decimal.TryParse(txtAIR.Text.Trim(), out annualInterestRate)
                || annualInterestRate < 0.01m
                || annualInterestRate > 30m
                || decimal.Round(annualInterestRate, 2) != annualInterestRate)
            {
                MessageBox.Show("貸款利率請輸入 0.01 ~ 30.00 之間的數值（最多小數兩位）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAIR.Focus();
                return;
            }

            // 貸款年限：不可空白、1 ~ 40 年的正整數
            if (string.IsNullOrWhiteSpace(txtLT.Text))
            {
                MessageBox.Show("貸款年限不可為空白。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLT.Focus();
                return;
            }
            if (!int.TryParse(txtLT.Text.Trim(), out loanTerm)
                || loanTerm < 1
                || loanTerm > 40)
            {
                MessageBox.Show("貸款年限請輸入 1 ~ 40 之間的正整數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLT.Focus();
                return;
            }

            // 寬限期：不可空白、0 ~ (貸款年限 - 1) 的非負整數
            if (string.IsNullOrWhiteSpace(txtGP.Text))
            {
                MessageBox.Show("寬限期不可為空白。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGP.Focus();
                return;
            }
            if (!int.TryParse(txtGP.Text.Trim(), out gracePeriod)
                || gracePeriod < 0
                || gracePeriod >= loanTerm)
            {
                MessageBox.Show($"寬限期請輸入 0 ~ {loanTerm - 1} 之間的整數（必須小於貸款年限）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGP.Focus();
                return;
            }

            // ── 2. 核心計算 (完全依照原始數值，不進行中間捨入) ──────────────

            decimal loanAmount = totalHousePrice * (1 - downPaymentRate / 100m);
            decimal monthlyRate = annualInterestRate / 100m / 12m;
            int totalMonths = loanTerm * 12;
            int graceMonths = gracePeriod * 12;
            int repayMonths = totalMonths - graceMonths;

            decimal repayMonthlyPayment = 0;
            decimal graceMonthlyInterest = loanAmount * monthlyRate;

            if (repayMonths > 0)
            {
                // 內政部公式：平均攤還率 = {[(1+r)^n]*r} / {[(1+r)^n]-1}
                double powFactor = Math.Pow((double)(1 + monthlyRate), repayMonths);
                decimal averageRepayRate = (decimal)((powFactor * (double)monthlyRate) / (powFactor - 1));
                repayMonthlyPayment = loanAmount * averageRepayRate;
            }

            decimal firstRepayMonthlyInterest = loanAmount * monthlyRate;
            decimal firstRepayMonthlyPrincipal = repayMonthlyPayment - firstRepayMonthlyInterest;

            decimal totalInterest = (graceMonthlyInterest * graceMonths) +
                                    (repayMonthlyPayment * repayMonths - loanAmount);
            decimal totalPayment = loanAmount + totalInterest;

            // ── 3. 輸出顯示 (僅在最後輸出時格式化) ─────────────────
            string fmt = "N2";

            lblTotalResult.Text = loanAmount.ToString(fmt);

            if (gracePeriod > 0)
            {
                lblFIPResult.Text = "0.00";
                lblFIIResult.Text = graceMonthlyInterest.ToString(fmt);
                lblMPAPResult.Text = firstRepayMonthlyPrincipal.ToString(fmt);
                lblMPAIResult.Text = firstRepayMonthlyInterest.ToString(fmt);
                lblTAPMResult.Text = repayMonthlyPayment.ToString(fmt);
            }
            else
            {
                lblFIPResult.Text = firstRepayMonthlyPrincipal.ToString(fmt);
                lblFIIResult.Text = firstRepayMonthlyInterest.ToString(fmt);
                lblMPAPResult.Text = firstRepayMonthlyPrincipal.ToString(fmt);
                lblMPAIResult.Text = firstRepayMonthlyInterest.ToString(fmt);
                lblTAPMResult.Text = repayMonthlyPayment.ToString(fmt);
            }

            lblTIEResult.Text = totalInterest.ToString(fmt);
            lblTPAResult.Text = totalPayment.ToString(fmt);
        }

        private void grpInput_Enter(object sender, EventArgs e) { }
    }
}