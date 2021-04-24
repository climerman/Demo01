using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Demo01.ViewModels
{
    /// <summary>
    /// Health Check ViewModel class
    /// </summary>
    public class HealthCheckViewModel : BaseViewModel
    {
        #region "Commands"

        public ICommand HealthCheckCommand => new Command(async () => await ExecuteHealthCheckCommand());
        public ICommand TestErrorCommand => new Command(async () => await ExecuteTestErrorCommand());

        #endregion

        #region "Ctor"

        /// <summary>
        ///  Constructor of Health Check ViewModel
        /// </summary>
        public HealthCheckViewModel()
        {
            Title = "Health Check";
        }

        #endregion

        #region "Methods"

        /// <summary>
        /// Executes Heath Check Command
        /// </summary>
        /// <returns></returns>
        private async Task ExecuteHealthCheckCommand()
        {
            var result = await UndoAPI.GetHeathCheck();
            if (result != null)
                await Dialog.ShowAsync("Success", result.environment);
            else
                await Dialog.ShowAsync("Error", "No records found");
        }

        /// <summary>
        /// Executes Test Error Command
        /// </summary>
        /// <returns></returns>
        private async Task ExecuteTestErrorCommand()
        {
            var result = await UndoAPI.GetTestError();
            if (result != null)
                await Dialog.ShowAsync("Error", result.Type);
            else
                await Dialog.ShowAsync("Error", "No records found");
        }

        #endregion


    }
}
