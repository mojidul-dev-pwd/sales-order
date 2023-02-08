using SalesApp.DTO;

namespace SalesApp.DAL
{
    public interface IElementRepo
    {
        Task<ElementDto> GetAsync(int id);
        Task<ElementDto> CreateAsync(ElementDto input);
        Task<ElementDto> UpdateAsync(ElementDto input);
        Task DeleteAsync(int id);
        Task<List<ElementDto>> GetListAsync();
    }
}
