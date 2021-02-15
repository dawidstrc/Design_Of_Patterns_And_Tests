using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalProject;
namespace FinalProject_Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void StudentCount()
        {
            Student DawidStracilo = new Student("Dawid", "Stracilo", 111111, "dawid@gmail.com");
            Student SebastianGacek = new Student("Sebastian", "Gacek", 222222, "sebastiang@gmail.com");
            Student.studentsList.Add(DawidStracilo);
            Student.studentsList.Add(SebastianGacek);
            int actual = Student.studentsList.Count;
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ReviewerCount()
        {
            Reviewer Rev1 = new Reviewer(1, "Ewelina", "Szlachta");
            Reviewer Rev2 = new Reviewer(2, "Przemyslaw", "Strzala");
            Reviewer Rev3 = new Reviewer(3, "Anna", "Mak");

            Reviewer.reviewerList.Add(Rev1);
            Reviewer.reviewerList.Add(Rev2);
            Reviewer.reviewerList.Add(Rev3);

            int actual = Reviewer.reviewerList.Count;
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PromoterCount()
        {
            Promoter Prom1 = new Promoter(1, "Adam", "Kowalski");
            Promoter Prom2 = new Promoter(2, "Jan", "Slowacki");
            Promoter Prom3 = new Promoter(3, "Edyta", "Jamroz");
            Promoter Prom4 = new Promoter(4, "Zbigniew", "Slowik");

            Promoter.promotersList.Add(Prom1);
            Promoter.promotersList.Add(Prom2);
            Promoter.promotersList.Add(Prom3);
            Promoter.promotersList.Add(Prom4);
            int actual = Promoter.promotersList.Count;
            int expected = 4;
            Assert.AreEqual(expected, actual);
        }
    }
}
