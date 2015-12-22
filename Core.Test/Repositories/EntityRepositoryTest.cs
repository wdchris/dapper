using Core;
using Core.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Test.Repositories
{
    [TestClass]
    public class EntityRepositoryTest
    {
        [TestMethod]
        public void GetEntitiesOk()
        {
            var repo = new JournalRepository();

            var results = repo.Get(1);
        }
    }
}
