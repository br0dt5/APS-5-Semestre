using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.MVVM.Model
{
    internal class ModeloMensagem
    {
        public string UserName { get; set; }
        public string UserNameColor { get; set; }
        public string ImageSource { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public bool IsNativeorigin { get; set; }
        public bool? FirstMessage { get; set; }

    }
}
