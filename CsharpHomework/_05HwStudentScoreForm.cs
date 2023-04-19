using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static CsharpHomework._05HwStudentScoreForm;

namespace CsharpHomework
{
    public partial class _05HwStudentScoreForm : Form
    {
        public _05HwStudentScoreForm()
        {
            InitializeComponent();

        }

        //三個數列 國文、英文、數學 要算總和、最大值、最小值
        //隨機數的姓名 是看總條列人數
        //每組資料存儲 姓名 國文 英文 數學 四筆資料  1字串 3數字
        int count;
        public struct StData
        {
            public string StName;
            public int CnScore;
            public int EnScore;
            public int MathScore;
            public int SumScore;
            public int AvgScore;
            public int MaxScore;
            public int MinScore;

        }
        //存結構內容單元
        List<StData> StDataList = new List<StData>();

        public void DataSave()
        {

            string[] StNames = StDataList.Select(stData => stData.StName).ToArray();
            int[] CnScores = StDataList.Select(stData => stData.CnScore).ToArray();
            int[] EnScores = StDataList.Select(stData => stData.EnScore).ToArray();
            int[] MathScores = StDataList.Select(stData => stData.MathScore).ToArray();

            int CnMax = CnScores.Max();
            int EnMax = EnScores.Max();
            int MathMax = MathScores.Max();
            int CnMin = CnScores.Min();
            int EnMin = EnScores.Min();
            int MathMin = MathScores.Min();
            int CnSum = CnScores.Sum();
            int EnSum = EnScores.Sum();
            int MathSum = MathScores.Sum();
            double CnAvg = CnScores.Average(); string sCnAvg = CnAvg.ToString("F1");
            double EnAvg = EnScores.Average(); string sEnAvg = EnAvg.ToString("F1");
            double MathAvg = MathScores.Average(); string sMathAvg = MathAvg.ToString("F1");

            labShow.Text =
            $"{"總和　",-8:0}{CnSum,-8:0}{EnSum,-8:0}{MathSum,-8:0}\n{"平均　",-8:0}{sCnAvg,-8:0}{sEnAvg,-8:0}{sMathAvg,-8:0}\n{"最高分",-8:0}{CnMax,-8:0}{EnMax,-8:0}{MathMax,-8:0}\n{"最低分",-8:0}{CnMin,-8:0}{EnMin,-8:0}{MathMin,-8:0}";


            //labText.Text += $"\n{CnScores[0]}";
            //labText.Text += $"\n{CnScores[1]}";
            //labText.Text += $"\n{CnScores.Max()}";
            //labText.Text += $"\n{CnScores.Min()}";
            //labText.Text += $"\n{CnScores.Sum()}";
            //labText.Text += $"\n{CnScores.Average()}";
        }

