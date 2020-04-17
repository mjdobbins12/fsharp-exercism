module Allergies

open System

type Allergen =
    | Eggs = 1
    | Peanuts = 2
    | Shellfish = 4
    | Strawberries = 8
    | Tomatoes = 16
    | Chocolate = 32
    | Pollen = 64
    | Cats = 128

let allergicTo (codedAllergies: int) allergen =
    (enum<Allergen>(codedAllergies) &&& allergen) = allergen

let list (codedAllergies: int) =
    Enum.GetValues(typeof<Allergen>)
    |> Seq.cast<Allergen>
    |> Seq.filter (fun x -> allergicTo codedAllergies x)
    |> Seq.toList
