module BeerSong

let regularVerse (startBottles: int)=
    [
        string startBottles + " bottles of beer on the wall, " + string startBottles + " bottles of beer.";
        "Take one down and pass it around, " + string (startBottles - 1) + " bottles of beer on the wall."
    ]

let twoBottlesVerse =
    [
        "2 bottles of beer on the wall, 2 bottles of beer.";
        "Take one down and pass it around, 1 bottle of beer on the wall."
    ]

let recite (startBottles: int) (takeDown: int) =
    match startBottles with
    | 2 -> twoBottlesVerse
    | _ -> regularVerse startBottles