// Learn more about F# at http://fsharp.org

open System
open UpdateProductDimensions
open System.Data.Common
open System.Data.SqlClient

[<EntryPoint>]
let main argv =
    let flip blah x y = blah y x

    
    printfn "Hello World from F#!"
     // return an integer exit code
    //0

    let getDbConnection() =
        let connection =  new SqlConnection("connection_string")
        connection.Open()
        connection
        

    let getAllProducts() =
        DB.allProducts (getDbConnection())
        |> fun x -> match x with 
                    | Ok p-> p|> Seq.toList
                    | Error e -> List.Empty
    

    let tryUpdateProductDimensions=
        UseCase.updateProductDimensions getAllProducts
        |>


    let tryAccept capacity reservations reservation =
        let reservedSeats = reservations |> List.sumBy (fun x -> x.Quantity)
        if reservedSeats + reservation.Quantity <= capacity
        then { reservation with IsAccepted = true } |> Some
        else None
    
    let tryAcceptComposition reservation =
        reservation.Date
        |> DB.readReservations connectionString
        |> fun i -> i tryAccept(10), reservation

        //|> flip (tryAccept 10) reservation
        |> Option.map (DB.createReservation connectionString) |> ignore

    0