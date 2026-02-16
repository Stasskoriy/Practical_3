module LibraryDomain

// Завдання 1. Моделювання предметної області


// Жанр
type Genre =
    | Fiction
    | NonFiction
    | Science
    | History
    | Programming
    | Other

// Статус
type Status =
    | Available
    | Borrowed
    | Archived

// Книга
type Book =
    {
        Id: int
        Title: string
        Author: string
        Year: int
        Genre: Genre
        Pages: int
        Status: Status
    }


// Завдання 2. Тестовий каталог


let catalog =
    [
        { Id=1; Title="Кобзар"; Author="Тарас Шевченко"; Year=1840; Genre=Fiction; Pages=320; Status=Available }
        { Id=2; Title="Мистецтво програмування"; Author="Donald Knuth"; Year=1968; Genre=Programming; Pages=650; Status=Borrowed }
        { Id=3; Title="Чистий код"; Author="Robert C. Martin"; Year=2008; Genre=Programming; Pages=450; Status=Available }
        { Id=4; Title="1984"; Author="George Orwell"; Year=1949; Genre=Fiction; Pages=328; Status=Available }
        { Id=5; Title="Sapiens"; Author="Yuval Noah Harari"; Year=2011; Genre=History; Pages=512; Status=Borrowed }
        { Id=6; Title="Домашнє кондитерство"; Author="Автор"; Year=2015; Genre=NonFiction; Pages=220; Status=Available }
        { Id=7; Title="Історія України"; Author="Автор"; Year=2003; Genre=History; Pages=300; Status=Archived }
        { Id=8; Title="Алгоритми"; Author="Cormen"; Year=1990; Genre=Programming; Pages=1312; Status=Available }
    ]



// Завдання 3. Фільтрація і пошук


let availableBooks books =
    books |> List.filter (fun b -> b.Status = Available)

let booksByGenre genre books =
    books |> List.filter (fun b -> b.Genre = genre)

let booksByAuthor author books =
    books |> List.filter (fun b -> b.Author = author)


// Завдання 4. Трансформації і агрегація


let allTitles books =
    books |> List.map (fun b -> b.Title)

let totalPagesByGenre genre books =
    books
    |> List.filter (fun b -> b.Genre = genre)
    |> List.map (fun b -> b.Pages)
    |> List.fold (+) 0

let averagePages books =
    let sum = books |> List.fold (fun acc b -> acc + b.Pages) 0
    float sum / float books.Length
