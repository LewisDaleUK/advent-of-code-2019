module Day_One.FuelCounter

let Calculate_Mass (input : int) : int =
     int (floor ((float input) / 3.0) - 2.0)

let rec Calculate_Total_Mass (input : int) : int =
     let mass = Calculate_Mass(input)
     match mass with
     | t when t < 0 -> 0
     | _ ->
          mass + Calculate_Total_Mass(mass)
     