        //未確認方法
        private void RefreshDataList()
        {
            // 清空文字內容
            labScoreList.Text = "";
            //清空文字內容
            List.Items.Clear();

            // 遍歷每一筆資料，將其格式化後加入文字內容中
            foreach (StData stData in StDataList)
            {
                string output = "";
                if (stData.MinScore == stData.CnScore)
                {
                    output += "國文" + stData.CnScore + "  ";
                }
                else if (stData.MinScore == stData.EnScore)
                {
                    output += "英文" + stData.EnScore + "  ";
                }
                else
                {
                    output += "數學" + stData.MathScore + "  ";
                }
                if (stData.MaxScore == stData.CnScore)
                {
                    output += "國文" + stData.CnScore;
                }
                else if (stData.MaxScore == stData.EnScore)
                {
                    output += "英文" + stData.EnScore;
                }
                else
                {
                    output += "數學" + stData.MathScore;
                }
                labScoreList.Text += $"{stData.StName,5:0}{stData.CnScore,10:0}{stData.EnScore,10:0}{stData.MathScore,10:0}{stData.SumScore,16:0}{stData.AvgScore,8:0}  {output,10:0}\n";

                ListViewItem item = new ListViewItem(stData.StName);
                item.SubItems.Add(Convert.ToString(stData.CnScore));
                item.SubItems.Add(Convert.ToString(stData.EnScore));
                item.SubItems.Add(Convert.ToString(stData.MathScore));
                item.SubItems.Add(Convert.ToString(stData.SumScore));
                item.SubItems.Add(Convert.ToString(stData.AvgScore));
                int mm = Math.Min(stData.CnScore, Math.Min(stData.EnScore, stData.MathScore));
                if (mm == stData.CnScore)
                {
                    item.SubItems.Add($"國文{Convert.ToString(mm)}");
                }
                else if (mm == stData.EnScore)
                {
                    item.SubItems.Add($"英文{Convert.ToString(mm)}");
                }
                else
                {
                    item.SubItems.Add($"數學{Convert.ToString(mm)}");
                }

                // item.SubItems.Add(Convert.ToString(Math.Min(stData.CnScore,Math.Min(stData.EnScore,stData.MathScore))));
                int MM = Math.Max(stData.CnScore, Math.Max(stData.EnScore, stData.MathScore));
                if (MM == stData.CnScore)
                {
                    item.SubItems.Add($"國文{Convert.ToString(MM)}");
                }
                else if (MM == stData.EnScore)
                {
                    item.SubItems.Add($"英文{Convert.ToString(MM)}");
                }
                else
                {
                    item.SubItems.Add($"數學{Convert.ToString(MM)}");
                }

                //item.SubItems.Add(Convert.ToString(Math.Max(stData.CnScore, Math.Max(stData.EnScore, stData.MathScore))));
                List.Items.Add(item);
            }
        }
        public void Random()
        {
            StData stData = new StData();
            Random r = new Random();
            string output = "";
            int numCn = r.Next(0, 101);
            int numEn = r.Next(0, 101);
            int numMath = r.Next(0, 101);

            stData.StName = Convert.ToString(count + 1);
            stData.CnScore = numCn;
            stData.EnScore = numEn;
            stData.MathScore = numMath;
            stData.SumScore = numCn + numEn + numMath;
            stData.AvgScore = stData.SumScore / 3;
            stData.MaxScore = Math.Max(numCn, (Math.Max(numEn, numCn)));
            stData.MinScore = Math.Min(stData.CnScore, (Math.Min(stData.EnScore, stData.MathScore)));
            if (stData.MinScore == stData.CnScore)
            {
                output += "        " + "國文" + stData.CnScore + "        ";
            }
            else if (stData.MinScore == stData.EnScore)
            {
                output += "        " + "英文" + stData.EnScore + "        ";
            }
            else
            {
                output += "        " + "數學" + stData.MathScore + "        ";
            }
            if (stData.MaxScore == stData.CnScore)
            {
                output += "國文" + stData.CnScore;
            }
            else if (stData.MaxScore == stData.EnScore)
            {
                output += "英文" + stData.EnScore;
            }
            else
            {
                output += "數學" + stData.MathScore;
            }

            //labScoreList.Text += $"{stData.StName,5:0}{stData.CnScore,10:0}{stData.EnScore,10:0}{stData.MathScore,10:0}{stData.SumScore,16:0}{stData.AvgScore,8:0}  {output,10:0}\n";

            count++;
            StDataList.Add(stData);

            //輸出資料未確認
            RefreshDataList();
            btnShow.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int numCn, numEn, numMath;
            string output = "";
            StData stData = new StData();
            if (txtName.Text.Length == 0)
            {
                MessageBox.Show("請輸入姓名");
                return;
            }

            if (int.TryParse(txtCn.Text, out numCn) && int.TryParse(txtEn.Text, out numEn) && int.TryParse(txtMath.Text, out numMath) && numCn >= 0 && numEn >= 0 && numMath >= 0)
            {
                stData.StName = txtName.Text;
                stData.CnScore = numCn;
                stData.EnScore = numEn;
                stData.MathScore = numMath;
                stData.SumScore = numCn + numEn + numMath;
                stData.AvgScore = stData.SumScore / 3;
                stData.MaxScore = Math.Max(numCn, (Math.Max(numEn, numCn)));
                stData.MinScore = Math.Min(stData.CnScore, (Math.Min(stData.EnScore, stData.MathScore)));
                if (stData.MinScore == stData.CnScore)
                {
                    output += "國文" + stData.CnScore + "  ";
                }
                else if (stData.MinScore == stData.EnScore)
                {
                    output += "英文" + stData.EnScore + "  ";
                }
                else
                {
                    output += "數學" + stData.MathScore + "  ";
                }
                if (stData.MaxScore == stData.CnScore)
                {
                    output += "國文" + stData.CnScore;
                }
                else if (stData.MaxScore == stData.EnScore)
                {
                    output += "英文" + stData.EnScore;
                }
                else
                {
                    output += "數學" + stData.MathScore;
                }

                // labScoreList.Text += $"{stData.StName,5:0}{stData.CnScore,10:0}{stData.EnScore,10:0}{stData.MathScore,10:0}{stData.SumScore,16:0}{stData.AvgScore,8:0}  {output,10:0}\n";

                count++;
                //存入結構單元
                StDataList.Add(stData);
                //輸出資料未確認
                RefreshDataList();
                btnShow.Enabled = true;

            }
            else
            {
                MessageBox.Show("請輸入各科正確成績");
                return;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            DataSave();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random();
        }

        private void btnrenew_Click(object sender, EventArgs e)
        {
            StDataList.Clear();
            labShow.Text = "";
            labScoreList.Text = "";
            count = 0;
            btnShow.Enabled = false;
            List.Items.Clear();
        }

        private void btnRandom20_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                Random();
            }
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            int numCn, numEn, numMath;
            string output = "";
            StData stData = new StData();
            if (txtName.Text.Length == 0)
            {
                MessageBox.Show("請輸入姓名");
                return;
            }

