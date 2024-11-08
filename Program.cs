var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddRazorPages();
builder.Services.AddRazorPages(options => {
    options.RootDirectory = "/Pages";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (!app.Environment.IsDevelopment())
// {
//     app.UseExceptionHandler("/Error");
//     app.UseHsts();
// }
app.UseDeveloperExceptionPage(); // Enable detailed error page

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Add a test route
app.MapGet("/test", () => "Hello from the test route!");

app.MapRazorPages();

app.Run();
