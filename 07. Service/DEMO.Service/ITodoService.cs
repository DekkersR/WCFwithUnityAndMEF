﻿using System.ServiceModel;
using System.Threading.Tasks;

namespace DEMO.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IToDoService" in both code and config file together.
    [ServiceContract]
    public interface ITodoService
    {
        [OperationContract]
        Task<TodoDto> GetTodoAsync(int id);
    }
}
