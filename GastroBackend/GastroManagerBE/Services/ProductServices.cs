using GastroManagerBE.Interfaces;
using GastroManagerBE.Models;
using GastroManagerBE.Repository;

namespace GastroManagerBE.Services
{
    public class ProductServices : BaseRepository<Product>, IProductServices
    {
        public ProductServices(IRepository<Product> repository) : base(repository)
        {

        }
    }
}
