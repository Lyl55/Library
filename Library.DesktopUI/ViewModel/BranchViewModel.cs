using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using lib_books.Core;
using lib_books.DesktopUI.Commands.BranchCommands;
using lib_books.DesktopUI.Models.BranchModels;

namespace lib_books.DesktopUI.ViewModel
{
    public class BranchViewModel:BaseUserControlViewModel
    {
        public BranchViewModel(UserControl control) : base(control)
        {
            var branches = Kernel.DB.BranchRepository.Get();
            Branches = new ObservableCollection<BranchModel>();
            int count = 1;
            foreach (var branch in branches)
            {
                Branches.Add(new BranchModel
                {
                    Id=branch.Id,
                    No = count++,
                    Name =branch.Name,
                    Address = branch.Address
                });
                ExportBranch = new ExportBranchCommand(this);
            }

            AddBranch = new OpenAddBranchCommand(this);
            DeleteBranch = new DeleteBranchCommand(this);
            EditBranchWindow = new OpenEditBranchWindowCommand(this);
        }
        public ICommand AddBranch { get; set; }
        public ICommand DeleteBranch { get; set; }
        public ICommand OpenAddAuthor { get; set; }
        public ObservableCollection<BranchModel> Branches { get; set; }
        public BranchModel SelectedModel { get; set; }
        public ICommand EditBranchWindow { get; set; }
        public ICommand ExportBranch { get; set; }
    }
}
