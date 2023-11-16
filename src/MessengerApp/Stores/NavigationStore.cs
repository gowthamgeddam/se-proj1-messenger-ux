﻿using MessengerApp.ViewModels;
using MessengerDashboard;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessengerApp.Stores
{
    public class NavigationStore
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel?.Dispose();
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        private ViewModelBase _subViewModel;
        public ViewModelBase SubViewModel
        {
            get => _subViewModel;
            set
            {
                _subViewModel = value;
                OnSubViewModelChanged();
            }
        }

        public AuthenticationResult AuthResult { get; set; }

        public event Action CurrentViewModelChanged;

        public event Action SubViewModelChanged;

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }

        private void OnSubViewModelChanged()
        {
            SubViewModelChanged?.Invoke();
        }
    }
}
