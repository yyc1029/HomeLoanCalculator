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

            // 對應 Designer 的元件名稱：txtTHP, txtIDP, txtAIR, txtLT, txtGP
            if (!decimal.TryParse(txtTHP.Text.Trim(), out totalHousePrice) || totalHousePrice <= 0)
            {
                MessageBox.Show("請輸入有效的房屋總價（正數）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTHP.Focus();
                return;
            }

            if (!decimal.TryParse(txtIDP.Text.Trim(), out downPaymentRate) || downPaymentRate < 0 || downPaymentRate >= 100)
            {
                MessageBox.Show("請輸入有效的自備款比例（0 ~ 99 之間）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDP.Focus();
                return;
            }

            if (!decimal.TryParse(txtAIR.Text.Trim(), out annualInterestRate) || annualInterestRate <= 0)
            {
                MessageBox.Show("請輸入有效的貸款利率（正數）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAIR.Focus();
                return;
            }

            if (!int.TryParse(txtLT.Text.Trim(), out loanTerm) || loanTerm <= 0)
            {
                MessageBox.Show("請輸入有效的貸款年限（正整數）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLT.Focus();
                return;
            }

            if (!int.TryParse(txtGP.Text.Trim(), out gracePeriod) || gracePeriod < 0 || gracePeriod >= loanTerm)
            {
                MessageBox.Show("請輸入有效的寬限期（0 以上且小於年限）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGP.Focus();
                return;
            }

            // ── 2. 核心計算 ────────────────────────────────────────
            decimal loanAmount = totalHousePrice * (1 - downPaymentRate / 100m);
            decimal monthlyRate = annualInterestRate / 100m / 12m;
            int graceMonths = gracePeriod * 12;
            int repayMonths = (loanTerm - gracePeriod) * 12;

            decimal repayMonthlyPayment = 0;
            decimal repayMonthlyPrincipal = 0;
            decimal repayMonthlyInterest = 0;

            if (repayMonths > 0)
            {
                double factor = Math.Pow((double)(1 + monthlyRate), repayMonths);
                repayMonthlyPayment = loanAmount * (monthlyRate * (decimal)factor) / ((decimal)factor - 1);
                repayMonthlyInterest = loanAmount * monthlyRate;
                repayMonthlyPrincipal = repayMonthlyPayment - repayMonthlyInterest;
            }

            decimal totalGraceInterest = (loanAmount * monthlyRate) * graceMonths;
            decimal totalRepayInterest = (repayMonthlyPayment * repayMonths) - loanAmount;
            decimal totalInterest = totalGraceInterest + totalRepayInterest;
            decimal totalPayment = loanAmount + totalInterest;

            // ── 3. 輸出至 Designer 定義的 Label ──────────────────
            // 名稱必須完全對應你提供的 Designer 內容
            string fmt = "N2";

            lblTotalResult.Text = loanAmount.ToString(fmt);

            // 處理每月本息顯示邏輯
            if (gracePeriod > 0)
            {
                lblMPAPResult.Text = "0.00"; // 寬限期本金為 0
                lblMPAIResult.Text = (loanAmount * monthlyRate).ToString(fmt);
                lblFIPResult.Text = "0.00";
                lblFIIResult.Text = (loanAmount * monthlyRate).ToString(fmt);
            }
            else
            {
                lblMPAPResult.Text = repayMonthlyPrincipal.ToString(fmt);
                lblMPAIResult.Text = repayMonthlyInterest.ToString(fmt);
                lblFIPResult.Text = repayMonthlyPrincipal.ToString(fmt);
                lblFIIResult.Text = repayMonthlyInterest.ToString(fmt);
            }

            lblTIEResult.Text = totalInterest.ToString(fmt);
            lblTPAResult.Text = totalPayment.ToString(fmt);
        }

        // 修正你 Designer 裡綁定的空的事件，避免報錯
        private void grpInput_Enter(object sender, EventArgs e)
        {
            // 留空即可
        }
    }
}