using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalityApp
{
    public class ResizeHandler
    {
        // Explicitly specify the type of the dictionary for C# 7.3 compatibility
        private readonly Dictionary<Control, Tuple<Size, Point>> controlOriginalSizes = new Dictionary<Control, Tuple<Size, Point>>();
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Adds a control to the dictionary with its original size and location.
        /// </summary>
        public void AddControl(Control control)
        {
            // Using Tuple instead of value tuple for compatibility with C# 7.3
            controlOriginalSizes[control] = new Tuple<Size, Point>(control.Size, control.Location);
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Resizes all controls on the form based on the form's current size.
        /// </summary>
        public void ResizeControls(Form form)
        {
            foreach (var control in controlOriginalSizes)
            {
                var originalSize = control.Value.Item1;
                var originalLocation = control.Value.Item2;
                var controlToResize = control.Key;

                float xRatio = (float)form.ClientSize.Width / form.MinimumSize.Width;
                float yRatio = (float)form.ClientSize.Height / form.MinimumSize.Height;

                controlToResize.Size = new Size((int)(originalSize.Width * xRatio), (int)(originalSize.Height * yRatio));
                controlToResize.Location = new Point((int)(originalLocation.X * xRatio), (int)(originalLocation.Y * yRatio));
            }
        }
    }
}
        //---------------------------------------- END OF FILE -------------------------------------------------------//
