using Microsoft.EntityFrameworkCore;
using Prototipo.Curso.MVC.Dados.Context;
using Prototipo.Curso.MVC.Dados.Interfaces;
using Prototipo.Curso.MVC.Dados.Repository;

var builder = WebApplication.CreateBuilder(args);

#region ADD CONNECTION STRING
builder.Services.AddDbContext<LocadoraContext>(options =>
{
    options.UseSqlServer(builder.Configuration["SqlConnection:SqlConnectionString"]);
});
#endregion

#region Injetando abstrações
builder.Services.AddScoped<LocadoraContext>();
builder.Services.AddScoped<ICidadeRepository, CidadeRepository>();
builder.Services.AddScoped <IClienteRepository, ClienteRepository>();
builder.Services.AddScoped <IDiretorRepository, DiretorRepository>();
builder.Services.AddScoped <IEnderecoClienteRepository,EnderecoClienteRepository>();
builder.Services.AddScoped<IEnderecoFuncionarioRepository, EnderecoFuncionarioRepository>();
builder.Services.AddScoped <IEstadoRepository, EstadoRepository>();
builder.Services.AddScoped<IFilmeRepository, FilmeRepository>();
builder.Services.AddScoped <IFuncionarioRepository, FuncionarioRepository>();
builder.Services.AddScoped<IGeneroRepository, GeneroRepository>();
builder.Services.AddScoped <IItemLocacaoRepository, ItemLocacaoRepository>();
builder.Services.AddScoped <ILocacaoRepository, LocacaoRepository>();
#endregion
 
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
