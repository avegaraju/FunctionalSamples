module Domain

type ProductType = 
    | Parcel
    | XL
    | WhiteGood

type Product (productId: int, 
                name :string, 
                height: decimal,
                weight: decimal,
                length: decimal,
                width: decimal,
                productType: ProductType) =
    
    let mutable _productId = productId
    let mutable _name = name
    let mutable _height = height
    let mutable _weight = weight
    let mutable _length = length
    let mutable _width = width
    let mutable _productType = productType

    let applyXlDimensions (product:Product) =
        new Product(product.ProductId,
                        product.Name,
                        product.Height
                        product.Weight,
                        product.Length,
                        product.Width,
                        product.ProductType)

    member this.ProductId with get() = _productId
    member this.ProductId with private set(value) = _productId <- value

    member this.Name with get() = _name
    member this.Name with private set (value) = _name <- value

    member this.Height with get() = _height
    member this.Height with private set(value) = _height <- value

    member this.Weight with get() = _weight 
    member this.Weight with private set(value) = _weight <- value

    member this.Length with get() = _length 
    member this.Length with private set(value) = _length <- value

    member this.Width with get() = _width
    member this.Width with private set(value) = _width <-value

    member this.ProductType with get() = _productType
    member this.ProductType with private set(value) = _productType <- value

    member this.UpdateDimensions()= 
        match this.ProductType with
            |  XL  -> applyXlDimensions this
            | Parcel -> applyXlDimensions this
            | WhiteGood -> applyXlDimensions this
