# Zumbi Blocks 2 Plugin Template (Steam)

A modding template for **Zumbi Blocks 2**, powered by [BepInEx](https://github.com/BepInEx/BepInEx).

## Features

This template is designed to work out-of-the-box: that means you can click `Build` and it'll just work.

- Designed for the [Steam](https://store.steampowered.com/app/1941780/Zumbi_Blocks_2_Open_Alpha/) version
- Batteries-included: already configured for modding
- Customizable with feature toggles
- Validates game and mod loader installation
- Automatically installs your plugins
- Copies assets to your mod folder
- Embeds resources if needed
- Supports [ZumbiBlocks2.GameLibs](https://www.nuget.org/packages/ZumbiBlocks2.GameLibs/) with fallback to game assembly
- Optional support for MMHOOK

## Requirements

- [Zumbi Blocks 2](https://store.steampowered.com/app/1941780/Zumbi_Blocks_2_Open_Alpha/)
- [BepInEx 5](https://github.com/BepInEx/BepInEx/releases)
- [.NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) or [newer](https://dotnet.microsoft.com/en-us/download)
- [.NET Framework 4.6.2](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net462) or [newer](https://dotnet.microsoft.com/en-us/download/dotnet-framework)

> **Using [Visual Studio Community 2022](https://visualstudio.microsoft.com/vs/community/)?**
> 
> The **.NET Desktop Development** workload includes `.NET 8.0 SDK` and `.NET Framework 4.7.2`.  
> This means you do not need to install `.NET 6.0 SDK` or `.NET Framework 4.6.2`.

## Getting Started

This guide will help you get started with modding Zumbi Blocks 2 in just a few minutes.

### Installing BepInEx

Installing BepInEx is incredibly easy and won't take much time.

In your Steam client, right-click **Zumbi Blocks 2**, hover over `Manage`, then click on `Browse local files`.  
This will open the game folder in Windows Explorer. If it didn't appear on screen, click on the Explorer icon in the taskbar or tab over to it.

Next, extract the BepInEx ZIP file. This will result in three files and one folder: `changelog.txt`, `doorstop_config.ini`, `winhttp.dll`, and a`BepInEx` folder.

Drag everything into the `Zumbi Blocks 2 Open Alpha` folder. The `BepInEx` folder should now be next to the `MonoBleedingEdge` and `ZumbiBlocks2_Data` folders.

Run the game--either from Steam or the `ZumbiBlocks2.exe` file--and wait for the game to load.  
**You're done!** BepInEx is now installed. You may now close the game.

For a more comprehensive guide on [installing BepInEx](https://docs.bepinex.dev/articles/user_guide/installation/index.html), as well as several articles on [using it](https://docs.bepinex.dev/articles/user_guide/configuration.html), please refer to the [official BepInEx documentation site](https://docs.bepinex.dev/).

### Creating your repository

This repository is marked as a template, making it incredibly easy to clone for your own projects.

1. [Create a new repository based on this template](https://github.com/Zumbi-Blocks-2-Modding/ZumbiBlocks2.PluginTemplate.Steam/generate).
2. Using your IDE, CLI, or Git-oriented desktop program, [clone your repository](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository).
3. Open your local repository with your IDE. If prompted to trust the project, accept.

You're now free to customize the project!  
The Steam template takes care of all references for you, so you can focus on what really matters.

### Customizing your project

Obviously, you're not going to release a mod named `ExamplePlugin`, so let's change its name.

1. Open the project settings and rename `ExamplePlugin` to your new mod's name.
2. In `ExamplePlugin.cs`, fill out the plugin fields with your own details.
3. Change the log message to one of your own.
4. [Add a license](https://choosealicense.com/)! This is very important in the open source community.
5. **(Optional)** If your Steam library is not on the C: drive, open the `.csproj.user` file, and enter your Steam library location.

When done customizing your plugin base, click on `Build` in your IDE.  
Your plugin will automatically be installed. Open the game and test it out!

### Assets and Resources

If your plugin has assets, create a folder named `assets` and it'll automatically be copied over to your mod folder when building your project.

Likewise, if you have embedded resources, create a folder named `resources` and those will automatically be embedded when building.

---

## Community

If you ever get stuck or need assistance getting started, feel free to join the official [Zumbi Blocks 2 Discord Server](https://discord.gg/eCWaHR9).  
There's a modding channel where you can share and discuss everything related to mods.
