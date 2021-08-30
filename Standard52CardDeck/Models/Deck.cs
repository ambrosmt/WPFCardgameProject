using CustomCollectionLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Standard52CardDeck.Models
{
    public class Deck
    {
        public ObservableStack<Card> CardsInLibrary { get; set; }

        public Deck(bool AddJokers = false, bool Standard52 = true)
        {
            if (Standard52)
            {
                CardsInLibrary = CreateFreshDeck(AddJokers);
            }
        }

        public ObservableStack<Card> CreateFreshDeck(bool AddJokers)
        {
            ObservableStack<Card> deck = new ObservableStack<Card>();
            deck.AddRange(HeartCards());
            deck.AddRange(ClubCards());
            deck.AddRange(DiamondCards());
            deck.AddRange(SpadeCards());
            if (AddJokers)
            {
                deck.Push(new Card() { Color = StandardColors.Red, Value = StandardValues.Joker });
                deck.Push(new Card() { Color = StandardColors.Black, Value = StandardValues.Joker });
            }
            return deck;
        }

        public ObservableStack<Card> HeartCards()
        {
            ObservableStack<Card> hearts = new ObservableStack<Card>();
            for (int i = 1; i <= 13; i++)
            {
                hearts.Push(new Card((StandardValues)i, StandardSuits.Heart));
            }
            return hearts;
        }
        public ObservableStack<Card> ClubCards()
        {
            ObservableStack<Card> clubs = new ObservableStack<Card>();
            for (int i = 1; i <= 13; i++)
            {
                clubs.Push(new Card((StandardValues)i, StandardSuits.Club));
            }
            return clubs;
        }
        public ObservableStack<Card> DiamondCards()
        {
            ObservableStack<Card> diamond = new ObservableStack<Card>();
            for (int i = 13; i >= 1; i--)
            {
                diamond.Push(new Card((StandardValues)i, StandardSuits.Diamond));
            }
            return diamond;
        }
        public ObservableStack<Card> SpadeCards()
        {
            ObservableStack<Card> spade = new ObservableStack<Card>();
            for (int i = 13; i >= 1; i--)
            {
                spade.Push(new Card((StandardValues)i, StandardSuits.Spade));
            }
            return spade;
        }
    }
}
