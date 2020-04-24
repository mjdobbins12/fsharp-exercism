module OcrNumbers

let convert (input: List<string>) =
    match input.Head with
    | " _ " -> Some "0"
    | _ -> None