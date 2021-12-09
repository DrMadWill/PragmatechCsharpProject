using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Task_Group
{
    class GroupList
    {
        private List<Group> _groups;
        public List<Group> Groups { get { return _groups; } }

        public GroupList()
        {
            _groups = new List<Group>();
        }

        // Add
        public void Add(string name)
        {
            try
            {
                Group group = new Group(name);
                _groups.Add(group);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        // combox
        public List<string> GetGroupNames()
        {
            List<string> names = new List<string>();
            foreach (var item in Groups)
            {
                names.Add(item.Name);
            }
            return names;
        }


        //Search id
        public int GetFindGroupId(string name)
        {
            Group group = _groups.Find(e => e.Name.Trim().ToLower() == name.Trim().ToLower());
            if (group != null)
            {
                return group.Id;
            }
            else
                throw new Exception("Not Found This Group Id ");
        }


        //Search Name
        public string GetFindGroupName(int id)
        {
            Group group = _groups.Find(e => e.Id == id);
            if (group != null)
                return group.Name;
            else
                throw new Exception("Not Foun This Name");
        }


    }
}
