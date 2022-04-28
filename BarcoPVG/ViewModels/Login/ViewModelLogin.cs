﻿using BarcoPVG.Models.Classes;
using BarcoPVG.Models.Db;
using BarcoPVG.Viewmodels;
using BarcoPVG.Views;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BarcoPVG.ViewModels.Login
{
    public class ViewModelLogin : AbstractViewModelBase
    {
        private ICommand loginCommand;
        //public DelegateCommand MainWindowCommand { get; set; }

        public ViewModelLogin() 
        {
            //MainWindowCommand = new DelegateCommand(DisplayMainWindow);
        }

        public ICommand LoginCommand
        {
            get
            {
                if (loginCommand == null)
                {
                    loginCommand = new Command((param) => this.DisplayLogin(param));
                }
                return loginCommand;
            }
            set
            {
                loginCommand = value;
            }
        }


        private void DisplayLogin(object param)
        {
            ObservableCollection<object> listParameter = (ObservableCollection<object>)param;
            List<Person> allUser = _dao.GetAllUser();
            Person loginPerson = null ; 

            foreach (Person person in allUser)
            {
                if (person.Voornaam == (string)listParameter[0] && person.wachtwoord == (string)listParameter[1])
                {
                    //MessageBox.Show("OK");
                    loginPerson = person;
                }
            }

            if (loginPerson != null)
            {
                _dao.LoginSucceedded(loginPerson);

                //Hide Login screen.
                Application.Current.Windows[0].Hide();
                //foreach (Window item in Application.Current.Windows)
                //{
                //    item.Hide();
                //}

                DisplayMainWindow();
            }
            else
            {
                MessageBox.Show("User or/and Password is not correct");
            }
        }


        public void DisplayMainWindow()
        {         
            MainWindow mainw = new MainWindow();
            mainw.Show();
        }
    }
}