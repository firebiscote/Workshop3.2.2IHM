using System.Windows.Input;
using System.Collections.ObjectModel;

namespace Workshop3._2._2IHM
{
    public class ViewModel : ViewModelBase
    {
        private Data data;
        private ObservableCollection<Data> datas;
        private ICommand submitCommand;
        public Data Data
        {
            get => data;
            set
            {
                data = value;
                NotifyPropertyChanged("Data");
            }
        }
        public ObservableCollection<Data> Datas
        {
            get => datas;
            set
            {
                datas = value;
                NotifyPropertyChanged("Datas");
            }
        }

        public ICommand SubmitCommand
        {
            get
            {
                if (submitCommand == null)
                {
                    submitCommand = new RelayCommand(param => this.Submit(), null);
                }
                return submitCommand;
            }
        }

        public ViewModel()
        {
            Data = new Data();
            Datas = new ObservableCollection<Data>();
            Datas.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(Datas_CollectionChanged);
        }
        void Datas_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            NotifyPropertyChanged("Datas");
        }
        private void Submit()
        {
            Datas.Add(Data);
            Data = new Data();
        }
    }
}
