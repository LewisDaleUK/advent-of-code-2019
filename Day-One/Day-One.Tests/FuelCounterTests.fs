module Day_One.Tests

open Day_One
open NUnit.Framework
open Day_One.FuelCounter

[<SetUp>]
let Setup () =
    ()

[<Test>]
let TestMass12Gives2 () =
    Assert.AreEqual(Calculate_Mass(12), 2)

[<Test>]
let TestMass14Gives2 () =
    Assert.AreEqual(Calculate_Mass(14), 2)