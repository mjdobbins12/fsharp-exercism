module Allergies

open System

[<FlagsAttribute>]
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

let list codedAllergies = failwith "You need to implement this function."