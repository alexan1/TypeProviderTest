// Learn more about F# at http://fsharp.org

open System
open FSharp.Data

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    let data = WorldBankData.GetDataContext()

    let result =
        data
            .Countries.``United Kingdom``
            .Indicators.``Gross capital formation (% of GDP)``
            |> Seq.maxBy fst

    let dada1 = 
    //printfn "%i" result
    0 // return an integer exit code
