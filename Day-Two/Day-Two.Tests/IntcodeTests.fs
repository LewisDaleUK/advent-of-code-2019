module Day_Two.Tests

open NUnit.Framework

open Day_Two.Intcode

[<Test>]
let Test_Option_One_Adds () =
    let input = [|1;0;0;0;99|]
    let expected = [|2;0;0;0;99|]
    let result = Parse_Program input
    Assert.AreEqual(expected, result)

[<Test>]
let Test_Another_Option_One () =
    let input = [|1;0;0;5;99;0|]
    let expected = [|1;0;0;5;99;2|]
    let result = Parse_Program input
    Assert.AreEqual(expected, result)
    
[<Test>]
let Test_99_Halts_Program () =
    let input = [|99; 0; 0; 0; 1; 0; 0; 0;|]
    let result = Parse_Program input
    Assert.AreEqual(input, result)

    