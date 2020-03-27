module Accumulate

let accumulate (func: 'a -> 'b) (input: 'a list): 'b list =
    let rec loop inp acc =
        match inp with
        | head :: tail -> loop tail (func head :: acc)
        | [] -> List.rev acc
    loop input List.empty
