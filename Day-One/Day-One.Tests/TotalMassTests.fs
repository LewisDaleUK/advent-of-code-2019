module Date_One.Tests.TotalMassTests

open NUnit.Framework
open Day_One.FuelCounter

[<Test>]
let TestMass14GivesTotalFuel2 () =
    Assert.AreEqual(Calculate_Total_Mass 14, 2)

[<Test>]    
let TestMass1969GivesTotalFuel966 () =
    Assert.AreEqual(Calculate_Total_Mass 1969, 966)
    
[<Test>]    
let TestMass100756Gives50346 () =
    Assert.AreEqual(Calculate_Total_Mass 100756, 50346)
