// Learn more about F# at http://fsharp.org

module Day_One.Program
open System

let MapLines (line : String) : int =
     FuelCounter.Calculate_Total_Mass (int line)
     
[<EntryPoint>]
let main argv =
     let filename = Array.head argv
     let lines = System.IO.File.ReadLines filename
     let vals = Seq.map MapLines lines
     printf "%d" (Seq.sum vals)
     0 // return an integer exit code
