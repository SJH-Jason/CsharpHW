using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpHomework
{
    public partial class _07HWMethod : Form
    {
        public _07HWMethod()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int Num;


            if (int.TryParse(txtNum.Text, out Num) && Num > 0)
            {

                if (Num % 2 == 0)
                {
                    labAns.Text = $"數字 {Num} 為偶數";
                }
                else
                {
                    labAns.Text = $"數字 {Num} 為奇數";
                }
            }
            else
            {
                MessageBox.Show($"請輸入正整數的數字!!");
            }

        }

        private void btn122_Click(object sender, EventArgs e)
        {
            int[] arr = new int[] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int S = 0;
            int D = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 2 == 1)
                {
                    S++;
                }
                else
                {
                    D++;
                }
                labAns.Text = $"int陣列 arr[1,5,6,8,7,97,54,887,65,578]\n奇數{S}個，\n偶數{D}個";
            }
        }

        private void btnMm_Click(object sender, EventArgs e)
        {

            int[] arr = new int[] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };

            //for (int i=0;i<arr.Length;i++) 
            //{
            int Max = arr[0];
            int min = arr[0];
            //  Max = Math.Max(Max,Math.Max(arr[0], arr[i]));
            //  min = Math.Min(min,Math.Min(arr[0], arr[i]));

            foreach (int num in arr)
            {
                Max = Math.Max(Max, num);
                min = Math.Min(min, num);
            }

            labAns.Text = $"int陣列 arr[1,5,6,8,7,97,54,887,65,578]\n最大值為{Max}，\n最小值為{min}";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int[] arr = new int[] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int Sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Sum = Sum + arr[i];
                labAns.Text = $"int陣列 arr[1,5,6,8,7,97,54,887,65,578]\n總合為{Sum}";

            }
        }

        private void btnName1_Click(object sender, EventArgs e)
        {
            string[] Str = new string[] { "mother張", "emma", "迪克蕭", "J40", "Candy", "Coconut", "Motherfacker" };
            int Max = 0;

            foreach (string s in Str)
            {
                Max = Math.Max(Max, s.Length);

                labAns.Text = $"srr陣列[\"mother張\",\"emma\",\"迪克蕭\",\"J40\",\"Candy\",\"Coconut\",\"Motherfacker\"]" +
                    $"\n姓名最長的是{s}";
            }


        }

        private void btnName2_Click(object sender, EventArgs e)
        {
            string[] Str = new string[] { "mother張", "emma", "迪克蕭", "J40", "Candy", "Coconut", "Motherfacker" };
            int count = 0;
            foreach (string S in Str)
            {
                char[] chars = S.ToCharArray();

                foreach (char C in chars)
                    if (C == 'C' || C == 'c')
                    {
                        count++;
                        labAns.Text = $"srr陣列[ \"mother張\", \"emma\", \"迪克蕭\", \"J40\", \"Candy\", \"Coconut\", \"Motherfacker\"]有C或c的數量為{count}個";
                    }
            }

        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string output = "";
            int a = 100;
            int b = 50;
            output += $"換位前a={a}，b={b}";

            int temp = a;
            a = b;
            b = temp;
            output += $"\n換位後a={a}，b={b}";
            labAns.Text = output ;
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            int[,] arr2 = new int[10, 10];
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        arr2[i, j] = 1;
                    }
                    else
                    {
                        if (i == 9)
                        {
                            arr2[i, j] = 1;
                        }
                        else
                        {
                            if (j == 0)
                            {
                                arr2[i, j] = 1;
                            }
                            else
                            {
                                if (j == 9)
                                {
                                    arr2[i, j] = 1;
                                }
                                else
                                {
                                    arr2[i, j] = 0;
                                }
                            }
                        }

                    }
                    sb.Append(arr2[i, j]);
                    sb.Append(" ");
                }
                sb.AppendLine();
            }
            labAns.Text = sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] arr2 = new int[10, 10];
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        arr2[i, j] = 0;
                    }
                    else
                    {
                        if (i == 9)
                        {
                            arr2[i, j] = 0;
                        }
                        else
                        {
                            if (j == 0)
                            {
                                arr2[i, j] = 0;
                            }
                            else
                            {
                                if (j == 9)
                                {
                                    arr2[i, j] = 0;
                                }
                                else
                                {
                                    arr2[i, j] = 1;
                                }
                            }
                        }

                    }
                    sb.Append(arr2[i, j]);
                    sb.Append(" ");
                }
                sb.AppendLine();
            }
            labAns.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[,] arr2 = new int[10, 10];
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            arr2[i, j] = 1;
                        }
                        else
                        {
                            arr2[i, j] = 0;
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            arr2[i, j] = 0;
                        }
                        else
                        {
                            arr2[i, j] = 1;
                        }
                    }
                    sb.Append(arr2[i, j]);
                    sb.Append(" ");
                }
                sb.AppendLine();
            }
            labAns.Text = sb.ToString();
        }

        private void btn10to2_Click(object sender, EventArgs e)
        {
            int num10;
            if (int.TryParse(txtNum.Text, out num10))
            {
                string numto2 = Convert.ToString(num10, 2);
                labAns.Text = "10進制數字：" + num10 + " 轉換為2進制為：" + numto2;
            }
            else
            {
                MessageBox.Show("請輸入整數進行判別");
            }

        }

        private void btn10to16_Click(object sender, EventArgs e)
        {
            int num10;
            if (int.TryParse(txtNum.Text, out num10))
            {
                string numto16 = Convert.ToString(num10, 16);
                labAns.Text = "10進制數字：" + num10 + " 轉換為16進制為：" + numto16;
            }
            else
            {
                MessageBox.Show("請輸入整數進行判別");
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            labAns.Text = "Ans";
            txtNum.Text= "";
        }

        private void btntree_Click(object sender, EventArgs e)
        {
            int treehigh;
            if (int.TryParse(txtNum.Text, out treehigh) && treehigh > 1&&treehigh<360)
            {
                StringBuilder tree = new StringBuilder();
                for (int i = 1; i <= treehigh; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        tree.Append("*");
                    }
                    tree.AppendLine();
                }
                labAns.Text = tree.ToString();
            }
            else if (treehigh>=360)
            {
                MessageBox.Show("已超出繪製範圍!");
            }

            else
            {
                MessageBox.Show("請輸入一個大於1的正整數");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Random R = new Random();
            StringBuilder sb = new StringBuilder("樂透號碼為：\n");
            int[] R6 = new int[6];
            int count = 0;

            while (count < 6)
            {
                int randomNumber = R.Next(1, 50);
                //如果新生成的數字randomNumber 不等於R6[]內的數num
                if (!Array.Exists(R6, num => num == randomNumber))
                {
                    R6[count] = randomNumber;
                    count++;
                }
            }
            for (int i = 0; i < R6.Length; i++)
            {
                sb.Append(R6[i]);
                if (i < R6.Length - 1)
                {
                    sb.Append("、");
                }
            }
            labAns.Text = sb.ToString();
        }

        //class Lottery   用 HashSet 生成隨機數方法
        //{
        //    static void Main()
        //    {
        //        // 產生一個隨機數物件
        //        Random random = new Random();

        //        // 儲存已選擇的數字
        //        HashSet<int> selectedNumbers = new HashSet<int>();

        //        // 隨機選擇 6 個不重複的數字
        //        while (selectedNumbers.Count < 6)
        //        {
        //            int randomNumber = random.Next(1, 50);
        //            selectedNumbers.Add(randomNumber);
        //        }

        //        // 輸出選擇的數字
        //        Console.WriteLine("樂透號碼為：");
        //        foreach (int number in selectedNumbers)
        //        {
        //            Console.Write(number + " ");
        //        }
        //    }
        //}

        private void btnlt2_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> lukone = new Dictionary<int, string>()
            {
                {1,"黃琬珺" },
                {2,"林君韋" },
                {3,"林陽" },
                {4,"洪翎華" },
                {5,"張立人" },
                {6,"曾冠倫" },
                {7,"楊啟宏" },
                {8,"劉庭宇" },
                {9,"蔡亞臻" },
                {10,"謝天晟" },
                {11,"謝承佑" },
                {12,"徐謙" },
                {13,"蕭博文" },
                {14,"張皓惟" },
                {15,"林彥廷" },
                {16,"陳維麟" },
                {17,"謝家航" },
                {18,"陳柏彥" },
                {19,"張立濬" },
                {20,"邱瀚賢" },
                {21,"劉孟霖" },
                {22,"葉奕彤" },
                {23,"曾思綺" },
                {24,"黃子芩" },
                {25,"劉易承" },
                {26,"莊松錞" },
                {27,"張佑晨" },
                {28,"從缺" },
                {29,"從缺" },
                {30,"從缺" },
            };


            Random R = new Random();
            StringBuilder sb = new StringBuilder("本日幸運兒：\n");
            int[] R3 = new int[3];
            int count = 0;

            while (count < 3)
            {
                int randomNumber = R.Next(1, 30);

                if (!Array.Exists(R3, num => num == randomNumber))
                {
                    R3[count] = randomNumber;
                    count++;
                }
            }
            for (int i = 0; i < R3.Length; i++)
            {
                string name;

                if (lukone.TryGetValue(R3[i], out name))
                {
                    sb.Append(name);
                }
                else
                {
                    sb.Append($"Unknown ({R3[i]})");
                }
                // 如果不是最後一個名字，則添加一個逗號和空格。
                if (i < R3.Length - 1)
                {
                    sb.Append(", ");
                }
            }
            labAns.Text = sb.ToString();
        }

        private void btn9x9_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder("九九乘法表：\n");
            for (int i = 1; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                int ans = i * j;
                string ansStr = ans.ToString().PadLeft(2, ' '); //PadLeft 將算式結果轉換為字串後填充空格
                sb.Append($" {j}x{i}={ansStr,3}|"); 
                }
                sb.AppendLine();
                labAns.Text = sb.ToString();
            }

        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int Fr, To, St;
            int tal = 0;

            if (int.TryParse(txtFrom.Text, out Fr) && int.TryParse(txtTo.Text, out To) && int.TryParse(txtStep.Text, out St))
            {
                if (Fr > To)
                {
                    tal = 0;
                }
                for (int i = Fr; i <= To; i += St)
                {
                    tal += i;
                }
                labAns.Text = $"{Fr} 到 {To} 相隔 {St} \n 加總為 {tal}";
            }
            else
            {
                MessageBox.Show("請輸入整數值");
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int Fr, To, St;
            int tal = 0;
           
            if (int.TryParse(txtFrom.Text, out Fr) && int.TryParse(txtTo.Text, out To) && int.TryParse(txtStep.Text, out St))
            {
                int i = Fr;
                while (i <=To)
                {
                    tal += i;
                    i += St;
                }
                labAns.Text = $"{Fr} 到 {To} 相隔 {St} \n 加總為 {tal}";
            }
           
            else
            {
                MessageBox.Show("請輸入整數值");
            }

        }
        private void btnDo_Click(object sender, EventArgs e)
        {
            int Fr, To, St;
            int tal = 0;

            if (int.TryParse(txtFrom.Text, out Fr) && int.TryParse(txtTo.Text, out To) && int.TryParse(txtStep.Text, out St))
            {
                int i = Fr;
                do
                {
                    tal += i;
                    i += St;
                }
                while (i <= To);
                labAns.Text = $"{Fr} 到 {To} 相隔 {St} \n 加總為 {tal}";
            }

            else
            {
                MessageBox.Show("請輸入整數值");
            }
        }
    }
}




