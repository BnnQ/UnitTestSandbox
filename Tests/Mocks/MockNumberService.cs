using Sandbox.Services.Abstraction;

namespace Tests.Mocks;

public class MockNumberService : INumberService
{
    public int GetNumber()
    {
        return 5;
    }
}