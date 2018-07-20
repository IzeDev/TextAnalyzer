// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let text = FileManager.Read.GetFileContent @"C:\Users\jimmy\source\repos\TextAnalyzer\TextAnalyzer\AppData\text.txt"
    printfn "%s" text
    let apa = TextAnalyzer.Main.doSomething 5



    Console.ReadKey() |> ignore
    0 // return an integer exit code
