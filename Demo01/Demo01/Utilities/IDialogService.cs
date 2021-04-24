using System.Threading.Tasks;

namespace Demo01.Utilities
{
    public interface IDialogService
    {
        /// <summary>
        /// Show dialog
        /// </summary>
        /// <param name="title">Title</param>
        /// <param name="message">Message</param>
        Task ShowAsync(string title, string message);
    }
}
