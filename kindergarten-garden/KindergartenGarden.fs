module KindergartenGarden

type Plant = Clover | Grass | Radishes | Violets

let kids = ["Alice"; "Bob"; "Charlie"; "David"; "Eve"; "Fred"; "Ginny"; "Harriet"; "Ileana"; "Joseph"; "Kincaid"; "Larry"]

let plants (diagram: string) (student: string) =
    let ind = List.findIndex (fun x -> x = student) kids
   
    diagram.Split '\n'
    |> Seq.collect (Seq.toList >> (List.chunkBySize 2) >> (fun x -> x.[ind]))
    |> Seq.map (function
        | 'C' -> Plant.Clover
        | 'G' -> Plant.Grass
        | 'R' -> Plant.Radishes
        | 'V' -> Plant.Violets)
    |> Seq.toList