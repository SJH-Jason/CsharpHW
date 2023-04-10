using System.Windows.Forms;

namespace CsharpHomework
{
    public partial class _00HwBase : Form
    {
        public _00HwBase()
        {
            InitializeComponent();
        }

        private void _00HwBase_Load(object sender, EventArgs e)
        {

        }

        private void btn01_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            _01HwHelloForm Hw01 = new _01HwHelloForm();
            Hw01.TopLevel = false;
            Hw01.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(Hw01);
            Hw01.Show();
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            _02Hwrepaymentform Hw02 = new _02Hwrepaymentform();
            Hw02.TopLevel = false;
            Hw02.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(Hw02);
            Hw02.Show();
        }

        private void btn03_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            _03HwPosForm Hw03 = new _03HwPosForm();
            Hw03.TopLevel = false;
            Hw03.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(Hw03);
            Hw03.Show();
        }

        private void btn04_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            _04HwStudentForm Hw04 = new _04HwStudentForm();
            Hw04.TopLevel = false;
            Hw04.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(Hw04);
            Hw04.Show();
        }

        private void btn05_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            _05HwStudentScoreForm Hw05 = new _05HwStudentScoreForm();
            Hw05.TopLevel = false;
            Hw05.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(Hw05);
            Hw05.Show();
        }

        private void btn07_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            _07HWMethod Hw07 = new _07HWMethod();
            Hw07.TopLevel = false;
            Hw07.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(Hw07);
            Hw07.Show();
        }

        private void btn08_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            _08Hwcalculate Hw08= new _08Hwcalculate();
            Hw08.TopLevel = false;
            Hw08.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(Hw08);
            Hw08.Show();
        }

        private void btn010_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            _10HwOXgame Hw10 = new _10HwOXgame();
            Hw10.TopLevel = false;
            Hw10.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(Hw10);
            Hw10.Show();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            //splitContainer2.Panel2.Controls.Clear();
            _11HwScreenSaver Hw11 = new _11HwScreenSaver();
            Hw11.Show();
            //Hw11.TopLevel = false;
            //Hw11.Dock = DockStyle.None;
            ////splitContainer2.Panel2.Controls.Add(Hw11);

        }

        private void btn12_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            _12HwNotepad Hw12 = new _12HwNotepad();
            //Hw12.TopLevel = false;
            //Hw12.Dock = DockStyle.None;
            //splitContainer2.Panel2.Controls.Add(Hw12);
            Hw12.Show();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            _13HwDrawing Hw13 = new _13HwDrawing();
            Hw13.TopLevel = false;
            Hw13.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(Hw13);
            Hw13.Show();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            _14HwPictureViewers Hw14 = new _14HwPictureViewers();
            Hw14.TopLevel = false;
            Hw14.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(Hw14);
            Hw14.Show();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            _15HwGuessNumber Hw15 = new _15HwGuessNumber();
            Hw15.TopLevel = false;
            Hw15.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(Hw15);
            Hw15.Show();
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            _16HwAlarm Hw16 = new _16HwAlarm();
            Hw16.TopLevel = false;
            Hw16.Dock = DockStyle.None;
            splitContainer2.Panel2.Controls.Add(Hw16);
            Hw16.Show();
        }
    }
}

