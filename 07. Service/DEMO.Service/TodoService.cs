using AutoMapper;
using DEMO.Business.Interfaces;
using System;
using System.Threading.Tasks;

namespace DEMO.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ToDoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ToDoService.svc or ToDoService.svc.cs at the Solution Explorer and start debugging.
    public class TodoService : ITodoService
    {
        private readonly ISomeService _todoService;
        public readonly IMapper _mapper;

        public TodoService(IMapper mapper, ISomeService todoService)
        {
            _todoService = todoService ?? throw new ArgumentNullException(nameof(todoService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<TodoDto> GetTodoAsync(int id)
        {
            var returnItem = await _todoService.GetTodoItemAsync(id);
            return _mapper.Map<TodoDto>(returnItem);
        }
    }
}
