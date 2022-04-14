using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Sturdent
    {
        private string _id;
        private string _name;
        private string _major;
        private string _gpa;
        private string v1;
        private string v2;
        private string v3;

        public Sturdent(string v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public Sturdent(string id, string name, string major ,string GPA)
        { 
          this._id = id;
            this._name = name;  
            this._major = major;
            this._gpa = GPA;
        }
    }
}
