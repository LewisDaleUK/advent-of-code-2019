// Learn more about F# at http://fsharp.org

open Day_Two
open System
   
[<EntryPoint>]
let main argv =
    let filename = Array.head argv
    let content = System.IO.File.ReadAllText filename
    let values = content.Split ','
    let int_values = Array.map (fun a -> int a) values
    Array.set int_values 1 12
    Array.set int_values 2 2
    let result = Intcode.Parse_Program(int_values, 0)
    printfn "%d\n" result.[0]
    printfn "Hello World from F#!"
    0 // return an integer exit code
