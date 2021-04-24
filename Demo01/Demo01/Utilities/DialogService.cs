using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo01.Utilities
{
    public class DialogService : IDialogService
    {
        public async Task ShowAsync(string title, string message)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, "OK");
        }
    }
}
