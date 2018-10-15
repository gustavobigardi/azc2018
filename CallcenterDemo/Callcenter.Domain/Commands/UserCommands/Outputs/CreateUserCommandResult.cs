using Callcenter.Domain.Entities;
using Callcenter.Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callcenter.Domain.Commands.UserCommands.Outputs
{
    public class CreateUserCommandResult : ICommandResult
    {
        public CreateUserCommandResult(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
