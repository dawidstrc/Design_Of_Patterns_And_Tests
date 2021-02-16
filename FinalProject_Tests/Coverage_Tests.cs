using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalProject;
namespace FinalProject_Tests
{
    [TestClass]
    public class Coverage_Tests
    {
        [DataTestMethod]
        [DataRow(3.0, 3.0, "Oceny od Promotora i Recenzenta sa takie same")]
        [DataRow(5.0, 3.0, "Ocena Promotora jest wieksza od oceny Recenzenta")]
        [DataRow(3.0, 5.0, "Ocena Recenzenta jest wieksza od oceny Promotora")]
        public void CheckingGrades_Equal(double promoterEvaluation, double reviewersAssessment, string output)
        {

            //arrange
            Student DawidStracilo = new Student("Dawid", "Stracilo", 111111, "dawids@gmail.com");
            Promoter Prom1 = new Promoter(1, "Adam", "Kowalski");
            Reviewer Rev1 = new Reviewer(1, "Ewelina", "Szlachta");
            Thesis Thesis1 = new Thesis(1, "PracaDyplomowa1", DawidStracilo, Prom1, Rev1);

            //act
            string actual = Thesis1.CheckingGrades(promoterEvaluation, reviewersAssessment);

            //assert
            Assert.AreEqual(actual, output);

        }
    }
}
