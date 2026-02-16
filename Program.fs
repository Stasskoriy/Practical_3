module Program

open System
open LibraryDomain

// Завдання 5. Демонстрація роботи


[<EntryPoint>]
let main argv =

    printfn "=== БІБЛІОТЕКА ===\n"

    printfn "Доступні книги:"
    availableBooks catalog
    |> List.iter (fun b -> printfn "%s" b.Title)

    printfn "\nКниги жанру Programming:"
    booksByGenre Programming catalog
    |> List.iter (fun b -> printfn "%s" b.Title)

    printfn "\nКниги George Orwell:"
    booksByAuthor "George Orwell" catalog
    |> List.iter (fun b -> printfn "%s" b.Title)

    printfn "\nУсі назви:"
    allTitles catalog |> List.iter (printfn "%s")

    printfn "\nСторінок у Programming: %d"
        (totalPagesByGenre Programming catalog)

    printfn "Середня кількість сторінок: %.2f"
        (averagePages catalog)

    0
