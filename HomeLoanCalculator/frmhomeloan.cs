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

            // 貸款本金 (P)
            decimal loanAmount = totalHousePrice * (1 - downPaymentRate / 100m);

            // 月利率 (r)
            decimal monthlyRate = annualInterestRate / 100m / 12m;

            // 總月數與寬限期月數
            int totalMonths = loanTerm * 12;
            int graceMonths = gracePeriod * 12;
            int repayMonths = totalMonths - graceMonths;

            decimal repayMonthlyPayment = 0;
            decimal graceMonthlyInterest = loanAmount * monthlyRate;

            if (repayMonths > 0)
            {
                // 依照內政部公式：平均攤還率 = {[(1+r)^n]*r} / {[(1+r)^n]-1}
                double powFactor = Math.Pow((double)(1 + monthlyRate), repayMonths);
                decimal averageRepayRate = (decimal)((powFactor * (double)monthlyRate) / (powFactor - 1));

                // 每月應攤付本息金額 (不進位，保留所有小數)
                repayMonthlyPayment = loanAmount * averageRepayRate;
            }

            // 攤還期首月拆解 (不進位)
            decimal firstRepayMonthlyInterest = loanAmount * monthlyRate;
            decimal firstRepayMonthlyPrincipal = repayMonthlyPayment - firstRepayMonthlyInterest;

            // 總支出計算：直接用高精度數值累乘
            // 總利息 = (寬限期月息 * 寬限月數) + (攤還期月付額 * 攤還月數 - 貸款本金)
            decimal totalInterest = (graceMonthlyInterest * graceMonths) +
                                    (repayMonthlyPayment * repayMonths - loanAmount);
            decimal totalPayment = loanAmount + totalInterest;

            // ── 3. 輸出顯示 (僅在最後輸出時格式化到小數點後兩位) ───────────
            string fmt = "N2";

            lblTotalResult.Text = loanAmount.ToString(fmt);

            if (gracePeriod > 0)
            {
                // 寬限期內顯示
                lblFIPResult.Text = "0.00";
                lblFIIResult.Text = graceMonthlyInterest.ToString(fmt);

                // 顯示進入攤還期後的每月應繳數值
                lblMPAPResult.Text = firstRepayMonthlyPrincipal.ToString(fmt);
                lblMPAIResult.Text = firstRepayMonthlyInterest.ToString(fmt);
            }
            else
            {
                // 無寬限期顯示
                lblFIPResult.Text = firstRepayMonthlyPrincipal.ToString(fmt);
                lblFIIResult.Text = firstRepayMonthlyInterest.ToString(fmt);
                lblMPAPResult.Text = firstRepayMonthlyPrincipal.ToString(fmt);
                lblMPAIResult.Text = firstRepayMonthlyInterest.ToString(fmt);
            }

            lblTIEResult.Text = totalInterest.ToString(fmt);
            lblTPAResult.Text = totalPayment.ToString(fmt);
        }

        private void grpInput_Enter(object sender, EventArgs e) { }
    }
}