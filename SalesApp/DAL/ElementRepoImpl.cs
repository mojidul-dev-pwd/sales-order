using SalesApp.DTO;

namespace SalesApp.DAL
{
    public class ElementRepoImpl: IElementRepo
    {
        public ElementRepoImpl() { }

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

        public async Task<List<ElementDto>> GetListAsync()
        {
            List<ElementDto> list = new List<ElementDto>();
            list.Add(new ElementDto
            {
                Id = 1,
                Type = "Doors",
                Width= 100,
                Height= 100,
                WindowId= 1,
                WindowName = "A51"
            });
            return list;
        }

        public Task<ElementDto> UpdateAsync(ElementDto input)
        {
            throw new NotImplementedException();
        }
    }
}
