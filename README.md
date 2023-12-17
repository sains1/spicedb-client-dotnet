# SpiceDB Starter .NET

SpiceDB Client for .NET generated from authzed protobuf definitions

## Getting Started

-- 

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
