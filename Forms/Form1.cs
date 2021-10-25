using System;
using System.Collections.Generic;
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

        private string path = "";

        private Result body = new Result();
        public Form1()
        {
            InitializeComponent();
            Height = SystemInformation.PrimaryMonitorSize.Height;
            Width = SystemInformation.PrimaryMonitorSize.Width;
            label6.Text = String.Format("Текущее значение: {0}", trackBarHcc.Value);
            body.shet();
            Print();
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

        /// <summary>
        /// Функция вывода результатов вычислений
        /// </summary>
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


        /// <summary>
        /// функция нажатия на кнопку нерва-депрессора
        /// </summary>
        private void buttonNerv_Click(object sender, EventArgs e)
        {
            Dictionary<String, bool> WhatIsBlocked = new Dictionary<string, bool>();
            WhatIsBlocked = WhichIsBlocked(WhatIsBlocked);
            double sistol;
            double diastol;
            var res = body.NervRegulation(WhatIsBlocked); // Вызов функции поиска новых значений
            sistol = body.res_s(res["Hcc"], res["Opss1"], res["Opss2"], res["Opss3"], res["Ock"]); // Подсчёт систолического давления для новых значений
            diastol = body.res_d(res["Hcc"], res["Opss1"], res["Opss2"], res["Opss3"], res["Ock"]);// Подсчёт диастолического давления для новых значений
            labelNervComp.Text = "Диастолическое: " + "\nЗначение опсс1 должно быть: " + res["Opss1"] + "\nЗначение опсс2 должно быть: " +
                res["Opss2"] + "\nЗначение оцк должно быть: " + res["Opss3"] + "\nЗначение оцк должно быть: " + res["Ock"] + "\nЗначение Чсс: " + res["Hcc"] + "\nСистолическое: " + sistol +
                "\nДиастолическое: " + diastol; //Вывод всех значений

        }


        /// <summary>
        /// Функция сохранения результатов вычислений в файл
        /// </summary>
        private void buttonSaveLog_Click(object sender, EventArgs e)
        {
            /*var res = body.NervRegulation();
            var nums = body.GetNums();

            FolderBrowserDialog logDialog = new FolderBrowserDialog();

            if (path == "")
            {
                logDialog.ShowDialog();
                path = logDialog.SelectedPath;
            }

            string fileName = path + "\\data" + DateTime.Today.ToShortDateString() + ".txt";

            try
            {
                using (FileStream sw = new FileStream(fileName, FileMode.Append))
                {
                    byte[] writingString = System.Text.Encoding.Default.GetBytes("\n*********** " + "\nDiastol ==============" + "\nOpss1: " + res[0][0] + "      Opss2: " + res[0][1] + "       Ock: " + res[0][2] + "      x: " + res[0][3]
                        + "\nSistol ========================= " + "\nOpss1: " + res[1][0] + "      Opss2: " + res[1][1] + "       Ock: " + res[1][2] + "      x: " + res[1][3]
                        + "\nData =================" + "\nHcc: " + nums["Hcc"] + "      Opss1: " + nums["Opss1"] + "      Opss2: " + nums["Opss2"]
                        + "      Opss3: " + nums["Opss3"] + "      Ock: " + nums["Ock"] + "\n\n\n");
                    sw.Write(writingString, 0, writingString.Length);
                }
            }
            catch (Exception r)
            {
                Console.WriteLine(r.Message);
            }*/
        }

        private void checkBoxOckBlock_CheckedChanged(object sender, EventArgs e)
        {
            trackBarOck.Enabled = !trackBarOck.Enabled;
        }

        private void checkBoxOpss3Block_CheckedChanged(object sender, EventArgs e)
        {
            trackBarOpss3.Enabled = !trackBarOpss3.Enabled;
        }

        private void checkBoxOpss2Block_CheckedChanged(object sender, EventArgs e)
        {
            trackBarOpss2.Enabled = !trackBarOpss2.Enabled;
        }

        private void checkBoxOpss1Block_CheckedChanged(object sender, EventArgs e)
        {
            trackBarOpss1.Enabled = !trackBarOpss1.Enabled;
        }

        private void checkBoxHccBlock_CheckedChanged(object sender, EventArgs e)
        {
            trackBarHcc.Enabled = !trackBarHcc.Enabled;
        }

        private Dictionary<String, Boolean> WhichIsBlocked(Dictionary<String, Boolean> WhatIsBlock)
        {
            WhatIsBlock["Opss1"] = !trackBarOpss1.Enabled;
            WhatIsBlock["Opss2"] = !trackBarOpss2.Enabled;
            WhatIsBlock["Opss3"] = !trackBarOpss3.Enabled;
            WhatIsBlock["Ock"] = !trackBarOck.Enabled;
            WhatIsBlock["Hcc"] = !trackBarHcc.Enabled;
            return WhatIsBlock;
        }
    }
}
