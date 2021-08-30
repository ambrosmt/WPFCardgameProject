using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Standard52CardDeck.Models
{
    public enum StandardSuits
    {
        Heart = 0,
        Diamond = 1,
        Spade = 2,
        Club = 3
    }
    public enum StandardColors
    {
        Red = 0,
        Black = 1
    }

    public enum StandardValues
    {
        [Description("Joker")]
        Joker = 0,
        [Description("Ace")]
        Ace = 1,
        [Description("2")]
        Two = 2,
        [Description("3")]
        Three = 3,
        [Description("4")]
        Four = 4,
        [Description("5")]
        Five = 5,
        [Description("6")]
        Six = 6,
        [Description("7")]
        Seven = 7,
        [Description("8")]
        Eight = 8,
        [Description("9")]
        Nine = 9,
        [Description("10")]
        Ten = 10,
        [Description("Jack")]
        Jack = 11,
        [Description("Queen")]
        Queen = 12,
        [Description("King")]
        King = 13
    }
}
