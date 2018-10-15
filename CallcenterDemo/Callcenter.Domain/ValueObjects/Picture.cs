using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callcenter.Domain.ValueObjects
{
    public class Picture : Notifiable
    {
        public Picture(byte[] data, string fileName)
        {
            Data = data;
            FileName = fileName;

            AddNotifications(new Contract()
                .Requires()
                .IsNotNull(Data, "Data", "O conteúdo do arquivo é obrigatório")
                .IsNotNullOrEmpty(FileName, "FileName", "O nome do arquivo é obrigatório")
            );
        }

        public byte[] Data { get; private set; }
        public string FileName { get; private set; }
    }
}
