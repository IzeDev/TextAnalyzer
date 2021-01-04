// Learn more about F# at http://fsharp.org

open System
open TextAnalyzer

[<EntryPoint>]
let main argv =
    let text = FileManager.Read.GetFileContent @"C:\Users\jimmy\Source\TextAnalyzer\TextAnalyzer\AppData\text.txt"
    printfn "%s" text
    let apa = TextAnalyzer.analyzeText text

    Console.Read() |> ignore
    0 // return an integer exit code
