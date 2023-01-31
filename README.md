# Ginn Fix Mod

This mod seeks to correct an issue with the CVR Game, where currently the username `Gin` is shown with 2 `n`, so it ends
up being `Ginn`.

The fix is really simple, you just need to remove 1 `n` from `Ginn`. This will only fix it for people using the mod, and
only on the nameplate unfortunately.

Until this change is implemented into the game, I will have this mod up so people can have it hot-fixed meanwhile as 
this might be a huge issues for some people.

### Note
This is a joke, because `Ginn` wants the name `Gin` but it was taken by someone that is not active. If you install this
you will see `Ginn`'s nameplate with the `Gin` name.

---

## Building

In order to build this project follow the instructions (thanks [@Daky](https://github.com/dakyneko)):

- (1) Install NStrip.exe from https://github.com/BepInEx/NStrip into this directory (or into your PATH). This tools
  converts all assembly symbols to public ones. Make life easy!
- (2) Create a new Windows environment variable `CVRPATH` which should point to your game path (folder
  where `ChilloutVR.exe` resides). In Windows, look for Settings > Advanced system settings > Advanced > Environment
  Variables, add a new one there, it should point to something
  like `C:\Program Files (x86)\Steam\steamapps\common\ChilloutVR` or similar.
- (3) Run `copy_and_nstrip_dll.bat` (cmd prompt only) or `copy_and_nstrip_dll.ps1` (Powershell only) this will copy the
game + MelonLoader .dll into this project and run NStrip.exe to make them public (easier developers).  


---

# Disclosure  

> ---
> ⚠️ **Notice!**  
>
> This mod's developer(s) and the mod itself, along with the respective mod loaders, have no affiliation with ABI!
>
> ---
