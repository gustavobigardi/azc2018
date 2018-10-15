using Callcenter.Domain.Commands.UserCommands.Inputs;
using Callcenter.Domain.Commands.UserCommands.Outputs;
using Callcenter.Domain.Entities;
using Callcenter.Domain.Repositories;
using Callcenter.Domain.ValueObjects;
using Callcenter.Shared.Commands;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callcenter.Domain.Handlers
{
    public class UserHandler :
        Notifiable,
        ICommandHandler<CreateUserCommand>
    {
        private readonly IUserRepository _repository;

        public UserHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateUserCommand command)
        {
            if (_repository.CheckDocument(command.Document))
                AddNotification("Document", "Este CPF já está em uso");

            if (_repository.CheckEmail(command.Email))
                AddNotification("Email", "Este E-mail já está em uso");

            var name = new Name(command.FirstName, command.LastName);
            var document = new Document(command.Document);
            var email = new Email(command.Email);

            var user = new User(name, document, email, command.Password);

            AddNotifications(name.Notifications);
            AddNotifications(document.Notifications);
            AddNotifications(email.Notifications);
            AddNotifications(user.Notifications);

            if (Invalid)
                return new CommandResult(
                    false,
                    "Por favor, corrija os campos abaixo",
                    Notifications);

            _repository.Save(user);

            return new CreateUserCommandResult(true, "Usuário criado com sucesso", new
            {
                user.Id,
                Name = name.ToString(),
                Email = email.Address
            });
        }
    }
}
