
namespace Hcccount
{
    partial class FormStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDemonstration = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDemonstration
            // 
            this.buttonDemonstration.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDemonstration.Location = new System.Drawing.Point(200, 52);
            this.buttonDemonstration.Name = "buttonDemonstration";
            this.buttonDemonstration.Size = new System.Drawing.Size(408, 95);
            this.buttonDemonstration.TabIndex = 0;
            this.buttonDemonstration.Text = "Запустить демонстрацию";
            this.buttonDemonstration.UseVisualStyleBackColor = true;
            this.buttonDemonstration.Click += new System.EventHandler(this.buttonDemonstration_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(200, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(408, 95);
            this.button1.TabIndex = 1;
            this.button1.Text = "Запустить задачи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDemonstration);
            this.Name = "FormStart";
            this.Text = "Hcccount";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDemonstration;
        private System.Windows.Forms.Button button1;
    }
}