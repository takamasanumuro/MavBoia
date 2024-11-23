using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MavBoia.Utilities
{
    internal class FormResizer
    {
        Form form;
        Size originalFormSize;
        Dictionary<Control, Rectangle> rectangles = new Dictionary<Control, Rectangle>();
        Dictionary<Control, float> fontSizes = new Dictionary<Control, float>();

        public FormResizer(Form form)
        {
            this.form = form;
        }

        public void InitializeResizer()
        {
            originalFormSize = form.Size;
            StoreControlsRectangle(form);
        }


        private void ResizeControl(Rectangle r, Control c, Size originalFormSize)
        {
            float xRatio = (float)(form.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(form.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void AdjustControlFontSize(Control c)
        {
            float scaleAdjustmentFactor = 0.4f;

            // Define um fator de escala com base na altura ou largura do label
            float scaleFactor = (float)(c.Width * c.Height) / (float)(rectangles[c].Width * rectangles[c].Height);

            // Calcula o novo tamanho da fonte
            float newFontSize = fontSizes[c] * (1 + (scaleFactor - 1) * scaleAdjustmentFactor);

            // Cria uma nova fonte com o tamanho ajustado
            c.Font = new Font(c.Font.FontFamily, newFontSize, c.Font.Style);
        }

        private void StoreControlsRectangle(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                rectangles.Add(c, new Rectangle(c.Location.X, c.Location.Y, c.Width, c.Height));

                if (c is Label || c is Button)
                    fontSizes.Add(c, c.Font.Size);

                if (c.Controls.Count > 0)
                {
                    StoreControlsRectangle(c);
                }
            }
        }


        public void ResizeAll()
        {
            form.SuspendLayout();
            foreach (Control c in rectangles.Keys)
            {
                ResizeControl(rectangles[c], c, originalFormSize);
            }

            foreach (Control c in fontSizes.Keys)
            {
                AdjustControlFontSize(c);
            }
            form.ResumeLayout();
        }
    }
}
