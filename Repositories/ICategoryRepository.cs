using _2280600021_NguyenThiVanAn_Lab03WebsiteBanHang.Models;

namespace _2280600021_NguyenThiVanAn_Lab03WebsiteBanHang.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task AddAsync(Category category);
        Task UpdateAsync(Category category);
        Task DeleteAsync(int id);
    }
}
