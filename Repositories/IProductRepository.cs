using _2280600021_NguyenThiVanAn_Lab03WebsiteBanHang.Models;

namespace _2280600021_NguyenThiVanAn_Lab03WebsiteBanHang.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
    }
}
