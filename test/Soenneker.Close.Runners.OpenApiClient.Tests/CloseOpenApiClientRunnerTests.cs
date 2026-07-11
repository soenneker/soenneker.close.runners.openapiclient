using Soenneker.Tests.HostedUnit;

namespace Soenneker.Close.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class CloseOpenApiClientRunnerTests : HostedUnitTest
{
    public CloseOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
