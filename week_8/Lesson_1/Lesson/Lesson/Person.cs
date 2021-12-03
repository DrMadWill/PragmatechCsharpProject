using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Lesson
{
    class Person
    {
        private string _name;
        public string Name 
        {
            get { return _name; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value.Trim()) || value.Length<2)
                        throw new Exception("Nul,Empty or Length < 2");

                    _name = value;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private string _dadname;
        public string DadsName
        {
            get { return _dadname; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value.Trim()) || value.Length < 2)
                        throw new Exception("Nul,Empty or Length < 2");

                    _dadname = value;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private string _surename;
        public string SureName
        {
            get { return _surename; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value.Trim()) || value.Length < 2)
                        throw new Exception("Nul,Empty or Length < 2");

                    _surename = value;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }






    }
}
