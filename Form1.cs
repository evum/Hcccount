using System;
using System.IO;
using System.Windows.Forms;


namespace WindowsFormsApp1
{


    public partial class Form1 : Form
    {
        private const String NULL_DAVL = "Упс, давление слишком низкое. Думать, как построить ловушку, убегая от мамонта, " +
            "пока предыдущий не переварился, не получается!";
        private const String TOOLOWPRESSURE = "Давление слишком низкое";
        private const String DEAD = "Вы убили его!";

        private Result body = new Result();
        public Form1()
        {
            InitializeComponent();
            Height = SystemInformation.PrimaryMonitorSize.Height;
            Width = SystemInformation.PrimaryMonitorSize.Width;
            label6.Text = String.Format("Текущее значение: {0}", trackBarHcc.Value);
            body.shet();
            Print();
            position();
        }

        

        private void trackBarHcc_Scroll(object sender, EventArgs e)
        {
            label6.Text = String.Format("Текущее значение: {0}", trackBarHcc.Value);
            body.SetNums("Hcc", trackBarHcc.Value);
            body.shet();
            Print();
        }
        private void buttonHcc_Click(object sender, EventArgs e)
        {

            labelHcc.Visible = !labelHcc.Visible;
            trackBarHcc.Visible = !trackBarHcc.Visible;
            label6.Visible = !label6.Visible;
        }
        private void buttonOpss3_Click(object sender, EventArgs e)
        {
            labelOpss3.Visible = !labelOpss3.Visible;
            trackBarOpss3.Visible = !trackBarOpss3.Visible;

        }

        private void buttonOpss1_Click(object sender, EventArgs e)
        {
            labelOpss1.Visible = !labelOpss1.Visible;
            trackBarOpss1.Visible = !trackBarOpss1.Visible;


        }

        private void buttonOck_Click(object sender, EventArgs e)
        {
            labelOck.Visible = !labelOck.Visible;
            trackBarOck.Visible = !trackBarOck.Visible;
        }

        private void buttonOpss2_Click(object sender, EventArgs e)
        {
            labelOpss2.Visible = !labelOpss2.Visible;
            trackBarOpss2.Visible = !trackBarOpss2.Visible;
        }

        private void trackBarOpss1_Scroll(object sender, EventArgs e)
        {
            body.SetNums("Opss1", trackBarOpss1.Value);
            body.shet();
            Print();

        }

        private void trackBarOpss2_Scroll(object sender, EventArgs e)
        {
            body.SetNums("Opss2", trackBarOpss2.Value);
            body.shet();
            Print();
        }

        private void trackBarOpss3_Scroll(object sender, EventArgs e)
        {
            body.SetNums("Opss3", trackBarOpss3.Value);
            body.shet();
            Print();
        }

