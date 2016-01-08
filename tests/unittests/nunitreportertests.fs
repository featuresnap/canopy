module nunitreportertests

open NUnit.Framework
open Swensen.Unquote



type NUnitReporter() = class end

[<Test>]
let ``can instantiate reporter``() =
    let reporter = new NUnitReporter()
    test <@ Some(reporter) |> Option.isSome @>
   

