using System;
using System.Collections.Generic;
using System.Text;

namespace OnPropertyChanged.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _textBoxText = string.Empty;
        private string _labelText = string.Empty;

        public string TextBoxText
        {
            get { return _textBoxText; }

            set { _textBoxText = value; OnPropertyChanged(nameof(TextBoxText)); }
        }

        public string LabelText
        {
            get { return _labelText; }

            set { _labelText = value; OnPropertyChanged(nameof(LabelText)); }
        }

    }
}
