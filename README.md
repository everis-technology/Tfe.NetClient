![Tfe.NetClient](https://github.com/everis-technology/Tfe.NetClient/workflows/Tfe.NetClient/badge.svg)

# Tfe.NetClient

Tfe.NetClient is a .NET Client for Terraform Enterprise.

## Features

> Terraform Cloud API Documentation can be found [here](https://www.terraform.io/docs/cloud/api/index.html).


* [Applies](src/Tfe.NetClient/Features/Applies/README.md)
* [ConfigurationVersions](src/Tfe.NetClient/Features/ConfigurationVersions/README.md)
* [OAuthClient](src/Tfe.NetClient/Features/OAuthClient/README.md)
* [Organization](src/Tfe.NetClient/Features/Organization/README.md)
* [Plans](src/Tfe.NetClient/Features/Plans/README.md)
* [Runs](src/Tfe.NetClient/Features/Runs/README.md)
* [SSHKeys](src/Tfe.NetClient/Features/SSHKeys/README.md)
* [StateVersionOutputs](src/Tfe.NetClient/Features/StateVersionOutputs/README.md)
* [StateVersions](src/Tfe.NetClient/Features/StateVersions/README.md)
* [Teams](src/Tfe.NetClient/Features/Teams/README.md)
* [TeamWorkspaces](src/Tfe.NetClient/Features/TeamWorkspaces/README.md)
* [Workspaces](src/Tfe.NetClient/Features/Workspaces/README.md)
* [WorkspaceVariables](src/Tfe.NetClient/Features/WorkspaceVariables/README.md)

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