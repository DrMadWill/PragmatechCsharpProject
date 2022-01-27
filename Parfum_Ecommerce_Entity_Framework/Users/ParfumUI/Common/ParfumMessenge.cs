using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParfumUI.Common
{
    public static class ParfumMessenge
    {
        public static void Warning(string name)
        {
            MessageBox.Show(name, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Error(string name)
        {
            MessageBox.Show(name, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool IsAreYouSure(string name)
        {
            bool isSure = false;
            DialogResult result = MessageBox.Show(name, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                isSure = true;
            }
            return isSure;
        }
    }
}
