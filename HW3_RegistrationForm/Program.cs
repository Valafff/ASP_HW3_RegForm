var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Позволяет использовать сторонние файлы стилей в /wwwroot/css
app.UseStaticFiles();

app.Run(async (context) =>
{
	var path = context.Request.Path;
	var fullPath = $"html/{path}";
	var response = context.Response;

	response.ContentType = "text/html; charset=utf-8";
	if (path == "/")
	{
		await response.SendFileAsync($"{fullPath}/index.html");
	}

	if (context.Request.Path == "/postuserdata")
	{
		var form = context.Request.Form;
		string login = form["login"];
		string firstName = form["firstName"];
		string secondName = form["secondName"];
		string userEmail = form["userEmail"];
		string password = form["password"];


		await context.Response.WriteAsync($"<div><p>Login:\t{login}</p>" +
			$"<p>Имя:\t{firstName}</p>" +
			$"<p>Имя:\t{secondName}</p>" +
			$"<p>Имя:\t{userEmail}</p>" +
			$"<p>Пароль пользователя:\t{password}</p></div>");
	}

});


app.Run();
