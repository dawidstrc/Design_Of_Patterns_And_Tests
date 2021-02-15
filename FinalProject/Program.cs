using System;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating students

            Student DawidStracilo = new Student("Dawid", "Stracilo", 111111, "dawids@gmail.com");
            Student SebastianGacek = new Student("Sebastian", "Gacek", 222222, "sebastiang@gmail.com");
            Student JanMaciag = new Student("Jan", "Maciag", 333333, "janm@gmail.com");
            Student JakubNowak = new Student("Jakub", "Nowak", 444444, "jakubn@gmail.com");

            Student.studentsList.Add(DawidStracilo);
            Student.studentsList.Add(SebastianGacek);
            Student.studentsList.Add(JanMaciag);
            Student.studentsList.Add(JakubNowak);

            //Creating promoters

            Promoter Prom1 = new Promoter(1, "Adam", "Kowalski");
            Promoter Prom2 = new Promoter(2, "Jan", "Slowacki");
            Promoter Prom3 = new Promoter(3, "Edyta", "Jamroz");
            Promoter Prom4 = new Promoter(4, "Zbigniew", "Slowik");

            Promoter.promotersList.Add(Prom1);
            Promoter.promotersList.Add(Prom2);
            Promoter.promotersList.Add(Prom3);
            Promoter.promotersList.Add(Prom4);

            //Creating reviewers

            Reviewer Rev1 = new Reviewer(1, "Ewelina", "Szlachta");
            Reviewer Rev2 = new Reviewer(2, "Przemyslaw", "Strzala");
            Reviewer Rev3 = new Reviewer(3, "Anna", "Mak");
            Reviewer Rev4 = new Reviewer(4, "Jozef", "Stol");

            Reviewer.reviewerList.Add(Rev1);
            Reviewer.reviewerList.Add(Rev2);
            Reviewer.reviewerList.Add(Rev3);
            Reviewer.reviewerList.Add(Rev4);

            //Creating Theses

            Thesis Thesis1 = new Thesis(1, "PracaDyplomowa1", DawidStracilo, Prom1, Rev1);
            Thesis Thesis2 = new Thesis(2, "PracaDyplomowa2", SebastianGacek, Prom1, Rev2);
            Thesis Thesis3 = new Thesis(3, "PracaDyplomowa3", JanMaciag, Prom3, Rev4);
            Thesis Thesis4 = new Thesis(4, "PracaDyplomowa4", JakubNowak, Prom4, Rev2);

            Thesis.thesisList.Add(Thesis1);
            Thesis.thesisList.Add(Thesis2);
            Thesis.thesisList.Add(Thesis3);
            Thesis.thesisList.Add(Thesis4);

            foreach (Thesis thesis in Thesis.thesisList)
            {
                Console.WriteLine("Praca dyplomowa numer -> ||| {0} ||| Tytul -> ||| {1} |||\nStudent -> ||| {2} ||| Promotor -> ||| {3} ||| Recenzent -> ||| {4} |||\n********\n", thesis.Id, thesis.Title, thesis.FindStudent(), thesis.FindPromoter(), thesis.FindReviewer());
            }

            Console.WriteLine("\nWybranie Tematu");
            Thesis1.Status = ThesisStatus.SelectedTopic;
            Console.WriteLine("\nAkceptacja Pracy");
            Thesis1.Status = ThesisStatus.AcceptedTopic;
            Console.WriteLine("\nWgranie Plikow");
            Thesis1.Status = ThesisStatus.SubmissionofDocuments;
            Console.WriteLine("\nWeryfikacja Autoplagiatu");
            Thesis1.Status = ThesisStatus.VerifiedAntiPlagiarism;
            Console.WriteLine("\nRecenzja i Ocena Recenzenta");
            Thesis1.ReviewersAssessment = 3.0;
            Thesis1.Status = ThesisStatus.ReviewAndEvaluation;
            Console.WriteLine("\nOcena Promotora");
            Thesis1.Status = ThesisStatus.EvaluationOfThePromoter;

            Console.ReadKey();
        }
    }
}
