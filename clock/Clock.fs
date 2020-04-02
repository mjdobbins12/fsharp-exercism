module Clock

let create hours minutes =
    let adjustMins minutes =
        match minutes with
        | a when a < 0 -> (minutes / 60 - 1, abs (minutes + 60) % 60)
        | _ -> (minutes / 60, minutes % 60)

    let rec adjustedHrs hours =
        match hours with
        | a when a < 0 -> adjustedHrs (hours + 24)
        | _ -> hours 
    
    adjustMins minutes
    |> (fun (a, b) -> (((a + adjustedHrs hours) % 24), b))

let add minutes clock = failwith "You need to implement this function."

let subtract minutes clock = failwith "You need to implement this function."

let display clock =
    sprintf "%02i:%02i" (fst(clock)) (snd(clock))