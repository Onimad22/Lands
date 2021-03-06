using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Lands.ViewModels
{
    class LoginViewModel
    {
        #region Properties
        public string Email
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public bool IsRunning
        {
            get;
            set;
        }

        public bool IsRemembered
        {
            get;
            set;
        }

        public ICommand LoginCommand
        {
            get;
            set;
        }
        #endregion

        #region Constructor
        public LoginViewModel()
        {
            this.IsRemembered = true;
        }

        #endregion
    }
}
