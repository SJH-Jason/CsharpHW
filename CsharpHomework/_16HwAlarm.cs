using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpHomework
{
    public partial class _16HwAlarm : Form
    {
        private List<DateTime> alarmTimes = new List<DateTime>();

        public _16HwAlarm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            labTime.Text = currentTime.ToString("HH:mm:ss");

            // 檢查是否有鬧鈴時間到達
            foreach (DateTime alarmTime in alarmTimes)
            {
                if (currentTime.Hour == alarmTime.Hour
                    && currentTime.Minute == alarmTime.Minute
                    && currentTime.Second == alarmTime.Second)
                {
                    MessageBox.Show("時間到了！準備出發!!");
                }
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            // 新增一個鬧鈴時間
            if (alarmTimes.Count >= 5)
            {
                MessageBox.Show("最多只能設置五項鬧鈴時間。");
                return;
            }

            int hour = (int)numHour.Value;
            int min = (int)nummin.Value;
            int sec = (int)numSec.Value;

            DateTime alarmTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, min, sec);
            alarmTimes.Add(alarmTime);

            // 更新列表框
            labSet.Text += "\n"+alarmTime.ToString("HH:mm") ;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // 移除最後一個鬧鈴時間
            if (alarmTimes.Count > 0)
            {
                alarmTimes.RemoveAt(alarmTimes.Count - 1);
                labSet.Text = "鬧鐘時間：";
                foreach (DateTime alarmTime in alarmTimes)
                {
                    labSet.Text +="\n"+alarmTime.ToString("HH:mm");
                }
            }
        }
    }
}
