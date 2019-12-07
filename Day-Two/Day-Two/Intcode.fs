module Day_Two.Intcode
open System

let Modify_Input (input : int[], position : int, fn) =
    let first = Array.get input (position + 1)
    let second = Array.get input (position + 2)
    let write_position = Array.get input (position + 3)
    let value = fn input.[first] input.[second]
    Array.set input write_position value

let rec Parse_Program (input : int[], position : int) : int[] =
    let option = Array.get input position

    match option with
    | 1 ->
        Modify_Input(input, position, fun a b -> a + b)
        Parse_Program(input, position + 4)
    | 2 ->
        Modify_Input(input, position, fun a b -> a * b)
        Parse_Program(input, position + 4)
    | 99 -> input   
    | _ -> input