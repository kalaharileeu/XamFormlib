
//using XamAppTest.ViewModels;
using Xamarin.Forms;

namespace XamAppTest.Views
{
    /// <summary>
    /// ContentPage is the root element in the AboutPage.xaml, xaml file
    /// 
    /// The ContentPage.BindingContext part of the root element is the
    /// AboutViewModel in AboutViewModel.cs
    /// </summary>
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            //Initialize components probably initialize
            //the xaml content
            InitializeComponent();
            //The binding was done in XAML...mmmm..Do not have to do it here
           // BindingContext = new AboutViewModel;
        }
    }
}
