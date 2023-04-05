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
//原作業內容 加上cmb struct 跟enum的應用練習
namespace  CsharpHomework
{
    public partial class _01HwHelloForm : Form
    {
        public _01HwHelloForm()
        {
            InitializeComponent();
        }

        struct Data
        {
            public string Name;
            public string enName;
            public Sex sex;
            public Sign sign;
        }

        public enum Sex
            {
              男=1,
              女=2,
              其他=3,
            }
        public enum Sign
        {
            雙魚座=1,
            白羊座=2,
            金牛座=3,
            雙子座=4,
            巨蟹座=5,
            獅子座=6,
            處女座=7,
            天秤座=8,
            天蠍座=9,
            射手座=10,
            魔羯座=11,
            水瓶座=12,
        }


        private void label1_Click(object sender, EventArgs e)
        {
          Data hellowdata= new Data();
          hellowdata.Name=txtName.Text;
          hellowdata.enName=txtenName.Text;
           
            // 從 cmbSex ComboBox 獲取選擇的 Sex 枚舉值
            if (cmbSex.SelectedItem != null)
            {
                hellowdata.sex = (Sex)cmbSex.SelectedItem;
            }
            else
            {
                MessageBox.Show("請選擇性別。");
                return;
            }

            // 從 cmbSign ComboBox 獲取選擇的 Sign 枚舉值
            if (cmbSign.SelectedItem != null)
            {
                hellowdata.sign = (Sign)cmbSign.SelectedItem;
            }
            else
            {
                MessageBox.Show("請選擇星座。");
                return;
            }


            MessageBox.Show("Hello!"+"\n"+"我的名字是 " + hellowdata.Name+"\n"+"英文名是 "
                +hellowdata.enName+"\n"+"性別是 "+hellowdata.sex+"\n"+"星座是 "+hellowdata.sign+"\n"+"很高興認識你!");
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            Data hidata = new Data();
            hidata.Name = txtName.Text;
            hidata.enName = txtenName.Text;

            if (Enum.TryParse(txtSex.Text, out Sex sexValue))
            {
                hidata.sex = sexValue;
            }
            else
            {
                MessageBox.Show("無效的性別，請重新輸入。");
                return;
            }

            // 将文本框中的输入转换为 Sign 枚举值
            if (Enum.TryParse(txtSign.Text, out Sign signValue))
            {
                hidata.sign = signValue;
            }
            else
            {
                MessageBox.Show("無效的星座，請重新輸入。");
                return;
            }
            MessageBox.Show("Hi!" + "\n" + "我的名字是 " + hidata.Name + "\n" + "英文名是 "
               + hidata.enName + "\n" + "性別是 " + hidata.sex + "\n" + "星座是 " + hidata.sign + "\n" + "很高興認識你!");
        }

        private void Homework01_Load(object sender, EventArgs e)
        {
            foreach (Sex sex in Enum.GetValues(typeof(Sex)))
            {
                cmbSex.Items.Add(sex);
            }

            foreach (Sign sign in Enum.GetValues(typeof(Sign)))
            {
                cmbSign.Items.Add(sign);
            }
        }

    }
}
