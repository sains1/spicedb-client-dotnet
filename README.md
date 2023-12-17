# SpiceDB .NET

SpiceDB Client for .NET, generated from authzed protobuf definitions

## Getting Started

### 1. Install client package

```sh
dotnet add package sains1.SpiceDbClient
```

### 2. Add the GRPC clients

The code below shows how to configure the clients using GRPC client factory in your `Program.cs`. You probably only need the `PermissionsServiceClient` to begin with.

```csharp
// Program.cs

builder.Services.AddGrpcClient<PermissionsService.PermissionsServiceClient>(ConfigureSpiceDbGrpcClient)
    .ConfigureChannel(ConfigureSpiceDbChannel);

builder.Services.AddGrpcClient<SchemaService.SchemaServiceClient>(ConfigureSpiceDbGrpcClient)
    .ConfigureChannel(ConfigureSpiceDbChannel);

builder.Services.AddGrpcClient<ExperimentalService.ExperimentalServiceClient>(ConfigureSpiceDbGrpcClient)
    .ConfigureChannel(ConfigureSpiceDbChannel);

builder.Services.AddGrpcClient<WatchService.WatchServiceClient>(ConfigureSpiceDbGrpcClient)
    .ConfigureChannel(ConfigureSpiceDbChannel);

void ConfigureSpiceDbGrpcClient(IServiceProvider provider, GrpcClientFactoryOptions options)
{
    // NOTE - Configure the SpiceDB address instead of hardcoding it
    options.Address = new Uri("http://localhost:50051");
}

void ConfigureSpiceDbChannel(IServiceProvider provider, GrpcChannelOptions options)
{
    var credentials = CallCredentials.FromInterceptor((context, metadata) =>
    {
        // NOTE - Configure the token instead of hardcoding it
        const string token = "somerandomkeyhere";
        metadata.Add("Authorization", $"Bearer {token}");
        return Task.CompletedTask;
    });

    // NOTE - Configure TLS and don't use InsecureChannelCallCredentials in production
    options.UnsafeUseInsecureChannelCallCredentials = true;
    options.Credentials = ChannelCredentials.Create(ChannelCredentials.Insecure, credentials);
}
```

### 3. Use the client to check permissions

```csharp
public class MyService
{
    private readonly PermissionsService.PermissionsServiceClient _client { get; set; }
    public MyService(PermissionsService.PermissionsServiceClient client)
    {
        _client = client;   
    }

    public async Task<bool> CheckCanSeeThing(string userName, string thingName)
    {
        var permission = await _client.CheckPermissionAsync(new CheckPermissionRequest
        {
            Consistency = new Consistency
            {
                FullyConsistent = true
            },
            Subject = new SubjectReference
            {
                Object = new ObjectReference
                {
                    ObjectType = "user",
                    ObjectId = userName
                }
            },
            Permission = "can_see_thing",
            Resource = new ObjectReference
            {
                ObjectType = "thing",
                ObjectId = thingName
            }
        });

        return permission.Permissionship == CheckPermissionResponse.Types.Permissionship.HasPermission;
    }
}
```

## Generating an updated gRPC client

1. Install buf from https://docs.buf.build/installation (or `npm install`)

2. Find the updated dependency ids from the [SpiceDB buf lockfile](https://github.com/authzed/api/blob/main/buf.lock)

3. Replace the authzed version and dependency commit ids in the package.json with those from the lockfile

4. Update package version in [SpiceDbClient.csproj](./SpiceDbClient/SpiceDbClient.csproj)

## Helpful links

- [Authzed API docs](https://buf.build/authzed/api/docs/main:authzed.api.v1)
- [SpiceDB docs](https://authzed.com/docs)
- [Annotated Zanzibar paper](https://zanzibar.tech/)
- [buf.build docs](https://buf.build/docs/introduction)
