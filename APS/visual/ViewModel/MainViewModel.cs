using APS.visual.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.MWM.ViewModel
{
    internal class MainViewModel
    {
        public ObservableCollection<ModeloMensagem> Mensagens { get; set; }

        public ObservableCollection<ModeloContatos> Contatos { get; set; }

        public MainViewModel()
        {
            Mensagens = new ObservableCollection<ModeloMensagem>();

            Contatos = new ObservableCollection<ModeloContatos>();

            Mensagens.Add(new ModeloMensagem
            {
                UserName = "Davi",
                UserNameColor = "#409AFF",
                ImageSource = "https://imgur.com/gallery/EFeEbuJ",
                Message = "Teste",
                Time = DateTime.Now,
                IsNativeorigin = false,
                FirstMessage = true

            });

            for (int i = 0; i < 3; i++)
            {
                Mensagens.Add(new ModeloMensagem
                {
                    UserName = "Lucas",
                    UserNameColor = "#409AFF",
                    ImageSource = "https://imgur.com/gallery/EFeEbuJ",
                    Message = "Teste",
                    Time = DateTime.Now,
                    IsNativeorigin = false,
                    FirstMessage = false

                });

            }

            for (int i = 0; i < 4; i++)
            {
                Mensagens.Add(new ModeloMensagem
                {
                    UserName = "Vanessa",
                    UserNameColor = "#409AFF",
                    ImageSource = "https://imgur.com/gallery/EFeEbuJ",
                    Message = "Teste",
                    Time = DateTime.Now,
                    IsNativeorigin = true,

                });

            }

            Mensagens.Add(new ModeloMensagem
            {
                UserName = "Luan",
                UserNameColor = "#409AFF",
                ImageSource = "https://imgur.com/gallery/EFeEbuJ",
                Message = "Ultima",
                Time = DateTime.Now,
                IsNativeorigin = true,

            });

            for (int i = 0; i < 5; i++)
            {
                Contatos.Add(new ModeloContatos
                {
                    UserName = $"Adryan {i}",
                    SourceImage = "https://imgur.com/gallery/cNpdfmy",
                    mensagens = Mensagens
                });
            }


        }
       
    }
}
