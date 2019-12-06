module Day_One.Tests

open NUnit.Framework
open Day_One.FuelCounter

[<Test>]
let TestMass12Gives2 () =
    Assert.AreEqual(Calculate_Mass 12, 2)

[<Test>]
let TestMass14Gives2 () =
    Assert.AreEqual(Calculate_Mass 14, 2)
    
[<Test>]
let TestMass1969Gives654 () =
    Assert.AreEqual(Calculate_Mass 1969, 654)
       
[<Test>]
let TestMass100756Gives33583 () =
    Assert.AreEqual(Calculate_Mass 100756, 33583)
     