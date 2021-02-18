using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalProject;
namespace FinalProject_Tests
{
    [TestClass]
    public class ThesisExceptions
    {
        [TestMethod]
        [ExpectedException(typeof(ThesisException))]
        public void CheckingGrades_DontPass()
        {

            //arrange
            var verification = new Verification();
            Student DawidStracilo = new Student(verification, "Dawid", "Stracilo", 111111, "dawids@gmail.com");
            Promoter Prom1 = new Promoter(1, "Adam", "Kowalski");
            Reviewer Rev1 = new Reviewer(1, "Ewelina", "Szlachta");
            Thesis Thesis1 = new Thesis(1, "PracaDyplomowa1", DawidStracilo, Prom1, Rev1);
            Thesis1.PromoterEvaluation = 2.0;
            Thesis1.ReviewersAssessment = 3.0;

            Thesis1.CheckingGrades(Thesis1.PromoterEvaluation, Thesis1.ReviewersAssessment);

        }
    }
}
