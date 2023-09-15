using Microsoft.AspNetCore.Mvc;
using Razor.Templating.Core;
using Sandbox.Controllers;
using Tests.Mocks;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public async Task GreetingAction_ReturnsViewWithHelloMessage()
    {
        //получаем объект для теста
        var controller = new HomeController(new MockNumberService());
        var name = "Alex";
        var viewName = "Greeting";

        //проверка что тип результаат правильный
        var result = Assert.IsType<ViewResult>(controller.Greeting(name));
        
        Assert.NotNull(result);
        //проверка что вернулось правильное вью
        Assert.Equal(viewName, result.ViewName);

        var viewHtml =
            await RazorTemplateEngine.RenderAsync("Home/" + viewName, name);

        Assert.NotNull(viewHtml);
        //проверка что в HTML сгенерированного view содержится строка "Hello Alex"
        Assert.Contains("Hello " + name, viewHtml);
    }

    [Fact]
    public void GetNumberAction_ReturnsNumber()
    {
        var controller = new HomeController(new MockInvalidNumberService());
        var number = Assert.IsType<int>(Assert.IsType<OkObjectResult>(controller.GetNumber()).Value);

        Assert.Equal(5, number);
    }
}