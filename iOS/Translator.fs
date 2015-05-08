namespace Phoneword

open System
 
module Translator = 
    let ToNumber number =
        String.map (fun c -> match c with
                             | 'A' | 'B' | 'C' -> '2'
                             | 'D' | 'E' | 'F' -> '3'
                             | 'G' | 'H' | 'I' -> '4'
                             | 'J' | 'K' | 'L' -> '5'
                             | 'M' | 'N' | 'O' -> '6'
                             | 'P' | 'Q' | 'R' | 'S' -> '7'
                             | 'T' | 'U' | 'V' -> '8'
                             | 'W' | 'X' | 'Y' | 'Z' -> '9'
                             | _ -> c
                   ) number