namespace vp_lab_6
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.potentiometer = new Potentiometer.Potentiometer();
            this.SuspendLayout();
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(145, 318);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.ReadOnly = true;
            this.textBoxValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxValue.TabIndex = 1;
            this.textBoxValue.Text = "0.00";
            // 
            // potentiometer
            // 
            this.potentiometer.Location = new System.Drawing.Point(47, 12);
            this.potentiometer.Name = "potentiometer";
            this.potentiometer.Size = new System.Drawing.Size(300, 300);
            this.potentiometer.TabIndex = 0;
            this.potentiometer.ChangeValuePotentiometer += new System.EventHandler(this.potentiometer_ChangeValuePotentiometer);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 358);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.potentiometer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Potentiometer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Potentiometer.Potentiometer potentiometer;
        private System.Windows.Forms.TextBox textBoxValue;
    }
}

