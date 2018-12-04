using DEMO.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DEMO.Business.Interfaces
{
    public interface ISomeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<List<Todo>> GetTodoItemsAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Todo> GetTodoItemAsync(int id);
    }
}
