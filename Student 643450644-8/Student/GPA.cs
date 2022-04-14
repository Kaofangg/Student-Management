using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class GPA
    {
        private double sum = 0;
        private int n = 0;
        private double max = 0;
        private double min = 0;

        private string alldata = string.Empty;
        private string name = string.Empty;
      
        /// <summary>
        /// Add new GPA to class
        /// </summary>
        /// <param name="gpa"></param>
        /// <param name="name"></param>
        public void addGPA(double gpa, string name)
        {
            this.sum += gpa;
            this.n++;
            this.alldata += name + "" + gpa + Environment.NewLine;


            if (this.max < gpa)
            {
                this.max = gpa;
                this.name = name;
            }
            if (this.min > gpa)
            {
                this.min = gpa;
                this.name = name;
            }
        }
        /// <summary>
        /// return gpax of class
        /// </summary>
        /// <returns></returns>
        public double getGPAx()
        {
            double result = this.sum / this.n;
            return result;
        }
        public double getMax()
        {
            return this.max;
        }
        public double getMin()
        {
            return this.min;
        }
    }
}
