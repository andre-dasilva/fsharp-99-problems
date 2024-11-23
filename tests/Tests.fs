module Tests

open Xunit

open fsharp_99_problems.Problems

[<Fact>]
let ``Tail of a List (Beginner)`` () =
    let test_func = last  
    Assert.Equal(test_func [ "a"; "b"; "c"; "d" ], Some "d")
    Assert.Equal(test_func [], None)