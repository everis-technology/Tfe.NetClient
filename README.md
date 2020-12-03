![Tfe.NetClient](https://github.com/everis-technology/Tfe.NetClient/workflows/Tfe.NetClient/badge.svg)

# Tfe.NetClient

Tfe.NetClient is a .NET Client for Terraform Enterprise.

## Basic usage

### Add the package to your project

``` shell
dotnet add package Tfe.NetClient
``` 

### Create a **TfeConfig** object

``` csharp
var httpClient = new HttpClient();
var config = new TfeConfig(<YOUR TOKEN HERE>, httpClient);
``` 

### Create the **TfeClient**

``` csharp
var client = new TfeClient(config);
```

### Create a request and call the correponding method

``` csharp
/// This sample creates a workspace
/// Create a WorkspacesRequest
var request = new WorkspacesRequest();
var workspaceName = $"test-{Guid.NewGuid().ToString()}";
request.Data.Attributes.Name = workspaceName;

/// Call the CreateAsync method.
var result = await client.Workspace.CreateAsync(organizationName, request);
```

Please check the Integration tests [here](test/Tfe.NetClient.Test.Integration) for more samples.

## Contributing to Tfe.NetClient

Check our Contributing guidelines [here](CONTRIBUTING.md).
 
## Clone the repo

```bash
mkdir -p everis-technology/Tfe.NetClient
git clone https://github.com/everis-technology/Tfe.NetClient everis-technology/Tfe.NetClient
```