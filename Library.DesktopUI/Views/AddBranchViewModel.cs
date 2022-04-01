using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using lib_books.DesktopUI.Commands.BranchCommands;
using lib_books.DesktopUI.Commands.ConfigCom;
using lib_books.DesktopUI.Models.BranchModels;
using lib_books.DesktopUI.ViewModel;

namespace lib_books.DesktopUI.Views
{
    public class AddBranchViewModel:BaseWindowViewModel
    {
        public AddBranchViewModel(Window window, BranchViewModel branchViewModel) : base(window)
        {
            SaveBranch = new SaveBranchCommand(this);
            AddBranchModel = new BranchModel();
            BranchViewModel = branchViewModel;
        }
        public ICommand SaveBranch { get; set; }
        public BranchViewModel BranchViewModel{ get; set; }
        public BranchModel AddBranchModel { get; set; }

    }
}
