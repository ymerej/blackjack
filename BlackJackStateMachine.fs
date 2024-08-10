module BlackJackStateMachine

type blackJackStateMachine =
    | DealPlayerFirstCard of Game
    | DealDealerFirstCard of Game
    | DealPlayerSecondCard of Game
    | DealDealerSecondCard of Game
    | PlayerTurn of Game * PlayerNumber
    | DealerTurn of Game
    | TallyRound of Game
    | EndGame of Game
and Game = {
    Players: Player list
    Dealer: Dealer
}
and Player = {
    Number: PlayerNumber
    Hand: Card list
    Wins: int
}
and Dealer = {
    Hand: Card list
    Wins: int
}
and PlayerNumber = int
and Card = {
    Suit: Suit
    Rank: Rank
}
and Suit =
    | Clubs
    | Diamonds
    | Hearts
    | Spades
and Rank =
    | Two
    | Three
    | Four
    | Five
    | Six
    | Seven
    | Eight
    | Nine
    | Ten
    | Jack
    | Queen
    | King
    | Ace
