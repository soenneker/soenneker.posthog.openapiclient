using Soenneker.TestHosts.Unit;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.PostHog.OpenApiClient.Tests;

[ClassDataSource<UnitTestHost>(Shared = SharedType.PerTestSession)]
public sealed class PostHogOpenApiClientTests : HostedUnitTest
{
    public PostHogOpenApiClientTests(UnitTestHost host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
