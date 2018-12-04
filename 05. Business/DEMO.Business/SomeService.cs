using DEMO.Business.Interfaces;
using DEMO.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DEMO.Business
{
    public class SomeService : ISomeService
    {

        public SomeService() { }

        /// <inheritdoc />
        public async Task<List<Todo>> GetTodoItemsAsync()
        {
            //var list = await _toDoRepository.GetTodoAsync();
            //return list.ToList();

            return new List<Todo>();
        }

        /// <inheritdoc />
        public async Task<Todo> GetTodoItemAsync(int id)
        {
            //return await _toDoRepository.GetTodoAsync(id);
            return new Todo();
        }
    }
}
