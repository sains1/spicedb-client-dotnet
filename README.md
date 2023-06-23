# SpiceDB Starter .NET

A simple starter project for using SpiceDB with .NET

## Pre-requisites

- [Docker](https://docs.docker.com/engine/install/)
- [Zed CLI](https://github.com/authzed/zed)
- [.NET 7](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)

## Running the project

1. Run instance of SpiceDB

```bash
docker run -d --rm \
    -p 50051:50051 \
    --name spicedb \
    authzed/spicedb serve \
    --grpc-preshared-key "somerandomkeyhere"
```

2. Write the schema

```bash
zed context set dev localhost:50051 somerandomkeyhere --insecure
zed schema write ./schema.zed
```

3. Run the project

```bash
dotnet run --project Api
```

4. Open swagger document on http://localhost:5000/swagger/index.html

## Generating an updated gRPC client

1. Install buf from https://docs.buf.build/installation

2. Find the updated dependency ids from the [SpiceDB buf lockfile](https://github.com/authzed/api/blob/main/buf.lock)

3. Replace the dependency commit ids in the command below with those from the lockfile

```bash
buf generate buf.build/authzed/api --path authzed/api/v1/ -o ./SpiceDbClient/generated/authzed.api

buf generate buf.build/envoyproxy/protoc-gen-validate:45685e052c7e406b9fbd441fc7a568a5 \
    -o ./SpiceDbClient/generated/envoyproxy.protoc-gen-validate

buf generate buf.build/googleapis/googleapis:62f35d8aed1149c291d606d958a7ce32 \
    --path google/api/annotations.proto \
    --path google/api/http.proto \
    -o ./SpiceDbClient/generated/googleapis.googleapis

buf generate buf.build/grpc-ecosystem/grpc-gateway:bc28b723cd774c32b6fbc77621518765 \
    -o ./SpiceDbClient/generated/grpc-ecosystem.grpc-gateway
```

## Repo structure & important files

- `Api` - ASP.NET 7 Web API project
- `SpiceDbClient` - SpiceDB gRPC client (auto-generated from protobuf definitions)
- `schema.zed` - Authzed schema definition
- `buf.gen.yaml` - buf configuration for generating the gRPC client

## Helpful links

- [Authzed API docs](https://buf.build/authzed/api/docs/main:authzed.api.v1)
- [SpiceDB docs](https://authzed.com/docs)
- [Annotated Zanzibar paper](https://zanzibar.tech/)
- [buf.build docs](https://buf.build/docs/introduction)