        private void trackBarOck_Scroll(object sender, EventArgs e)
        {
            body.SetNums("Ock", trackBarOck.Value);
            body.shet();
            Print();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            textBoxS.Visible = !textBoxS.Visible;
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            textBoxD.Visible = !textBoxD.Visible;
        }
        public void Print()
        {

            if (body.HighPressure())
            {
                textBoxS.Text = DEAD;
                textBoxD.Text = DEAD;
                textBoxA.Text = DEAD;
                textBoxV.Text = DEAD;
                textBoxK.Text = DEAD;
                textBoxK_1.Text = DEAD;
                textBoxK_2.Text = DEAD;
                textBoxK_3.Text = DEAD;
            }
            else if (body.LowPressure())
            {
                MessageBox.Show(
                NULL_DAVL,
                "Многозадачность не поддерживается",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                textBoxS.Text = TOOLOWPRESSURE;
                textBoxD.Text = TOOLOWPRESSURE;
                textBoxA.Text = TOOLOWPRESSURE;
                textBoxV.Text = TOOLOWPRESSURE;
                textBoxK.Text = TOOLOWPRESSURE;
                textBoxK_1.Text = TOOLOWPRESSURE;
                textBoxK_2.Text = TOOLOWPRESSURE;
                textBoxK_3.Text = TOOLOWPRESSURE;
            }
            else
            {
                var nums = body.GetNums();
                textBoxS.Text = "Систолическое: " + nums["Sistol"].ToString();
                textBoxD.Text = "Диастолическое: " + nums["Diastol"].ToString();
                textBoxA.Text = "Артериолы: " + nums["Arter"].ToString();
                textBoxV.Text = "Венулы: " + nums["Venul"].ToString();
                textBoxK.Text = "Капилляры: " + nums["Kapil"].ToString();
                textBoxK_1.Text = "Кровоток 1: " + nums["Krov1"].ToString();
                textBoxK_2.Text = "Кровоток 2: " + nums["Krov2"].ToString();
                textBoxK_3.Text = "Кровоток 3: " + nums["Krov3"].ToString();
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            textBoxA.Visible = !textBoxA.Visible;
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            textBoxV.Visible = !textBoxV.Visible;
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            textBoxK.Visible = !textBoxK.Visible;
        }

        private void buttonK_1_Click(object sender, EventArgs e)
        {
            textBoxK_1.Visible = !textBoxK_1.Visible;
        }

        private void buttonK_2_Click(object sender, EventArgs e)
        {
            textBoxK_2.Visible = !textBoxK_2.Visible;
        }

        private void buttonK_3_Click(object sender, EventArgs e)
        {
            textBoxK_3.Visible = !textBoxK_3.Visible;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonOpenAll_Click(object sender, EventArgs e)
        {
            buttonK_1_Click(this, e);
            buttonK_2_Click(this, e);
            buttonK_3_Click(this, e);
            buttonOck_Click(this, e);
            buttonOpss1_Click(this, e);
            buttonOpss2_Click(this, e);
            buttonOpss3_Click(this, e);
            buttonS_Click(this, e);
            buttonV_Click(this, e);
            buttonD_Click(this, e);
            buttonHcc_Click(this, e);
            buttonA_Click(this, e);
            buttonK_Click(this, e);
        }

        private void checkBoxNerv_CheckedChanged(object sender, EventArgs e)
        {
            var res = body.NervRegulation();
            labelNervComp.Text = "Значение опсс1 должно быть: " + res[0] + "\nЗначение опсс2 должно быть: " + res[1] + "\nЗначение оцк должно быть: " + res[2];
            
        }

        private void trackBarRun_Scroll(object sender, EventArgs e)
        {
            body.NervSetNums("Run", trackBarRun.Value);
            if (checkBoxNerv.Checked == true)
            {
                checkBoxNerv_CheckedChanged(this, e);
            }

        }

        private void trackBarEat_Scroll(object sender, EventArgs e)
        {
            body.NervSetNums("Eat", trackBarEat.Value);
            if (checkBoxNerv.Checked == true)
            {
                checkBoxNerv_CheckedChanged(this, e);
            }
        }

        private void trackBarThink_Scroll(object sender, EventArgs e)
        {
            body.NervSetNums("Think", trackBarThink.Value);
            if (checkBoxNerv.Checked == true)
            {
                checkBoxNerv_CheckedChanged(this, e);
            }
        }

        public void position()
        {
            int startPoint = 100;
            int stepForLabel = 16;
            int stepForTrackBar = 64;
            int[] coory = new int[8];
            for (int i = 0; i < 4; i++)
            {
                coory[i] = Height - (startPoint + i * stepForTrackBar);
            }
            for (int i = 4; i < coory.Length; i++)
            {
                coory[i] = coory[i - 4] - stepForLabel;
            }
            trackBarOck.Location = new System.Drawing.Point(Width - 300, coory[0]);
            trackBarOpss1.Location = new System.Drawing.Point(Width - 300, coory[1]);
            trackBarOpss2.Location = new System.Drawing.Point(Width - 300, coory[2]);
            trackBarOpss3.Location = new System.Drawing.Point(Width - 300, coory[3]);
            labelOck.Location = new System.Drawing.Point(Width - 269, coory[4]);
            labelOpss1.Location = new System.Drawing.Point(Width - 269, coory[5]);
            labelOpss2.Location = new System.Drawing.Point(Width - 269, coory[6]);
            labelOpss3.Location = new System.Drawing.Point(Width - 269, coory[7]);

        }

        private void buttonNerv_Click(object sender, EventArgs e)
        {
            var res = body.NervRegulation();
            labelNervComp.Text = "Значение опсс1 должно быть: " + res[0] + "\nЗначение опсс2 должно быть: " + res[1] + "\nЗначение оцк должно быть: " + res[2] + "\nЗначение X: " + res[3];
            
            
        }

        private void buttonSaveLog_Click(object sender, EventArgs e)
        {
            var res = body.NervRegulation();
            var nums = body.GetNums();

            string path = "D:\\HccDataLog\\";
            string fileName = path + "data" + DateTime.Today.ToShortDateString() + ".txt";

            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            try
            {
                using (FileStream sw = new FileStream(fileName, FileMode.Append))
                {
                    byte[] writingString = System.Text.Encoding.Default.GetBytes("\n*********** " + "\nOпсс1: " + res[0] + "      Опсс2: " + res[1] + "       Оцк: " + res[2] + "      x: " + res[3]
                        + "\nЧсс: " + nums["Hcc"] + "      Oпсс1: " + nums["Opss1"] + "      Oпсс2: " + nums["Opss2"]
                        + "      Oпсс3: " + nums["Opss3"] + "      Ock: " + nums["Ock"] + "\n\n\n");
                    sw.Write(writingString, 0, writingString.Length);
                }
            }
            catch (Exception r)
            {
                Console.WriteLine(r.Message);
            }
        }
    }
}
