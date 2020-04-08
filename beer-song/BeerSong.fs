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

let oneBottleVerse =
    [
        "1 bottle of beer on the wall, 1 bottle of beer.";
        "Take it down and pass it around, no more bottles of beer on the wall."
    ]

let noBottlesVerse = 
    [
        "No more bottles of beer on the wall, no more bottles of beer.";
        "Go to the store and buy some more, 99 bottles of beer on the wall."
    ]

let recite (startBottles: int) (takeDown: int) =
    match startBottles with
    | 2 -> twoBottlesVerse
    | 1 -> oneBottleVerse
    | 0 -> noBottlesVerse
    | _ -> regularVerse startBottles