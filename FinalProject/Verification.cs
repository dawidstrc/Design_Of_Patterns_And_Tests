using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    public class Verification
    {
        public void Album_Number_Verification(int albumnumber, string name, string surname)
        {

            string conversion = albumnumber.ToString();

            int length = conversion.Length;

            if(length > 6)
            {
                Console.WriteLine("Student ( {0} {1} ) posiada za dlugi numer albumu i zostaje usuniety\n", name, surname);

                for (int i = 0; i < Student.studentsList.Count; i++)
                {
                    if(Student.studentsList[i]._albumnumber == albumnumber)
                    {
                        Student.studentsList.Remove(Student.studentsList[i]);
                    }
                }
                
            }

        }
    }
}
