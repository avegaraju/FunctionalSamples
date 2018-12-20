module UseCase

open Domain

let findProduct (productId: int, products: List<Product>)=
    products
    |> Seq.exists<Product>(fun p-> p.ProductId = productId)
    |> 
    product

let updateProduct (product: Product)=
    
    let product = new Product(p.ProductId,
                                p.Name,
                                p.Height,
                                p.Weight,
                                p.Length,
                                p.Width)
    product.



let updateProductDimensions productId products productToPersist =
    products
    |> findProduct productId, products
    |> updateProduct
    