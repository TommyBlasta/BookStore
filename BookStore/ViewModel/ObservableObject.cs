using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BookStore.ViewModel
{
    public abstract class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            //Is something subscribed to the event?
            if(PropertyChanged!=null)
            {
                //Inovke the event with this object as sender and the property name 
                //as info about changed property
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