            if (int.TryParse(txtCn.Text, out numCn) && int.TryParse(txtEn.Text, out numEn) && int.TryParse(txtMath.Text, out numMath) && numCn >= 0 && numEn >= 0 && numMath >= 0)
            {
                stData.StName = txtName.Text;
                stData.CnScore = numCn;
                stData.EnScore = numEn;
                stData.MathScore = numMath;
                stData.SumScore = numCn + numEn + numMath;
                stData.AvgScore = stData.SumScore / 3;
                stData.MaxScore = Math.Max(numCn, (Math.Max(numEn, numCn)));
                stData.MinScore = Math.Min(stData.CnScore, (Math.Min(stData.EnScore, stData.MathScore)));
                if (stData.MinScore == stData.CnScore)
                {
                    output += "國文" + stData.CnScore + "  ";
                }
                else if (stData.MinScore == stData.EnScore)
                {
                    output += "英文" + stData.EnScore + "  ";
                }
                else
                {
                    output += "數學" + stData.MathScore + "  ";
                }
                if (stData.MaxScore == stData.CnScore)
                {
                    output += "國文" + stData.CnScore;
                }
                else if (stData.MaxScore == stData.EnScore)
                {
                    output += "英文" + stData.EnScore;
                }
                else
                {
                    output += "數學" + stData.MathScore;
                }

                //outputlab = labScoreList.Text;
                //output2 = $"{stData.StName,5:0}{stData.CnScore,10:0}{stData.EnScore,10:0}{stData.MathScore,10:0}{stData.SumScore,16:0}{stData.AvgScore,8:0}  {output,10:0}\n";
                ////手動變更順序
                //labScoreList.Text = $"{output2}{outputlab}";
                count++;
                //插入結構單元
                StDataList.Insert(0, stData);

                //輸出資料未確認
                RefreshDataList();
                btnShow.Enabled = true;

            }
            else
            {
                MessageBox.Show("請輸入各科正確成績");
                return;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (StDataList.Count > 0)
            {
                StDataList.RemoveAt(StDataList.Count - 1);
            }

            // 將 label.Text 以換行符號分割成多行
            string[] lines = labScoreList.Text.Split('\n');
            // 移除第N行
            lines = lines.Where((line, index) => index != count - 1).ToArray();
            // 合併回一個字串
            labScoreList.Text = string.Join("\n", lines);

            if (count > 0)
            {
                count--;
            }

            if (count == 0)
            {
                btnShow.Enabled = false;
            }

            if (List.Items.Count == 0)
            {
                List.Items.Clear();
            }
            else if (List.Items.Count > 0)
            {
                List.Items.RemoveAt(List.Items.Count - 1);
            }

            if (List.Items.Count == 0)
            {
                btnShow.Enabled = false;
            }
        }

