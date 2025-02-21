using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI_ToDoList.ViewModels
{
    public class CreateToDoTaskPageViewModel : ViewModelBase
    {
        private string _text;
        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged(nameof(Text));
            }
        }

        private string _importance;
        public string Importance
        {
            get { return _importance; }
            set
            {
                _text = value;
                OnPropertyChanged(nameof(Importance));
            }
        }

        private DateTime _dueDate;
        public DateTime DueDate
        {
            get { return _dueDate; }
            set
            {
                _dueDate = value;
                OnPropertyChanged(nameof(DueDate));
            }
        }

        private string _note;
        public string? Note
        {
            get { return _note; }
            set
            {
                _note = value;
                OnPropertyChanged(nameof(Note));
            }
        }

        private int _userID;
        public int UserID
        {
            get { return _userID; }
        }
    }
}
