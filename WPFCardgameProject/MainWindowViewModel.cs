using CustomCollectionLibrary;
using Standard52CardDeck.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using WPFCardgameProject.BaseClasses;

namespace WPFCardgameProject
{
    public class MainWindowViewModel : ImplementINotifyPropertyChanged
    {
        #region Properties
        public Deck myDeck { get; set; }
        public ObservableStack<Card> CardsInDeck
        {
            get { return myDeck.CardsInLibrary; } 
            set { myDeck.CardsInLibrary = value; NotifyPropertyChanged(); }
        }
        #endregion

        #region Commands
        public ICommand ShuffleDeck { get; set; }
        private bool CanExecuteShuffleDeck(object param)
        {
            return true;
        }
        private void ExecuteShuffleDeck(object param)
        {
            CardsInDeck.Shuffle();
        }
        #endregion

        public MainWindowViewModel()
        {
            myDeck = new Deck();
            ShuffleDeck = new RelayCommand(ExecuteShuffleDeck, CanExecuteShuffleDeck);
        }
    }
}
