using Callcenter.Domain.Commands.UserCommands.Inputs;
using Callcenter.Domain.Handlers;
using Callcenter.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Callcenter.Presentation
{
    public partial class FormMain : Form
    {
        private readonly UserHandler _userHandler;
        private readonly IUserRepository _userRepository;

        public FormMain(UserHandler userHandler, IUserRepository userRepository)
        {
            _userHandler = userHandler;
            _userRepository = userRepository;
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!_userRepository.CheckEmail("test@test.com"))
            {
                CreateUserCommand command = new CreateUserCommand()
                {
                    Document = "02400000050",
                    Email = "test@test.com",
                    FirstName = "User",
                    LastName = "Test",
                    Password = "123Aa321"
                };

                var result = _userHandler.Handle(command);

                if (!result.Success)
                {
                    MessageBox.Show("Erro!\n" + result.Message);
                }
            }

            var users = _userRepository.ListAll();
            MessageBox.Show(users.Count().ToString());
        }
    }
}
