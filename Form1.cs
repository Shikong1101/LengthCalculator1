using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace LengthCalculator
{
#pragma warning disable IDE1006
    public partial class Form1 : Form
    {
        private const double CM_TO_M = 0.01;
        private const double KM_TO_M = 1000;
        private const double INCH_TO_M = 0.0254;
        private const double FT_TO_M = 0.3048;
        private const double YARD_TO_M = 0.9144;

        private bool isUpdating = false;

        public Form1()
        {
            InitializeComponent();
            clear.Click += BtnClear_Click; // 綁定清除按鈕
        }

        private void Cm_KeyUp(object sender, KeyEventArgs e) => ComputeAndSet(cm, CM_TO_M);
        private void W_KeyUp(object sender, KeyEventArgs e) => ComputeAndSet(m, 1);
        private void Km_KeyUp(object sender, KeyEventArgs e) => ComputeAndSet(km, KM_TO_M);
        private void Inch_KeyUp(object sender, KeyEventArgs e) => ComputeAndSet(inch, INCH_TO_M);
        private void Ft_KeyUp(object sender, KeyEventArgs e) => ComputeAndSet(ft, FT_TO_M);
        private void Yard_KeyUp(object sender, KeyEventArgs e) => ComputeAndSet(yard, YARD_TO_M);

        private void ComputeAndSet(TextBox sourceTextBox, double toMeterRatio)
        {
            if (isUpdating) return;
            isUpdating = true;

            int cursorPosition = sourceTextBox.SelectionStart;

            string input = sourceTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                ClearAllFields();
                isUpdating = false;
                return;
            }

            if (!double.TryParse(input, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out double value))
            {
                sourceTextBox.ForeColor = System.Drawing.Color.Red;
                explanationTextBox.Text = "請輸入有效的數字！";  // 顯示錯誤訊息
                isUpdating = false;
                return;
            }

            // 清除錯誤提示
            sourceTextBox.ForeColor = System.Drawing.Color.Black;
            explanationTextBox.Text = "";

            double meters = value * toMeterRatio;

            cm.Text = (meters / CM_TO_M).ToString("N2", CultureInfo.InvariantCulture);
            m.Text = meters.ToString("N2", CultureInfo.InvariantCulture);
            km.Text = (meters / KM_TO_M).ToString("N6", CultureInfo.InvariantCulture);
            inch.Text = (meters / INCH_TO_M).ToString("N2", CultureInfo.InvariantCulture);
            ft.Text = (meters / FT_TO_M).ToString("N2", CultureInfo.InvariantCulture);
            yard.Text = (meters / YARD_TO_M).ToString("N2", CultureInfo.InvariantCulture);

            sourceTextBox.SelectionStart = cursorPosition;
            sourceTextBox.SelectionLength = 0;

            isUpdating = false;
        }

        // ✅ 確保「清除鍵」可以清空所有欄位 + 錯誤訊息
        private void ClearAllFields()
        {
            cm.Text = "";
            m.Text = "";
            km.Text = "";
            inch.Text = "";
            ft.Text = "";
            yard.Text = "";
            explanationTextBox.Text = ""; // 清空錯誤訊息
            isUpdating = false;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }
    }
}