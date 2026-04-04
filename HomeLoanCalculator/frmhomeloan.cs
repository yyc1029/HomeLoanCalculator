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

            if (!decimal.TryParse(txtTHP.Text.Trim(), out totalHousePrice) || totalHousePrice <= 0)
            {
                MessageBox.Show("請輸入有效的房屋總價。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtIDP.Text.Trim(), out downPaymentRate) || downPaymentRate < 0 || downPaymentRate >= 100)
            {
                MessageBox.Show("請輸入有效的自備款比例。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtAIR.Text.Trim(), out annualInterestRate) || annualInterestRate <= 0)
            {
                MessageBox.Show("請輸入有效的貸款利率。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtLT.Text.Trim(), out loanTerm) || loanTerm <= 0)
            {
                MessageBox.Show("請輸入有效的貸款年限。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtGP.Text.Trim(), out gracePeriod) || gracePeriod < 0 || gracePeriod >= loanTerm)
            {
                MessageBox.Show("寬限期必須小於貸款年限。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                // 寬限期內：本金為 0，利息為寬限期月息
                lblFIPResult.Text = "0.00";
                lblFIIResult.Text = graceMonthlyInterest.ToString(fmt);

                // 每月欄位顯示進入攤還期後的數值
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