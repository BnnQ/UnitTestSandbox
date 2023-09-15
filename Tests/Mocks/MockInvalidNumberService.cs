using Sandbox.Services.Abstraction;

namespace Tests.Mocks;

public class MockInvalidNumberService : INumberService
{
    public int GetNumber()
    {
        return 10;
    }
}