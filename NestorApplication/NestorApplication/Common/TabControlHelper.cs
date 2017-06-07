using System.Windows.Forms;

namespace NestorApplication.Common
{
    public class TabControlHelper
    {
        public static void SetTabProperties(params Form[] forms)
        {
            foreach (var form in forms)
            {
                form.TopLevel = false;
                form.Visible = true;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
            }
        }
    }
}
