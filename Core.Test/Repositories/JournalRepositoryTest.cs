using Core.Data.Mappers;
using Core.Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.Test.Repositories
{
    [TestClass]
    public class JournalRepositoryTest
    {
        [TestMethod]
        public void GetJournalsOk()
        {
            var repo = new JournalRepository();
            AutomapperConfig.RegisterAutomapper();

            var results = repo.Get(1);

            var resultsAll = repo.GetAll();
        }
    }
}
