using System;

namespace Chat.MVVM.Model
{
    class MessageModel
    {
        public string UserName { get; set; }
        public string UserNameColor { get; set; }
        public string ImageSource { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
    }
}
