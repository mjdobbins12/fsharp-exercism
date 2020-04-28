module OcrNumbers

let convert (input: List<string>) =
    let convertSecond (input: List<string>) =
        match input.Head with
        | "  |" -> Some "1"
        | _ -> Some "?"
    
    match input.Head with
    | " _ " -> Some "0"
    | "   " -> convertSecond input.Tail
    | _ -> None
