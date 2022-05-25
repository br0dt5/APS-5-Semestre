using Chat.MVVM.Model;
using Chat.NET;
using Chat.Nucleo;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace Chat.MVVM.ViewModel
{
    class ChatViewModel : ObservableObject
    {
        public ObservableCollection<UserModel> Users { get; set; }
        public ObservableCollection<MessageModel> Mensagens { get; set; }

        private Server _server;
        public UserModel User { get; set; } = new UserModel()
        {
            Username = LoginViewModel.Username,
            UID = Guid.NewGuid().ToString()
        };
        private string _message;

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        //public RelayCommand ConnectToServerCommand { get; set; }
        public RelayCommand SendMessageCommand { get; set; }

        public ChatViewModel()
        {
            Users = new ObservableCollection<UserModel>();
            Mensagens = new ObservableCollection<MessageModel>();

            _server = new Server();
            _server.connectedEvent += UserConnected;
            _server.msgReceivedEvent += MessageReceived;
            _server.userDisconnectedEvent += RemovedUser;
            _server.ConnectToServer(User.Username, User.UID);

            SendMessageCommand = new RelayCommand(o =>
            {
                _server.SendMessageToServer(User.UID.ToString(), Message);
                Message = "";
            }, o => !string.IsNullOrEmpty(Message));
        }

        private void UserConnected()
        {
            var username = _server.PacketReader.ReadMessage();
            var uid = _server.PacketReader.ReadMessage();
            var user = new UserModel
            {
                Username = username,
                UID = uid
            };
            if (!Users.Any(x => x.UID == user.UID))
            {
                Application.Current.Dispatcher.Invoke(() => Users.Add(user));
            }
        }

        private void MessageReceived()
        {
            var uid = _server.PacketReader.ReadMessage();
            var msg = _server.PacketReader.ReadMessage();
            var user = Users.Where(x => x.UID.ToString() == uid).FirstOrDefault();
            Application.Current.Dispatcher.Invoke(() => Mensagens.Add(new MessageModel
            {
                UserName = user.Username,
                UserNameColor = "#409AFF",
                ImageSource = "https://imgur.com/gallery/EFeEbuJ",
                Message = msg,
                Time = DateTime.Now
            }));
        }

        private void RemovedUser()
        {
            var uid = _server.PacketReader.ReadMessage();
            var user = Users.Where(x => x.UID.ToString() == uid).FirstOrDefault();
            Application.Current.Dispatcher.Invoke(() =>
            {
                Users.Remove(user);
                Mensagens.Add(new MessageModel
                {
                    Message = $"[{user.Username}] Disconnected!",
                    Time = DateTime.Now
                });
            });
        }
    }
}
