# CoverletAwaitThrowInsideCatch

Repro for missing coverage when re-throwing after an `await` inside a `catch` block.

Coverage is generated as follows: 

```
dotnet test Example.Tests/Example.Tests.csproj /p:CollectCoverage=true /p:Include=[Example*]*
```
