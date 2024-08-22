using GastroManagerBE.Interfaces;
using GastroManagerBE.Models;
using GastroManagerBE.Repository;

namespace GastroManagerBE.Services
{
    public class UserServices : BaseRepository<User>, IUserServices
    {
        public UserServices(IRepository<User> repository) : base(repository)
        {

        }
    }
}
