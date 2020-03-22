module TwoFer

let twoFer (input: string option): string = 
    if input.IsNone then "One for you, one for me."
    else "One for " + input.Value + ", one for me."