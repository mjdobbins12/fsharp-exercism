module Clock

let create hours minutes =
    let rec minToHr minutes acc =
        match minutes with
        | a when a < 60 -> (acc, minutes)
        | _ -> minToHr (minutes - 60) (acc + 1)
    
    minToHr minutes 0
    |> (fun (a, b) -> ((hours % 24 + a), b))

let add minutes clock = failwith "You need to implement this function."

let subtract minutes clock = failwith "You need to implement this function."

let display clock =
    sprintf "%02i:%02i" (fst(clock)) (snd(clock))