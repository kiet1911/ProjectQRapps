//Create builder
var builder = WebApplication.CreateBuilder(args);

// Add services to the container
//this line is for adding controllers with views 
builder.Services.AddControllersWithViews();
//Create variable "app" to contain builder.Build() <- variable is Build 
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
//https control router , changes in pattern . Current Router only has name and pattern .
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}").WithStaticAssets();

//Run application setup
app.Run();
