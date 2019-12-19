using System;
namespace AppSkill.Core
{
    public interface IRepositoryReadOnly<T> : IReadRepository<T> where T : class
    {

    }
}
