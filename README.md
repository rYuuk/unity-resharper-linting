# A Unity Linting Using Resharper
[![rider linting](https://github.com/rYuuk/unity-resharper-linting/actions/workflows/linting.yml/badge.svg)](https://github.com/rYuuk/unity-resharper-linting/actions/workflows/linting.yml)

This is a sample Unity Project demonstrating linting check using Resharper via Github action.
For linting, resharper's [Inspect Code](https://www.jetbrains.com/help/resharper/InspectCode.html) is used. 
It uses a .dotSettings file in source for validating the rules, more can be found out about this [here](https://www.jetbrains.com/help/rider/InspectCode.html#configuring-inspectcode-with-dotsettings).

## Prerequisite
- `.sln` and `.csproj` files should be present in the source.

## GitHub Action Steps 
- .Net is installed.
- Resharper Global tools are installed.
- Code checkout.
- InspectCode is called.
- Check for any errors.
- Logfile is uploaded as an Artifact. 

## Issues
- There are unity specific errors like `Cannot resolve symbol 'UnityEngine’`, this is due to Unity not being installed on Github hosted machine for the action.

## Mitigation
- A self hosted runner could be used. 
- On this server dotnet, resharper global tools, and unity can be installed. 
- This will remove the steps for installing dotnet and resharper.
- It will also remove unity errors.