using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace CodingTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string _apiPath;
        private int _resultsRequested;
        private string _debugInfo;

        public string ApiPath
        {
            get => _apiPath;
            set
            {
                _apiPath = value;
                OnPropertyChanged("ApiPath");
            }
        }
        public int ResultsRequested
        {
            get => _resultsRequested;
            set
            {
                _resultsRequested = value;
                OnPropertyChanged("ResultsRequested");
            }
        }
        public string DebugInfo
        {
            get => _debugInfo;
            set
            {
                _debugInfo = value;
                OnPropertyChanged("DebugInfo");
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            SetValues();
            DataContext = this;
        }

        private void SetValues()
        {
            ApiPath = "https://yesno.wtf/api";
            ResultsRequested = 1;
            DebugInfo = "";
        }

        public void PrintDebug(string debugInfo)
        {
            DebugInfo = debugInfo;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrintDebug("Test");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
