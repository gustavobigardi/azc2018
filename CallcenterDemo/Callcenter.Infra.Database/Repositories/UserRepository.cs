using Callcenter.Domain.Entities;
using Callcenter.Domain.Queries.User;
using Callcenter.Domain.Repositories;
using Callcenter.Infra.Database.DataContexts;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callcenter.Infra.Database.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly CallcenterDataContext _context;

        public UserRepository(CallcenterDataContext context)
        {
            _context = context;
        }

        public bool CheckDocument(string document)
        {
            return
                _context
                .Connection
                .Query<bool>(
                    "USP_CHECK_DOCUMENT",
                    new { Document = document },
                    commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
        }

        public bool CheckEmail(string email)
        {
            return _context
                .Connection
                .Query<bool>(
                    "USP_CHECK_EMAIL",
                    new { Email = email },
                    commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
        }

        public GetUserQueryResult Get(Guid id)
        {
            return
                _context
                .Connection
                .Query<GetUserQueryResult>("SELECT [Id], CONCAT([FirstName], ' ', [LastName]) AS [Name], [Document], [Email] FROM [User] WHERE [Id]=@id", new { id = id })
                .FirstOrDefault();
        }

        public GetUserQueryResult GetByLogin(string login)
        {
            return
               _context
               .Connection
               .Query<GetUserQueryResult>("SELECT [Id], CONCAT([FirstName], ' ', [LastName]) AS [Name], [Document], [Email], [Picture] FROM [User] WHERE [Email]=@email", new { email = login })
               .FirstOrDefault();
        }

        public IEnumerable<ListUserQueryResult> ListAll()
        {
            return
               _context
               .Connection
               .Query<ListUserQueryResult>("SELECT [Id], CONCAT([FirstName], ' ', [LastName]) AS [Name], [Document], [Email] FROM [User]", new { });
        }

        public void Save(User user)
        {
            _context.Connection.Execute("USP_CREATE_USER",
            new
            {
                user.Id,
                user.Name.FirstName,
                user.Name.LastName,
                Document = user.Document.Number,
                Email = user.Email.Address,
                user.Password,
                Picture = "",
                PictureFile = ""
            }, commandType: CommandType.StoredProcedure);
        }
    }
}
