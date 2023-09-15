using Sandbox.Services.Abstraction;

namespace Sandbox.Services;

public class NumberService : INumberService
{
    public int GetNumber()
    {
        //какая-то настоящая логика по получению числа
        return Random.Shared.Next(1, 10);
    }
}