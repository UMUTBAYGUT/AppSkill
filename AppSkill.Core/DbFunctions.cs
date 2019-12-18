using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppSkill.Core.TestDatas;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace AppSkill.Core
{
   /* public static class DbFunctions
    {
        public static Mock<DbSet<T>> GetDbSet<T>(IQueryable<T> LocationTestData) where T : class
        {
            var MockSet = new Mock<DbSet<T>>();
            MockSet.As<IAsyncEnumerable<T>>().Setup(x => x.GetEnumerator()).Returns(new TestAsyncEnumerator<T>(LocationTestData.GetEnumerator()));
            MockSet.As<IQueryable<T>>().Setup(x => x.Provider).Returns(new TestAsyncQueryProvider<T>(LocationTestData.Provider));
            MockSet.As<IQueryable<T>>().Setup(x => x.Expression).Returns(LocationTestData.Expression);
            MockSet.As<IQueryable<T>>().Setup(x => x.ElementType).Returns(LocationTestData.ElementType);
            MockSet.As<IQueryable<T>>().Setup(x => x.GetEnumerator()).Returns(LocationTestData.GetEnumerator());
            return MockSet;
        }
    }*/
}
