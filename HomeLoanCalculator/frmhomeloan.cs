using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            // 寬限期可為空或 0
            string gpText = txtGP.Text.Trim();
            if (string.IsNullOrEmpty(gpText))
            {
                gracePeriod = 0;
            }
            else if (!int.TryParse(gpText, out gracePeriod) || gracePeriod < 0 || gracePeriod >= loanTerm)
            {
                MessageBox.Show("請輸入有效的寬限期（0 以上、小於貸款年限的整數）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGP.Focus();
                return;
            }

            // ── 2. 核心計算 ────────────────────────────────────────
            // 貸款總金額
            decimal loanAmount = totalHousePrice * (1 - downPaymentRate / 100m);

            // 每月利率
            decimal monthlyRate = annualInterestRate / 100m / 12m;

            // 寬限期月數 & 攤還期月數
            int graceMonths = gracePeriod * 12;
            int repayMonths = (loanTerm - gracePeriod) * 12;

            // ── 首期（第 1 個月）本金與利息 ──
            decimal firstMonthPrincipal;
            decimal firstMonthInterest;

            // 寬限期內：只繳利息
            decimal graceMonthlyInterest = loanAmount * monthlyRate;

            if (gracePeriod > 0)
            {
                firstMonthPrincipal = 0m;
                firstMonthInterest = graceMonthlyInterest;
            }
            else
            {
                // 無寬限期，直接攤還
                // 每月應還本金（平均攤還公式分子）
                // M = P * r(1+r)^n / ((1+r)^n - 1)
                decimal factor = (decimal)Math.Pow((double)(1 + monthlyRate), repayMonths);
                decimal monthlyPayment = loanAmount * monthlyRate * factor / (factor - 1);
                firstMonthInterest = loanAmount * monthlyRate;
                firstMonthPrincipal = monthlyPayment - firstMonthInterest;
            }

            // ── 攤還期每月本金 & 利息（寬限期結束後）──
            decimal repayMonthlyPayment;
            decimal repayMonthlyPrincipal;
            decimal repayMonthlyInterest;

            {
                decimal factor = (decimal)Math.Pow((double)(1 + monthlyRate), repayMonths);
                repayMonthlyPayment = loanAmount * monthlyRate * factor / (factor - 1);
                // 攤還第一期的利息仍以 loanAmount 為基礎
                repayMonthlyInterest = loanAmount * monthlyRate;
                repayMonthlyPrincipal = repayMonthlyPayment - repayMonthlyInterest;
            }

            // ── 總利息支出 ──
            // 寬限期總利息
            decimal totalGraceInterest = graceMonthlyInterest * graceMonths;

            // 攤還期總利息 = 總還款 - 本金
            decimal totalRepayPayment = repayMonthlyPayment * repayMonths;
            decimal totalRepayInterest = totalRepayPayment - loanAmount;

            decimal totalInterest = totalGraceInterest + totalRepayInterest;

            // 總還款金額
            decimal totalPayment = loanAmount + totalInterest;

            // ── 3. 輸出顯示（千分位 + 小數後兩位）──────────────────
            string fmt = "#,##0.00";

            lblTotalResult.Text = loanAmount.ToString(fmt);
            lblMPAPResult.Text = (gracePeriod > 0 ? 0m : repayMonthlyPrincipal).ToString(fmt);
            lblMPAIResult.Text = (gracePeriod > 0 ? graceMonthlyInterest : repayMonthlyInterest).ToString(fmt);
            lblFIPResult.Text = firstMonthPrincipal.ToString(fmt);
            lblFIIResult.Text = firstMonthInterest.ToString(fmt);
            lblTIEResult.Text = totalInterest.ToString(fmt);
            lblTPAResult.Text = totalPayment.ToString(fmt);
        }

        private void grpInput_Enter(object sender, EventArgs e)
        {

        }
    }
}