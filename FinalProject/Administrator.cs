using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    public class Administrator
    {
        private List<ICommand> _students = new List<ICommand>();

        public void Add(ICommand command)
        {
            _students.Add(command);
        }
        public void ExecuteAll()
        {
            foreach (var student in _students)
            {
                student.Execute();
            }
            _students.Clear();
        }
    }
}
