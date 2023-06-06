using Etapa2.Contexts;
using Microsoft.EntityFrameworkCore;

internal class Program
{
	private static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		// Add services to the container.
		// var server = builder.Configuration["DbServer"] ?? "localhost";
		// var port = builder.Configuration["DbPort"] ?? "1433";
		// var user = builder.Configuration["DbUser"] ?? "SA";
		// var password = builder.Configuration["Password"] ?? "strong@123";
		// var database = builder.Configuration["Database"] ?? "Agenda";

		// var connectionString = $"Server={server},{port};Initial Catalog={database};User ID={user};Password={password}; Trust Server Certificate=True";

		// builder.Services.AddDbContext<AgendaContext>(options =>
		// 	options.UseSqlServer(connectionString));

        // Aqui será realizada a conexão com o Sql Server para que seja possível que
        // o Migration possa realizar sua função (criar o banco de dados Agenda e sua
        // tabela Contatos)

		builder.Services.AddDbContext<AgendaContext>(options =>
			options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConn")));

		builder.Services.AddControllers();
		// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
		builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddSwaggerGen();

		var app = builder.Build();

		// Configure the HTTP request pipeline.
		if (app.Environment.IsDevelopment())
		{
			app.UseSwagger();
			app.UseSwaggerUI();
		}

		app.UseHttpsRedirection();

		app.UseAuthorization();

		app.MapControllers();

		app.Run();
	}
}