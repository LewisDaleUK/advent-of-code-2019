module Day_Two.Intcode

let Parse_Program (input : int[]) : int[] =
    let values = Array.sub input 0 4
    let option = Array.head values
    
    match option with
    | 1 ->
        let first = input.[1]
        let second = input.[2]
        let write_position = input.[3]
        let value = input.[first] + input.[second]
        Array.set input write_position value
        input
    | _ -> input    