using System;
using System.Drawing;
using System.Windows.Forms;

namespace Potentiometer
{
    public partial class Potentiometer: UserControl
    {
        private float rRadius = 120f;
        private float radius = 100f;
        private float angle = 0f;
        private float k = .05f; 

        private PointF oldLocation = new PointF();
        private Graphics g;

        // Создаем перья
        Pen bPen = new Pen(Color.Black, 1f);

        /// <summary>
        /// Хранит в себе список делегатов выполняемых при вращение плашки
        /// </summary>
        public event EventHandler ChangeValuePotentiometer;

        public float Value {
            get
            {
                return angle * (180 / (float)Math.PI);
            }
        }

        public Potentiometer()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
        }

        private void Potentiometer_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            // Рисуем круг
            g.DrawEllipse(bPen, Width / 2 - radius, Height / 2 - radius, radius * 2, radius * 2);

            // Рисуем меку на плашке
            double a = angle - Math.PI / 2;

            g.DrawLine(bPen, (float)(radius * Math.Cos(a)) + Width / 2,
            (float)(radius * Math.Sin(a)) + Height / 2,
            (float)((radius - 5) * Math.Cos(a)) + Width / 2,
            (float)((radius - 5) * Math.Sin(a)) + Height / 2);


            // Рисуем риски 
            for (float riskAngle = 0; riskAngle <= 300f; riskAngle += 300f / 6.0f)
            {
                float risckA = riskAngle * ((float)Math.PI / 180f) - (float)Math.PI / 2;

                g.DrawLine(bPen, (float)(rRadius * Math.Cos(risckA)) + Width / 2,
                (float)(rRadius * Math.Sin(risckA)) + Height / 2,
                (float)((rRadius - 5) * Math.Cos(risckA)) + Width / 2,
                (float)((rRadius - 5) * Math.Sin(risckA)) + Height / 2);
            }

        }

        private void Potentiometer_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                angle += (e.Location.X < oldLocation.X) ? -k : k;
                
                // Корректировка значения угла от 0 до 300 градусов
                if (angle <= 0f) angle = 0f;
                else if (angle >= (300f * (Math.PI / 180f))) angle = 300f * ((float)Math.PI / 180f);

                oldLocation = e.Location;
                this.OnChangeValuePotentiometer(EventArgs.Empty);
                Invalidate();
            }
        }

        /// <summary>
        /// Метод выполняющий делегаты, подписанных на событие ChangeValuePotentiometer
        /// </summary>
        /// <param name="e">Аргументы события</param>
        protected virtual void OnChangeValuePotentiometer(EventArgs e)
        {
            // Проверка на пустату списка делегатов подписанных на это событие
            if (ChangeValuePotentiometer != null) ChangeValuePotentiometer(this, e);
        }
    }
}
