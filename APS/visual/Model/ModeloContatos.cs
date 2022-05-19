using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.visual.Model
{
    internal class ModeloContatos
    {
        public string UserName { get; set; }
        public string SourceImage { get; set; }

        public ObservableCollection <ModeloMensagem> mensagens { get; set; }

        public string LastMessage => mensagens.Last().Message;
    }
}
