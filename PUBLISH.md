
## Publishing to Nuget

First ensure that the project is built and up to date, then:

```
# Generate the .nupkg file
nuget pack .\src\Squiggle\Squiggle.csproj

# Push the package to Nuget
nuget push Squiggle.0.2.8.nupkg -Source https://api.nuget.org/v3/index.json
```