module Day_Two.Tests

open NUnit.Framework

open Day_Two.Intcode

[<Test>]
let Test_Option_One_Adds () =
    let input = [|1;0;0;0;99|]
    let expected = [|2;0;0;0;99|]
    let result = Parse_Program(input, 0)
    Assert.AreEqual(expected, result)

[<Test>]
let Test_Another_Option_One () =
    let input = [|1;0;0;5;99;0|]
    let expected = [|1;0;0;5;99;2|]
    let result = Parse_Program(input, 0)
    Assert.AreEqual(expected, result)
    
[<Test>]
let Test_99_Halts_Program () =
    let input = [|99; 0; 0; 0; 1; 0; 0; 0;|]
    let result = Parse_Program(input, 0)
    Assert.AreEqual(input, result)
    
[<Test>]    
let Test_Option_2_Multiplies_Values () =
    let input = [|2;3;0;3;99|]
    let expected = [|2;3;0;6;99|]
    let result = Parse_Program(input, 0)
    Assert.AreEqual(expected, result)
    
    
[<Test>]
let Test_Parses_Complex_Programs () =
    let input =    [|1; 0; 0; 0; 2; 4; 4; 3; 99|]
    let expected = [|2; 0; 0; 4; 2; 4; 4; 3; 99|]
    let result = Parse_Program(input, 0)
    Assert.AreEqual(expected, result)
    
[<Test>]
let Test_Another_Case () =
    let input = [|2;4;4;5;99;0|]
    let expected = [|2;4;4;5;99;9801|]
    let result = Parse_Program(input, 0)
    Assert.AreEqual(expected, result)
    
[<Test>]
let Test_More_Complex_Intcode () =
    let input = [|1;1;1;4;99;5;6;0;99|]
    let expected = [|30;1;1;4;2;5;6;0;99|]
    let result = Parse_Program(input, 0)
    Assert.AreEqual(expected, result)