using SalesApp.DAL;
using SalesApp.DTO;

namespace SalesApp.BLL
{
    public class ElementServiceImpl : IElementService
    {
        private readonly IElementRepo _elementRepo;
        public ElementServiceImpl(IElementRepo elementRepo) { 
            this._elementRepo = elementRepo;
        }
        public Task<ElementDto> CreateAsync(ElementDto input)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ElementDto> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ElementDto>> GetListAsync()
        {
            try { 
                return _elementRepo.GetListAsync();
            } catch { 
                return null; 
            }
        }

        public Task<ElementDto> UpdateAsync(ElementDto input)
        {
            throw new NotImplementedException();
        }
    }
}
