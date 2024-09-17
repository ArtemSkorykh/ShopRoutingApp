var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "newOrder",
    pattern: "newOrder",
    defaults: new { controller = "Shop", action = "Buy" });

app.MapControllerRoute(
    name: "oldUserSettings",
    pattern: "usersettings/{id:int}",
    defaults: new { controller = "User", action = "Settings" });

app.MapControllerRoute(
    name: "newUserSettings",
    pattern: "user/settings/{id:int}",
    defaults: new { controller = "User", action = "Settings" },
    constraints: new { id = @"[1-9]\d{0,2}" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();