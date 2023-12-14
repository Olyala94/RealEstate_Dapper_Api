using RealEstate_Dapper_Api.Dtos.ToDoListDtos;

namespace RealEstate_Dapper_Api.Repositories.ToDoListRepository
{
    public interface IToDoListRepository
    {
        Task<List<ResultToDoListDto>> GetAllToDoListAsync();

        void CreateToDoList(CreateToDoListDto categoryDto);

        void DeleteToDoList(int id);

        void UpdateToDoList(UpdateToDoListDto categoryDto);

        Task<GetByIdToDoListDto> GetByIdToDoList(int id);
    }
}
