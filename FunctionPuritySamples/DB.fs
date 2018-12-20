module DB

open System.Data.Common
open Dapper
open Rows
open Domain


let allProducts(connection: DbConnection) =

    try
        connection.Query<ProductRow>("select * from products")
        |> Seq.map(fun i-> new Product(i.ProductId, i.Name, i.Height, i.Weight, i.Length, i.Width))
        |> fun i-> Ok(i)
    
    with
    | ex -> Error ex


