using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using lib_books.DeskUI.Commands.BranchCommands;
using lib_books.DeskUI.Models.BranchModels;
using lib_books.DeskUI.ViewModel;
using lib_books.DeskUI.Commands.ConfigCom;

namespace lib_books.DeskUI.Views
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
