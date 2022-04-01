using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using lib_books.DesktopUI.Commands;
using lib_books.DesktopUI.Models.BranchModels;

namespace lib_books.DesktopUI.ViewModel
{
    public class EditBranchViewModel:BaseWindowViewModel
    {
        public EditBranchViewModel(Window window):base(window)
        {
            EditBranchModel = new BranchModel();
            EditBranch = new EditBranchCommand(this);
        }
        public BranchModel EditBranchModel { get; set; }
        public ICommand EditBranch { get; set; }
    }
}