        private void btnSer_Click(object sender, EventArgs e)
        {
            //不會內容
            int num1, num2;
            if (int.TryParse(txtNum1.Text, out num1) && int.TryParse(txtNum2.Text, out num2) && num1 >= 0 && num2 >= 0 && num1 <= 100 && num2 <= 100)
            {
                labScoreList.Text = "";
                List.Items.Clear();
                List<StData> filteredData = StDataList
               .Where(stData => stData.CnScore >= num1 && stData.CnScore <= num2)
               .Select(stData => new StData
               {
                   StName = stData.StName,
                   CnScore = stData.CnScore,
                   EnScore = stData.EnScore,
                   MathScore = stData.MathScore,
                   SumScore = stData.SumScore,
                   AvgScore = stData.AvgScore,
                   MaxScore = stData.MaxScore,
                   MinScore = stData.MinScore
               }
                )
               .ToList();
                foreach (var data in filteredData)
                {
                    ListViewItem item = new ListViewItem(data.StName);
                    item.SubItems.Add(Convert.ToString(data.CnScore));
                    item.SubItems.Add(Convert.ToString(data.EnScore));
                    item.SubItems.Add(Convert.ToString(data.MathScore));
                    item.SubItems.Add(Convert.ToString(data.SumScore));
                    item.SubItems.Add(Convert.ToString(data.AvgScore));
                    int mm = Math.Min(data.CnScore, Math.Min(data.EnScore, data.MathScore));
                    if (mm == data.CnScore)
                    {
                        item.SubItems.Add($"國文{Convert.ToString(mm)}");
                    }
                    else if (mm == data.EnScore)
                    {
                        item.SubItems.Add($"英文{Convert.ToString(mm)}");
                    }
                    else
                    {
                        item.SubItems.Add($"數學{Convert.ToString(mm)}");
                    }

                    List.Items.Add(item);
                    //labScoreList.Text += $"{data.StName}     {data.CnScore}     {data.EnScore}     {data.MathScore}     {data.SumScore}   {data.AvgScore}  {data.MaxScore}  {data.MinScore}\n";

                    //string output = "";
                    //if (data.MinScore == data.CnScore)
                    //{
                    //    output += "國文" + data.CnScore + "  ";
                    //}
                    //else if (data.MinScore == data.EnScore)
                    //{
                    //    output += "英文" + data.EnScore + "  ";
                    //}
                    //else
                    //{
                    //    output += "數學" + data.MathScore + "  ";
                    //}
                    //if (data.MaxScore == data.CnScore)
                    //{
                    //    output += "國文" + data.CnScore;
                    //}
                    //else if (data.MaxScore == data.EnScore)
                    //{
                    //    output += "英文" + data.EnScore;
                    //}
                    //else
                    //{
                    //    output += "數學" + data.MathScore;
                    //}

                    //labScoreList.Text += $"{data.StName,5:0}{data.CnScore,10:0}{data.EnScore,10:0}{data.MathScore,10:0}{data.SumScore,16:0}{data.AvgScore,8:0}  {output,10:0}\n";

                    // item.SubItems.Add(Convert.ToString(Math.Min(stData.CnScore,Math.Min(stData.EnScore,stData.MathScore))));
                    //int MM = Math.Max(data.CnScore, Math.Max(data.EnScore, data.MathScore));
                    //if (MM == data.CnScore)
                    //{
                    //    item.SubItems.Add($"國文{Convert.ToString(MM)}");
                    //}
                    //else if (MM == data.EnScore)
                    //{
                    //    item.SubItems.Add($"英文{Convert.ToString(MM)}");
                    //}
                    //else
                    //{
                    //    item.SubItems.Add($"數學{Convert.ToString(MM)}");
                    //}
                }
            }
            else
            {
                MessageBox.Show("請輸入0~100內數字!");
                return;
            }
        }


    }
}
