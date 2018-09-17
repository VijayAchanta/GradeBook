using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class GradeBook
    {
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0;
            foreach (float grade in grades)
            {
                sum += grade;
            }
            if (grades.Count > 0)
            {
                stats.AverageGrade = sum / grades.Count;
                stats.HighestGrade = grades.Max();
                stats.LowestGrade = grades.Min();
            }
            return stats;
        }
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if(_name != value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.existingName = _name;
                        args.newName = value;
                        NameChanged(this, args); 
                    }
                    _name = value;
                }
            }
        }
        public event NameChangedDelegate NameChanged;
        private string _name;
        private List<float> grades;
    }
}
