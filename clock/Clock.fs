module Clock

let create hours minutes =
    let adjustMins minutes =
        match minutes with
        | a when a < -60 -> (minutes / 60 - 1, 60 - abs minutes % 60)
        | b when b < 0 -> (-1, minutes + 60)
        | _ -> (minutes / 60, minutes % 60)

    let rec adjustedHrs hours =
        match hours with
        | a when a < 0 -> adjustedHrs (hours + 24)
        | _ -> hours % 24
    
    adjustMins minutes
    |> (fun (a, b) -> adjustedHrs (hours + a), b)

let add minutes clock = failwith "You need to implement this function."

let subtract minutes clock = failwith "You need to implement this function."

let display clock =
    sprintf "%02i:%02i" (fst(clock)) (snd(clock))