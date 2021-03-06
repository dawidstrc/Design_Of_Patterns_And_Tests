﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    public class Student : IObserver, ICommand
    {
        private Verification _verification;
        public static List<Student> studentsList = new List<Student>();
        public string _name { get; set; }
        public string _surname { get; set; }
        public int _albumnumber { get; set; }
        public string _email { get; set; }
        public Student(Verification verification, string name, string surname, int albumnumber, string email)
        {
            _verification = verification;
            this._name = name;
            this._surname = surname;
            this._albumnumber = albumnumber;
            this._email = email;
        }

        public void Update(Thesis thesis)
        {
            ThesisStatus status = thesis.Status;

            Console.WriteLine("Powiadomienie dla Studenta: {0} {1}", this._name, this._surname);
            Console.WriteLine("Status Pracy: {0}", status);
        }

        public void Execute()
        {
            _verification.Album_Number_Verification(_albumnumber, _name, _surname);
        }
    }
}
