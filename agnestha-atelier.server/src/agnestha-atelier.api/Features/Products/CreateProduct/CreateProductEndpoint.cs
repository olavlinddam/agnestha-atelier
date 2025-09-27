namespace agnestha_atelier.api.Features.Products.CreateProduct;

public class CreateProductEndpoint : Endpoint<CreateProductRequest, CreateProductResponse>
{
    public override void Configure()
    {
        Post("/api/products/create");
        AllowAnonymous();
    }

    public override async Task HandleAsync(MyRequest req, CancellationToken ct)
    {
        await Send.OkAsync(new()
        {
            FullName = req.FirstName + " " + req.LastName,
            IsOver18 = req.Age > 18
        });
    }
}
