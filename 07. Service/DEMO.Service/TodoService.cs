using AutoMapper;
using DEMO.Business;
using DEMO.Business.Interfaces;
using System;
using System.Threading.Tasks;
using Unity;

namespace DEMO.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ToDoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ToDoService.svc or ToDoService.svc.cs at the Solution Explorer and start debugging.
    public class TodoService : ITodoService
    {
        private readonly IUnityContainer _container;
        public readonly IMapper _mapper;
        public readonly ISomeService _someService;

        public TodoService(IMapper mapper, IUnityContainer container, ISomeService someService)
        {
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _someService = someService ?? throw new ArgumentNullException(nameof(someService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<TodoDto> GetTodoAsync(int id)
        {
            //var someService = _container.Resolve<SomeService>();
            var returnItem = await _someService.GetTodoItemAsync(id);
            return _mapper.Map<TodoDto>(returnItem);
        }
    }
}
