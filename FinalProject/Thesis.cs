using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    public class ThesisException : ApplicationException
    {
        public ThesisException(string message)
            : base(message)
        {
        }
    }
    public class Thesis: Subject
    {
        public static List<Thesis> thesisList = new List<Thesis>();
        private int _id;
        public int Id
        {
            get { return this._id; }
            set
            {
                this._id = value;
            }
        }
        
        private int _idPromoter;
        public int IdPromoter
        {
            get { return this._idPromoter; }
            set
            {
                this._idPromoter = value;
            }
        }

        private int _idReviewer;
        public int IdReviewer
        {
            get { return this._idReviewer; }
            set
            {
                this._idReviewer = value;
            }
        }
        
        private double _promoterEvaluation;
        public double PromoterEvaluation
        {
            get { return this._promoterEvaluation; }
            set
            {
                this._promoterEvaluation = value;
            }
        }

        private double _reviewersAssessment;
        public double ReviewersAssessment
        {
            get { return this._reviewersAssessment; }
            set
            {
                this._reviewersAssessment = value;
            }
        }

        private int _albumnumber;
        public int Albumnumber
        {
            get { return this._albumnumber; }
            set
            {
                this._albumnumber = value;
            }
        }

        private string _title;
        public string Title
        {
            get { return this._title; }
            set
            {
                this._title = value;
            }
        }

        private ThesisStatus _status;
        public ThesisStatus Status
        {
            get { return this._status; }
            set
            {
                this._status = value;
                Notify();
            }
        }

        public Thesis(int id, string title, Student student, Promoter promoter, Reviewer reviewer)
        {
            this._id = id;
            this._title = title;
            this._albumnumber = student._albumnumber;
            this._idPromoter = promoter._id;
            this._idReviewer = reviewer._id;
            this.Attach(student);
            this.Attach(promoter);
            this.Attach(reviewer);
            this._status = ThesisStatus.SelectedTopic;
        }

        public string FindStudent()
        {
            foreach (Student student in Student.studentsList)
            {
                if (student._albumnumber == _albumnumber)
                {
                    return(student._name + " " + student._surname);
                }
            }
            return "Brak Przypisanego Studenta";
        }
        public string FindPromoter()
        {
            foreach (Promoter promoter in Promoter.promotersList)
            {
                if (promoter._id == _idPromoter)
                {
                    return (promoter._name + " " + promoter._surname);
                }
            }
            return "Brak Przypisanego Promotora";
        }

        public string FindReviewer()
        {
            foreach (Reviewer reviewer in Reviewer.reviewerList)
            {
                if (reviewer._id == _idReviewer)
                {
                    return (reviewer._name + " " + reviewer._surname);
                }
            }
            return "Brak Przypisanego Recenzenta";
        }
        

        public string CheckingGrades(double promoterEvaluation, double reviewersAssessment)
        {

            if (promoterEvaluation < 3.0 || reviewersAssessment < 3.0)
                throw new ThesisException("Nie zdales");
            else if (promoterEvaluation == reviewersAssessment)
                return "Oceny od Promotora i Recenzenta sa takie same";
            else if (promoterEvaluation > reviewersAssessment)
                return "Ocena Promotora jest wieksza od oceny Recenzenta";
            else
                return "Ocena Recenzenta jest wieksza od oceny Promotora";
        }

        protected override void Notify()
        {
            foreach (IObserver observer in this._observerList)
            {
                observer.Update(this);
            }
        }
    }
}
