using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Demo01.Models;
using Demo01.Network;
using Demo01.Services;
using Demo01.Utilities;
using Xamarin.Forms;

namespace Demo01.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

        /// <summary>
        /// Resolve dialog service
        /// </summary>
        public IDialogService Dialog => DependencyService.Get<IDialogService>();

        /// <summary>
        /// Resolve Undo API service
        /// </summary>
        public IUndoService UndoAPI => DependencyService.Get<IUndoService>();

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
