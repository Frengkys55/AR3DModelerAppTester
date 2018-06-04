using System.Drawing;
using System.Windows.Forms;

namespace AR3DModelerAppTester
{
    public static class ThreadHelperClass
    {
        delegate void SetTextCallback(Form f, Control ctrl, string text);
        delegate void SetImageCallback(Form f, PictureBox pictureBox, Bitmap source);
        delegate void SetFormIconCallback(Form f, Form ctrl, Icon source);
        public static void SetText(Form form, Control ctrl, string text)
        {
            if (ctrl.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                form.Invoke(d, new object[] { form, ctrl, text });
            }
            else
            {
                ctrl.Text = text;
            }
        }
        public static void SetImage(Form form, PictureBox ctrl, Bitmap source)
        {
            if (ctrl.InvokeRequired)
            {
                SetImageCallback d = new SetImageCallback(SetImage);
                form.Invoke(d, new object[] { form, ctrl, source });
            }
            else
            {
                ctrl.Image = source;
            }
        }
        public static void SetIcon(Form form, Form  ctrl, Icon source)
        {
            if (ctrl.InvokeRequired)
            {
                SetFormIconCallback d = new SetFormIconCallback(SetIcon);
                form.Invoke(d, new object[] { form, ctrl, source });
            }
            else
            {
                ctrl.Icon = source;
            }
        }
    }
}
