namespace TextAnalyzer
    module Data =
        type PhraseScore =
            {
                Phrase : string
                Score : int32
            }

    module TextAnalyzer =
        open Data
        open System

        module private TextAnalyzer =
            let analyzeByWord (text : string) =
                    text.Split() |>
                    Array.map(fun x -> x.ToLowerInvariant().ToCharArray()) |>
                    Array.map(fun x -> x |>Array.filter(fun y -> not(Char.IsPunctuation(y) || Char.IsSeparator(y)))) |>
                    Array.map(fun x -> new string(x)) |>
                    Array.filter(fun x -> not(String.IsNullOrWhiteSpace(x))) |>
                    Array.countBy(id) |>
                    Array.map(fun (x,y) -> { Phrase = x; Score = y })              

            let analyzeBySentence x = x

            let analyzeByWordCombination x = x

        let analyzeText (text : string) =
            let byWordAnalysis = TextAnalyzer.analyzeByWord text

            text