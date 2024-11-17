var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//��������� ������������ ��������� ����� ������ � /wwwroot/css
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
			$"<p>���:\t{firstName}</p>" +
			$"<p>���:\t{secondName}</p>" +
			$"<p>���:\t{userEmail}</p>" +
			$"<p>������ ������������:\t{password}</p></div>");
	}

});


app.Run();
