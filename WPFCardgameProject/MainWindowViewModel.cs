using Standard52CardDeck.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using WPFCardgameProject.BaseClasses;

namespace WPFCardgameProject
{
    public class MainWindowViewModel : ImplementINotifyPropertyChanged
    {
        public Deck myDeck { get; set; }
        public Deck MyDeck { get { return myDeck; } set { myDeck = value; NotifyPropertyChanged(); } }

        public string BindCheck { get; set; }

        public MainWindowViewModel()
        {
            MyDeck = new Deck();
            BindCheck = "HelloWorld";
            MessageBox.Show("Deck Created");
        }
    }
}
