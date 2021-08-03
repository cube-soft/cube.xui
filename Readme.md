Cube.Xui
====

[![NuGet](https://img.shields.io/nuget/v/Cube.Xui.svg)](https://www.nuget.org/packages/Cube.Xui/)
[![AppVeyor](https://ci.appveyor.com/api/projects/status/brama8ylsuk8xjer?svg=true)](https://ci.appveyor.com/project/clown/cube-xui)
[![Codecov](https://codecov.io/gh/cube-soft/Cube.Xui/branch/master/graph/badge.svg)](https://codecov.io/gh/cube-soft/Cube.Xui)

The Cube.Xui package has bindings, converters, commands, behaviors, and other components
to provide support the MVVM pattern in WPF applications.
The package is available for .NET Framework 3.5, 4.5, .NET Core 3.1, or later.
Note that basic functionality for the MVVM pattern is implemented in the [Cube.Core](https://github.com/cube-soft/Cube.Core), and the WinForms part is in the [Cube.Forms](https://github.com/cube-soft/Cube.Forms).

## Installation

You can install the library through the NuGet package.
Add a dependency in your project file using the following syntax:

    <ItemGroup>
        <PackageReference Include="Cube.Xui" Version="4.0.1" />
    </ItemGroup>

Or select it from the NuGet packages UI on Visual Studio.

## Dependencies

* [Cube.Core](https://github.com/cube-soft/Cube.Core)
* [Microsoft.Xaml.Behaviors.Wpf](https://www.nuget.org/packages/Microsoft.Xaml.Behaviors.Wpf/) (net45, netcoreapp3.1) or [Microsoft Expression Blend SDK](https://www.microsoft.com/ja-jp/download/details.aspx?id=10801) (net35)

## References

This project implements some features by referring to some of the code in the following projects.

* [MVVM Light Toolkit](https://github.com/lbugnion/mvvmlight)
* [Prism](https://github.com/PrismLibrary/Prism)

## Contributing

1. Fork [Cube.Xui](https://github.com/cube-soft/Cube.Xui/fork) repository.
2. Create a feature branch from the master, net45, or net50 branch (e.g. git checkout -b my-new-feature origin/master). Note that the master branch may refer to some pre-release NuGet packages. Try the [rake clobber](https://github.com/cube-soft/Cube.Xui/blob/master/Rakefile) command when build errors occur.
3. Commit your changes.
4. Rebase your local changes to the corresponding branch.
5. Run the dotnet test command or the Visual Studio (NUnit 3 test adapter) and confirm that it passes.
6. Create a new Pull Request.

## License

Copyright © 2010 [CubeSoft, Inc.](https://www.cube-soft.jp/)
The project is licensed under the [Apache 2.0](https://github.com/cube-soft/Cube.Xui/blob/master/License.txt).