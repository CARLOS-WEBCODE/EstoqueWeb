using EstoqueWeb.Infra.Data.Interfaces;
using EstoqueWeb.Infra.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

//Configurando o projeto para MVC
builder.Services.AddControllersWithViews();

//capturar a connectionstring mapeada no 'appsettings.json'

var connectionString = builder.Configuration.GetConnectionString("EstoqueWeb");

//enviar a connectionString para a classe ProdutoRepository
builder.Services.AddTransient<IProdutoRepository>(map => new ProdutoRepository(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
    );

app.Run();
