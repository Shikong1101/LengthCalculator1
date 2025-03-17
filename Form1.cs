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
        //定義各種長度單位轉換為公尺 (m) 的比例
        private const double CM_TO_M = 0.01;    // 1 公分 = 0.01 公尺
        private const double KM_TO_M = 1000;    // 1 公里 = 1000 公尺
        private const double INCH_TO_M = 0.0254;// 1 英吋 = 0.0254 公尺
        private const double FT_TO_M = 0.3048;  // 1 英尺 = 0.3048 公尺
        private const double YARD_TO_M = 0.9144;// 1 碼 = 0.9144 公尺

        private bool isUpdating = false; //防止 KeyUp 事件遞迴觸發，避免無窮迴圈

        // Form1類別的建構函式，當程式啟動時執行
        public Form1()
        {
            InitializeComponent(); // 初始化 UI 控件
            clear.Click += BtnClear_Click; // 綁定清除按鈕的 Click 事件
        }

        // KeyUp 事件處理函式，每個 TextBox 對應不同單位
        private void Cm_KeyUp(object sender, KeyEventArgs e) => ComputeAndSet(cm, CM_TO_M);
        private void W_KeyUp(object sender, KeyEventArgs e) => ComputeAndSet(m, 1);
        private void Km_KeyUp(object sender, KeyEventArgs e) => ComputeAndSet(km, KM_TO_M);
        private void Inch_KeyUp(object sender, KeyEventArgs e) => ComputeAndSet(inch, INCH_TO_M);
        private void Ft_KeyUp(object sender, KeyEventArgs e) => ComputeAndSet(ft, FT_TO_M);
        private void Yard_KeyUp(object sender, KeyEventArgs e) => ComputeAndSet(yard, YARD_TO_M);

        /// <summary>
        /// 當用戶輸入長度數值後，進行單位轉換並更新所有TextBox
        /// </summary>
        private void ComputeAndSet(TextBox sourceTextBox, double toMeterRatio)
        {
            if (isUpdating) return; // 防止 KeyUp 事件重複觸發
            isUpdating = true; // 設定狀態為正在更新

            int cursorPosition = sourceTextBox.SelectionStart; // 記錄游標位置，防止游標跳回開頭

            string input = sourceTextBox.Text.Trim(); // 取得輸入文字並去掉前後空白

            //  如果輸入是空白，則清空所有欄位並返回
            if (string.IsNullOrWhiteSpace(input))
            {
                ClearAllFields();
                isUpdating = false;
                return;
            }

            // 嘗試解析輸入的數字，如果輸入非數字 (如 "abc")，則顯示錯誤訊息
            if (!double.TryParse(input, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out double value))
            {
                sourceTextBox.ForeColor = System.Drawing.Color.Red; // 變紅色表示錯誤輸入
                explanationTextBox.Text = "請輸入有效的數字！";  // 顯示錯誤訊息
                isUpdating = false;
                return;
            }

            //清除錯誤提示，將文字顏色恢復為黑色
            sourceTextBox.ForeColor = System.Drawing.Color.Black;
            explanationTextBox.Text = "";

            //轉換輸入數值為「公尺」
            double meters = value * toMeterRatio;

            //計算並更新所有長度單位的 TextBox
            cm.Text = (meters / CM_TO_M).ToString("N2", CultureInfo.InvariantCulture);
            m.Text = meters.ToString("N2", CultureInfo.InvariantCulture);
            km.Text = (meters / KM_TO_M).ToString("N6", CultureInfo.InvariantCulture);
            inch.Text = (meters / INCH_TO_M).ToString("N2", CultureInfo.InvariantCulture);
            ft.Text = (meters / FT_TO_M).ToString("N2", CultureInfo.InvariantCulture);
            yard.Text = (meters / YARD_TO_M).ToString("N2", CultureInfo.InvariantCulture);

            //還原游標位置，避免輸入時游標亂跳
            sourceTextBox.SelectionStart = cursorPosition;
            sourceTextBox.SelectionLength = 0;

            isUpdating = false; // 設定狀態為「更新完成」
        }

        /// <summary>
        ///  清空所有輸入框 TextBox 的值，並重置狀態
        /// </summary>
        private void ClearAllFields()
        {
            cm.Text = "";
            m.Text = "";
            km.Text = "";
            inch.Text = "";
            ft.Text = "";
            yard.Text = "";
            explanationTextBox.Text = ""; //清空錯誤訊息
            isUpdating = false;
        }

        /// <summary>
        ///  按下「清除」按鈕時，執行ClearAllFields()
        /// </summary>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }
    }
}
