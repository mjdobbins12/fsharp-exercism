module Leap

let leapYear (year: int): bool =
    match year with
    | a when a % 100 = 0 && not (a % 400 = 0) -> false
    | b when b % 4 = 0 -> true
    | _ -> false