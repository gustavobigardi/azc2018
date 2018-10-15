using Callcenter.Domain.Handlers;
using Callcenter.Domain.Repositories;
using Callcenter.Infra.Database.DataContexts;
using Callcenter.Infra.Database.Repositories;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callcenter.Infra.CrossCutting.IoC
{
    public class SimpleInjectorBootstrap
    {
        private static Container _container;

        public static void Bootstrap()
        {
            _container = new Container();

            _container.Register<CallcenterDataContext>(Lifestyle.Singleton);

            _container.Register<IUserRepository, UserRepository>(Lifestyle.Singleton);

            _container.Register<UserHandler>(Lifestyle.Singleton);

            _container.Verify();
        }
    }
}
