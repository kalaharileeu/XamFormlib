using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamAppTest.ViewModels
{
    /// <summary>
    /// BaseViewModel inherits from ObservableObject.
    /// ObservableObject is part of Microsoft.Practices.Composite.Presentation - i.e. Prism.
    /// It's also been implemented in MVVM Light and MVVM Foundation.
    ///INotifyPropertyChanged is part of System.ComponentModel - i.e.it's in the core libraries
    ///INotifyPropertyChange is to tell xaml or xamarin forms that a property change, to create two
    ///way binding
    /// </summary>
    public class AboutViewModel : BaseViewModel
    {

        string website;
        bool continuenow;
        //string displayMessage;
        public AboutViewModel()
        {
            Title = "About";//Title lives somewhere else
            website = "http://csdl2andwin20170312082440.azurewebsites.net/";
           // displayMessage = "Original Message";
            continuenow = true;
            //Cornel changed this
            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("http://csdl2andwin20170312082440.azurewebsites.net/")));

            //BindingContext = new AddContactViewModel;

        }

        /******************************Below is implemented in inherited ObservableObject *******************************/
        //Cornel add this, event handler for property changed
        //This forms part of InotifyProperty change binding
        //public event PropertyChangedEventHandler PropertyChanged;

        //void OnPropertyChanged(string name)//name is the property name
        //{
        //    //? is to make sure not null and someone subscribes
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        //}

        /// <summary>
        /// Command to open browser to xamarin.com
        /// </summary>
        public ICommand OpenWebCommand { get; }

        //Bind to text in XAML: <Entry Text="{Binding website}"/>
        public string Website
        {
            get { return website; }
            set
            {
                website = value;
                //OnPropertyChanged("Website"); or
                //OnPropertyChanged(nameof(Website));//nameof c#6
                //not pass in name like above, due to [CallerMemberName] in ObservableObject
                OnPropertyChanged();
                //After update that update DsipalyMessage
                OnPropertyChanged(nameof(DisplayMessage));
            }
        }

        //This binds to a "Label" in the Xaml
        public string DisplayMessage
        {
            get { return $" Original + {website}"; }
            //set { displayMessage = value; }
        }

        //This bool binds with "Switch" in Xaml
        public bool Continuenow
        {
            get { return continuenow; }
            set { continuenow = value; }
        }
    }
}
