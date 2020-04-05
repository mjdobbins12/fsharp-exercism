module Bob

open System.Text.RegularExpressions

let (|RegexGroup|_|) pattern input =
   let m = Regex.Match(input, pattern) 
   if (m.Success) then Some m.Groups.[1].Value else None

let response (input: string): string =
    match input with
    | a when a = input.ToUpper() -> "Whoa, chill out!"
    | _ -> "Whatever."