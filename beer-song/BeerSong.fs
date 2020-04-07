module BeerSong

let recite (startBottles: int) (takeDown: int) =
    [
        string startBottles + " bottles of beer on the wall, " + string startBottles + " bottles of beer.";
        "Take one down and pass it around, " + string (startBottles - 1) + " bottles of beer on the wall."
    ]