using BookStore.ViewModel;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Interfaces
{
    interface IContentEditor
    {
        bool Add(ObservableObject objectToAdd);
        bool Remove(ObservableObject objectToRemove);
        bool Edit(ObservableObject objectToRemove);
    }
}
