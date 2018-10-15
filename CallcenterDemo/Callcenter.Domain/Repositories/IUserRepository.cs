using Callcenter.Domain.Entities;
using Callcenter.Domain.Queries.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callcenter.Domain.Repositories
{
    public interface IUserRepository
    {
        bool CheckDocument(string document);
        bool CheckEmail(string email);
        void Save(User user);
        IEnumerable<ListUserQueryResult> ListAll();
        GetUserQueryResult Get(Guid id);
    }
}
