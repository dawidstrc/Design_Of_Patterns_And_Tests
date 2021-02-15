using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    public class Promoter : IObserver
    {
        public static List<Promoter> promotersList = new List<Promoter>();
        public int _id { get; set; }
        public string _name { get; set; }
        public string _surname { get; set; }

        public Promoter(int id, string name, string surname)
        {
            this._id = id;
            this._name = name;
            this._surname = surname;
        }

        public void Update(Thesis thesis)
        {
            ThesisStatus status = thesis.Status;

            Console.WriteLine("Powiadomienie dla Promotora: {0} {1}", this._name, this._surname);
            Console.WriteLine("Status Pracy: {0}", status);
        }

    }
}
