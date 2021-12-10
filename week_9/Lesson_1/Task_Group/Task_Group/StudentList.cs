using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Task_Group
{
    class StudentList
    {
        private List<Student> _students;
        public List<Student> Students { get { return _students; } }

        public StudentList()
        {
            _students = new List<Student>();
        }

        public void AddStudent(string name, string surename, int groupid)
        {
            try
            {
                Student student = new Student(name, surename, groupid);
                _students.Add(student);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Student GetFindStudent(int id)
        {
            Student student = _students.Find(e => e.Id == id);
            if (student != null)
                return student;
            else
                throw new Exception("Not Found This Student");
        }

        public void RemoveStudent(int id)
        {
            try
            {
                Student student = GetFindStudent(id);
                _students.Remove(student);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateStudent(int id,string name,string surename)
        {
            try
            {
                Student student = GetFindStudent(id);
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surename))
                    throw new Exception("We Not Use This Name and SureName");
                else
                {
                    student.Update(name, surename);
                }

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
