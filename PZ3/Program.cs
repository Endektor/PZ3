var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSession(o => o.IOTimeout = TimeSpan.FromSeconds(1000));
builder.Services.AddDistributedSqlServerCache(o =>
{
    o.ConnectionString = "Data Source=Endektor\\SQLEXPRESS; Integrated Security=false; User ID = sa; Password = 1q2w3e4r";
    o.SchemaName = "dbo";
    o.TableName = "SQLSessions";
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();
else
    app.UseExceptionHandler("/Error");

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();

app.MapRazorPages();

app.Run();
