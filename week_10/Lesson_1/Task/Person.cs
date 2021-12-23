using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileWork
{
    public class Person
    {
        private static int total;
        private int _id;
        public int Id
        {
            get { return _id; }
            

        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                try
                {
                    if (String.IsNullOrEmpty(value))
                    {
                        throw new Exception("Not Use This Name");
                    }
                    else
                    {
                        _name = value;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                    if (String.IsNullOrEmpty(value))
                    {
                        throw new Exception("Not Use This Name");
                    }
                    else
                    {
                        _surename = value;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }


        private string _email;
        public string E_mail
        {
            get { return _email; }

            set
            {
                try
                {
                    MailAddress mail = new MailAddress(value);
                    if (mail != null)
                        _email = value;
                    else
                        throw new Exception("Not Use This Email");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public string Img_Location;

        public Person(string name,string surename,string email,string img_location)
        {
            ++total;
            this._id = total;
            this._name = name;
            this._surename = surename;
            this.Img_Location = img_location;
            this.E_mail = email;
        }

        public override string ToString()
        {
            return $"{Name} {SureName} ";
        }

    }
}
