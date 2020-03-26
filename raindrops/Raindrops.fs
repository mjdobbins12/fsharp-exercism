module Raindrops

let convert (number: int): string =
    match number with
    | a when a % 3 = 0 -> "Pling"
    | _ -> string number