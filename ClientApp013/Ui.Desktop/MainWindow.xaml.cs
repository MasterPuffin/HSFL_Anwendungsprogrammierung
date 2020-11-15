using De.HsFlensburg.ClientApp013.Business.Model.BusinessObjects;
using De.HsFlensburg.ClientApp013.Logic.Ui.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace De.HsFlensburg.ClientApp013.Ui.Desktop {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void AddClientToList(object sender, RoutedEventArgs e) {
            ClientCollectionViewModel list = this.FindResource("myList") as ClientCollectionViewModel;
            if (list != null) {
                ClientViewModel clientVM = new ClientViewModel();
                clientVM.Id = Int16.Parse(IdTextBox.Text);
                clientVM.Name = NameTextBox.Text;
                list.Add(clientVM);
            }
        }

        private void AddClientToModelList(object sender, RoutedEventArgs e) {
            ClientCollectionViewModel list = this.FindResource("myList") as ClientCollectionViewModel;
            if (list != null) {
                Client client = new Client();
                client.Id = Int16.Parse(IdTextBox.Text);
                client.Name = NameTextBox.Text;
                list.myClients.Add(client);
            }
        }

        private void DeleteClientInList(object sender, RoutedEventArgs e) {
            ClientCollectionViewModel list = this.FindResource("myList") as ClientCollectionViewModel;
            if (list != null) {
                list.RemoveAt(0);
            }
        }

        private void DeleteClientInModelList(object sender, RoutedEventArgs e) {
            ClientCollectionViewModel list = this.FindResource("myList") as ClientCollectionViewModel;
            if (list != null) {
                list.myClients.RemoveAt(0);
            }
        }

        private void DeleteModelCollection(object sender, RoutedEventArgs e) {
            ClientCollectionViewModel list = this.FindResource("myList") as ClientCollectionViewModel;
            if (list != null) {
                list.myClients.Clear();
            }
        }

        private void DeleteViewModelCollection(object sender, RoutedEventArgs e) {
            ClientCollectionViewModel list = this.FindResource("myList") as ClientCollectionViewModel;
            if (list != null) {
                list.Clear();
            }
        }
    }
}
