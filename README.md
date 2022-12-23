# Publish Nuget package to Github Nuget Feed

- My github nuget feed url: `https://nuget.pkg.github.com/kolosovpetro/index.json`
- Local pack
  command: `dotnet pack "MyNugetPackage/MyNugetPackage.csproj" --output "nuget_pack_folder" --configuration "Release" -p:Version="0.1.0-alpha0003"`