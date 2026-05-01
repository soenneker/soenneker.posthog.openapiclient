using Soenneker.Tests.HostedUnit;

namespace Soenneker.PostHog.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class PostHogOpenApiClientTests : HostedUnitTest
{
    public PostHogOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
