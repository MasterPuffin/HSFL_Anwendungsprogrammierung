using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.HsFlensburg.ClientApp013.Ui.Desktop.MessageBusLogic {
    class MessageListener {
        public MessageListener() {
            InitMessenger();
        }

        private void InitMessenger() {
            ServiceBus.Instance.Register<OpenNewClientWindowMessage>(this, delegate () {
                NewClientWindow myWindow = new NewClientWindow();
                myWindow.ShowDialog();
            });
        }
        public bool BindableProperty => true;
    }
}
