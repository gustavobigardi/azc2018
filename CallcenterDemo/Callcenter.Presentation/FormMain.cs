using Callcenter.Domain.Commands.UserCommands.Inputs;
using Callcenter.Domain.Handlers;
using Callcenter.Domain.Repositories;
using Callcenter.Infra.FaceAPI;
using Callcenter.Infra.Webcam;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

        private WebCamCapture webCam;

        public FormMain(UserHandler userHandler, IUserRepository userRepository)
        {
            _userHandler = userHandler;
            _userRepository = userRepository;
            webCam = new WebCamCapture(this);
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
        }

        private void buttonStartSec_Click(object sender, EventArgs e)
        {
            webCam.Start();
        }

        private void buttonStopSec_Click(object sender, EventArgs e)
        {
            webCam.Stop();
        }

        private void buttonCapture_Click(object sender, EventArgs e)
        {
            pictureBoxWebCamSec.Image = webCam.CaptureFrame();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _userRepository.GetByLogin(textBoxUsername.Text);

            if (user != null && !String.IsNullOrWhiteSpace(user.Picture))
            {
                Byte[] bitmapData = Convert.FromBase64String(FixBase64ForImage(user.Picture));
                MemoryStream streamBitmap = new MemoryStream(bitmapData);
                pictureBoxDatabaseSec.Image = new Bitmap((Bitmap)Image.FromStream(streamBitmap));
            }
            else if (user == null)
            {
                MessageBox.Show("Usuário não encontrado");
            }
            else if (user != null && String.IsNullOrWhiteSpace(user.Picture))
            {
                MessageBox.Show("Usuário sem foto");
            }
        }

        private string FixBase64ForImage(string Image)
        {
            System.Text.StringBuilder sbText = new System.Text.StringBuilder(Image, Image.Length);
            sbText.Replace("\r\n", String.Empty); sbText.Replace(" ", String.Empty);
            return sbText.ToString();
        }

        private void buttonStartFace_Click(object sender, EventArgs e)
        {
            webCam.Start();
        }

        private void buttonStopFace_Click(object sender, EventArgs e)
        {
            webCam.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBoxFace.Image = webCam.CaptureFrame();
        }

        private void buttonStartMood_Click(object sender, EventArgs e)
        {
            webCam.Start();
        }

        private void buttonStopMood_Click(object sender, EventArgs e)
        {
            webCam.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBoxWebCamMood.Image = webCam.CaptureFrame();
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            Stream originalStream = new MemoryStream();
            Stream detectStream = new MemoryStream();

            var key = "7a5e207339844c938add1aad8fe17f8a";

            var faceApi = new FaceApi(key);

            pictureBoxDatabaseSec.Image.Save(originalStream, ImageFormat.Jpeg);
            pictureBoxWebCamSec.Image.Save(detectStream, ImageFormat.Jpeg);

            var result = faceApi.Compare(originalStream, detectStream).GetAwaiter().GetResult();

            lblResultSec.Text = result ? "Confere" : "Não confere";
            lblResultSec.BackColor = result ? Color.Green : Color.Red;
            lblResultSec.ForeColor = Color.White;
        }

        private void buttonLoadSecCad_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialogImage.ShowDialog())
            {
                var file = openFileDialogImage.FileName;
                pictureBoxDatabaseSec.Image = Image.FromFile(file);
            }
        }

        private void buttonLoadWebCam_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialogImage.ShowDialog())
            {
                var file = openFileDialogImage.FileName;
                pictureBoxWebCamSec.Image = Image.FromFile(file);
            }
        }

        private void buttonLoadFace_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialogImage.ShowDialog())
            {
                var file = openFileDialogImage.FileName;
                pictureBoxFace.Image = Image.FromFile(file);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialogImage.ShowDialog())
            {
                var file = openFileDialogImage.FileName;
                pictureBoxWebCamMood.Image = Image.FromFile(file);
            }
        }
    }
}
