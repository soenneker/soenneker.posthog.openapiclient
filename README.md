[![](https://img.shields.io/nuget/v/soenneker.posthog.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.posthog.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.posthog.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.posthog.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.posthog.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.posthog.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.posthog.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.posthog.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.PostHog.OpenApiClient

Generated request builders and models for PostHog organizations, projects, insights, feature flags, experiments, dashboards, cohorts, recordings, surveys, data pipelines, and more.

## Installation

```bash
dotnet add package Soenneker.PostHog.OpenApiClient
```

## Usage

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.PostHog.OpenApiClient;

using var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", personalApiKey);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient)
{
    BaseUrl = "https://us.posthog.com"
};

var client = new PostHogOpenApiClient(adapter);
var organizations = await client.Api.Organizations.GetAsync(
    cancellationToken: cancellationToken);
```

Set `BaseUrl` to the account's regional PostHog host or self-hosted root URL. Management endpoints use a scoped personal API key; PostHog project keys intended for event ingestion do not authorize these requests.
