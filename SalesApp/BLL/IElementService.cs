using SalesApp.DTO;

namespace SalesApp.BLL
{
    public interface IElementService
    {
        Task<ElementDto> GetAsync(int id);
        Task<ElementDto> CreateAsync(ElementDto input);
        Task<ElementDto> UpdateAsync(ElementDto input);
        Task DeleteAsync(int id);
        Task<List<ElementDto>> GetListAsync();
    }
}
