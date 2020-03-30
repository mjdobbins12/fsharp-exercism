module Clock

let create hours minutes =
    (hours % 24, minutes)

let add minutes clock = failwith "You need to implement this function."

let subtract minutes clock = failwith "You need to implement this function."

let display clock =
    sprintf "%02i:%02i" (fst(clock)) (snd(clock))