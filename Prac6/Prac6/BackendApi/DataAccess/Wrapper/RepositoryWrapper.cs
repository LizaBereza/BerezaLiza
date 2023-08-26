using Domain1.Interfaces;
using DataAccess.Models;
using DataAccess.Repositories;


namespace DataAccess.Wrapper
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ShopsContext _repoContext;

        private IUserRepository _user;
        public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_repoContext);
                }
                return _user;
            }

        }


        public RepositoryWrapper(ShopsContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public async Task Save()
        {
           await _repoContext.SaveChangesAsync();
        }
    }
}
