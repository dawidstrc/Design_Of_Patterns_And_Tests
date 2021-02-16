using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalProject;
using Moq;
namespace FinalProject_Tests
{

    [TestClass]
    public class Mock
    {
        public class MockLogger : ILogger
        {
           public void Log(string message) { }
        }

        [TestMethod]
        public void EvaluationLessThanThree_StubTest()
        {
            var evaluationValidator = new EvaluationValidator(new MockLogger());
            bool actual = evaluationValidator.Validate(2.0);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void EvaluationBiggerThanThree_StubTest()
        {
            var evaluationValidator = new EvaluationValidator(new MockLogger());
            bool actual = evaluationValidator.Validate(5.0);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void Evaluation_Mock()
        {
            Student DawidStracilo = new Student("Dawid", "Stracilo", 111111, "dawids@gmail.com");
            Promoter Prom1 = new Promoter(1, "Adam", "Kowalski");
            Reviewer Rev1 = new Reviewer(1, "Ewelina", "Szlachta");
            Thesis Thesis1 = new Thesis(1, "PracaDyplomowa1", DawidStracilo, Prom1, Rev1);
            var mock = new Mock<ILogger>();
            var evaluationValidator = new EvaluationValidator(mock.Object);
            Thesis1.PromoterEvaluation = 2.0;
            evaluationValidator.Validate(Thesis1.PromoterEvaluation);

            mock.Verify(x => x.Log("Student's thesis didn't pass promoter evaluation"), Times.Once);
        }
     

    }
}
