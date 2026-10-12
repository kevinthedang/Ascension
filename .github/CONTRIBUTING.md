## Getting Started with Sprites
I just use [Aseprite](https://www.aseprite.org/) for now

Great for learning spriting!

## Getting Started

Refer to the following guides:
* [Basic tModLoader Modding Guide](https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide)
* [Easy Guides for modding](https://github.com/tModLoader/tModLoader/wiki#easy-guides)

For development seems like we need the following:

1. An IDE (integrated development environment) -> VSCode, Visual Studio (Windows), Rider (Jetbrains)
2. C# experience
3. .Net 8.0

## Install .NET 8.0
### Windows
1. Download the executable from [dotnet.microsoft.com](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

2. Download the x86 version from the Windows section and run it.

### Linux (Debian)
Run the following commands:

Download the install script
```bash
curl -L https://dot.net/v1/dotnet-install.sh -o dotnet-install.sh
```

Provide execute permissions:
```bash
chmod +x ./dotnet-install.sh
```

> [!NOTE]
> This script is from microsoft but always make sure you double check scripts before running them! There is also a [manaul](https://learn.microsoft.com/en-us/dotnet/core/install/linux-scripted-manual#manual-install) way of install if that is more your style

Run the install script for .NET 8.0 latest:
```bash
./dotnet-install.sh --channel 8.0
```

Verify install:
```bash
~/.dotnet/dotnet --version
```

As of 10/12/2026 it was `8.0.425`
