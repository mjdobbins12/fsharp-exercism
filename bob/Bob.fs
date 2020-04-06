module Bob

open System

let (|Question|_|) (str: string) =
   if str.EndsWith '?' then Some Question else None

let (|Shout|_|) (str: string) =
   let allCaps = str.ToCharArray() |> Seq.filter Char.IsLetter
   if Seq.length allCaps > 0 && allCaps |> Seq.forall Char.IsUpper
   then Some Shout
   else None

let response (input: string): string =
    match input.Trim() with
    | "" -> "Fine. Be that way!"
    | Question & Shout -> "Calm down, I know what I'm doing!"
    | Question -> "Sure." 
    | Shout -> "Whoa, chill out!"
    | _ -> "Whatever."