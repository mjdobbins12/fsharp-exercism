module Raindrops

let convert (number: int): string =
    match number with
    | a when a % 105 = 0 -> "PlingPlangPlong"
    | b when b % 15 = 0 -> "PlingPlang"
    | c when c % 21 = 0 -> "PlingPlong"
    | d when d % 35 = 0 -> "PlangPlong"
    | e when e % 3 = 0 -> "Pling"
    | f when f % 5 = 0 -> "Plang"
    | g when g % 7 = 0 -> "Plong"
    | _ -> string number