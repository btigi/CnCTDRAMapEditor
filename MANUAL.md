﻿# Mobius Map Editor - Manual

## Installation

**DO NOT unpack this in the C&C Remastered Collection's install folder.** It is absolutely unnecessary to overwrite any files of the installed game.

Simply unpack the editor into a new folder on your disk somewhere. On first startup, it will automatically try to detect the folder in which the game is installed, and if it can't find it, it will show a dialog asking you to locate it. Note that this autodetect only works on Steam installations of the game.

If the C&C Remastered Collection is not installed on your PC, you can use the "Continue with classic graphics" button on the dialog to start the editor without the Remastered graphics. To suppress the "Select game path" dialog and instead automatically start with classic graphics, you can edit the config file in a text editor and enable the option to always use classic graphics. (See the "Configuration" section below.)

---

## Usage

The creators of the map editor have chosen to build a manual into the editor, but it might not be immediately obvious. Look at the bottom bar, and it will tell you for the currently selected editing type what your mouse buttons will do, and which modifier keys will change to different editing modes. Once you hold down such a key, the bottom bar text will change, further explaining what your mouse buttons will do in this specific mode.

### Basics

In general, holding down \[Shift\] will activate placement mode, and in that mode, left clicking will place an object, and right clicking on an object will remove it. Outside placement mode, double-clicking an object will open its properties, holding down the left mouse button on an object will allow dragging it around, and right-clicking an object will make it the currently selected object in the tool window, including all its specifically-set properties (such as House, Strength, Trigger…). These controls may vary a bit; not all object types can be dragged, not all object types have properties to edit, and for Resources, the placement mode is always active.

As for basic navigation, the controls are fairly straightforward: the scroll wheel and the \[+\] and \[-\] keys allow zooming in and out, arrow keys will pan around the map, and holding down either the middle mouse button or the space bar allows quickly drag-panning around the map. Some special shortcuts for zooming can be found in the "View" → "Zoom" menu; the \[\*\] key will reset the zoom to the full map, and \[Ctrl\]+\[D\] will zoom the editor to the map's bounds area plus one extra cell border around it. Note that you can zoom out farther than the full map; this was done to allow placing map template pieces partially outside the map from the top and left sides of the map.

Specific options about the map and the scripting elements can be found in the "Settings" menu:

* "Map" will allow you to set the map's name, indicate whether it is a single player mission, set videos for mission startup, win, and lose, and configure the player's House (for singleplayer) and set alliances and other settings for all the Houses used on the map.
* "Teamtypes" will allow you to define teams that can be used in the map's scripting, or that will simply be created randomly as attack teams by the AI Houses.
* "Triggers" will allow you to make scripts that execute on the map. Note that scripting is mostly a singleplayer thing, and is severely limited in multiplayer, especially in Tiberian Dawn.

The triggers dialog contains a "Check" button that will check if any configurations in the triggers might not work, or might even cause game crashes. For TD, these checks are based on [the TD triggers overview guide I wrote on Steam](https://steamcommunity.com/sharedfiles/filedetails/?id=2824756756). Note that this is not a scripting guide; it is an overview of what each trigger event and action will accept as inputs, and produce as output, highlighting potential issues and some workarounds.

### Hotkeys

You can switch between the different editing modes using the six first letters on the top two rows on your keyboard; Q-W-E-R-T-Y and A-S-D-F-G-H on classic a US qwerty keyboard. Note that these keys are interpreted positionally on the keyboard, meaning that they will work in the intended logical way on different-region keyboard, like the German 'qwertz' and French 'azerty'.

As is standard in most programs, Undo and Redo are linked to \[Ctrl\]+\[Z\] and \[Ctrl\]+\[Y\] respectively. Note that the Undo/Redo history includes edits to Triggers and Teamtypes, though since those are generally large operations, a warning will be shown before an Undo/Redo on those is applied. Some actions in the Map settings, such as enabling or disabling the *Aftermath* expansion units, or changing INI Rules, are deemed too drastic to support in the Undo/Redo system, and will clear the current edit history.

Besides those, \[PageUp\] and \[PageDown\] have been universally implemented to let you switch to the previous / next item on the current editing tool's selection list, with \[Home\] and \[End\] going to the start and end of the list. This also works for increasing/decreasing the resource placement size in Resources mode. Holding down the \[Ctrl\] key and using the mouse scroll wheel has the same previous / next item function.

Some editing modes will have their own specific shortcuts; in Map mode, holding down the \[Ctrl\] key will allow modifying the map border, and \[Ctrl\]+\[Alt\] allows using the flood fill feature. In Waypoints mode, pressing \[Shift\] plus the starting letter of a special waypoint will act as shortcut for quickly selecting it. In Waypoints and Celltriggers modes, the \[Enter\] key acts as shortcut for the "Jump To" function. All such mode-dependent shortcuts will be indicated in the bottom bar along with the mouse function modifiers.

Additionally, the "Extra indicators" you can find under the "View" menu all have an F-key assigned to them, to quickly toggle them. F1 for the map symmetry lines, F2 for the map grid, F3 for showing the map terrain type of each cell, F4 for indicating cells occupied by placed down objects, F5 to show the reveal radius around any waypoints that are configured to reveal terrain through map scripting, and F6 for showing the radiuses for special abilities, such as the gap generators and radar jammers in Red Alert. A lot of these extra indicators will pop up automatically under certain conditions, such as placing/dragging the affected objects, or simply being in the relevant editing mode. The menu toggles will simply keep them permanently enabled, even outside these contexts.

Note that these hotkeys only work when the main window is selected; if you click on the tool window to select it, all keys will work as expected inside the selected controls. Also note that the tool window will automatically deselect when the mouse is moved over the main editor area, to avoid having to click the main window to activate its normal functioning.

### Sole Survivor and Megamaps

Some of you might remember Sole Survivor; the rather obscure death match arena spinoff of Tiberian Dawn. It's a game in which you control a single unit, collect crates to upgrade that unit, and kill your enemies. The game engine is a trimmed version of the Tiberian Dawn one with the base building and harvesting parts disabled, but it has one interesting upgrade that the original game didn't have: its battle arena maps are 128x128; the same size as Red Alert's maps.

Some mod makers found that an interesting feature, since it means there is an official Tiberian Dawn megamap format, and so, some mods on the C&C Remastered workshop, like [CFE Patch Redux](https://steamcommunity.com/sharedfiles/filedetails/?id=2239875646), and [john_drak's updated branch of it](https://steamcommunity.com/sharedfiles/filedetails/?id=3002363531), support this format. The [Vanilla Conquer](https://github.com/TheAssemblyArmada/Vanilla-Conquer) project, which reconstructed the original Tiberian Dawn source code from the remaster code, also supports it. And so, I decided to support it in this editor too, to make larger maps and missions that are playable on these.

In recent years, quite some progress has been made in getting Sole Survivor's server-side infrastructure running again, and so, the game might soon actually be playable again. So for that reason, actual support for Sole Survivor was added as well, including its own special waypoints and map options.

### The "New from image" function

The editor contains a function to create a new map starting from an image, also usable with the drag-and-drop feature. This is not some magical conversion tool, however; it needs to be used in a very specific way.

The function is meant to allow map makers to plan out the layout of their map in an image editor, with more tools available in terms of symmetry, copy-pasting, drawing straight lines, drawing curves, etc. Each pixel on the image represents one cell, so the image should be the size of a full map; 64x64 for Tiberian Dawn, and 128x128 for Red Alert and Sole Survivor (and Tiberian Dawn megamaps). If the image is smaller, it will be expanded with black. If it is larger, only the upper left corner will be used.

After selecting the map type and the image, a dialog will be shown where colors can be mapped to a specific tileset icon type. This function only handles distinct colors, so avoid using tools that use smooth color transitions; the final image should probably only contain some 3-10 distinct colors. Note that the alpha factor of the colors will be ignored.

The result of this is obviously not an immediately usable map. It will produce a rough layout which will then need to be overlayed with actual cliffs, rivers and shores to turn it into an actual map. For Red Alert Interior theater, you can probably do a lot more preparation work in the image editor; all corridor sizes can be laid out exactly, and you can even pre-place areas where wall shadows will come, so they can be taken care of with a few quick flood fill commands in the editor.

### Randomizable tiles

In Red Alert's Interior theater, the editor unlocks access to an unused game feature, namely, the ability to use the alternate versions that exist in most of the Interior theater's 1x1 tile types. None of the original game maps ever use these alternates, but both the original game and the remaster can perfectly show them if they are present in maps.

On the preview window, such tiles will be indicated with a light blue grid drawn over them. When you have such a tile type selected, placing down a tile will randomly place one of the available tiles. Of course, just as with any other tile, you can right-click on the map (or left-click on the preview window) to select a specific tile to place, which will disable the randomizing feature. Right-clicking in the preview window will remove the specifically-selected cell and re-enable the randomization.

The randomizability feature is also applied the other way around: to remove clutter, three ranges of equivalent 1x1 wall tiles were packed together into three randomizable tileset groups. These are "wallgroup1", "wallgroup2" and "wallgroup3". If you place down any of these walls on the map and hover your mouse over the tile, you will see the actual tiles are identified as wall0002 to wall0022.

The Tools menu has a specific "Re-randomize tiles" option to automatically apply this randomization to existing maps. This will include randomizing the walls. Note that even though the specific corner pieces in wall0023 to wall0049 are pretty much equivalent to combinations of these randomizable wall tiles, they are not affected by this operation.

### The "Publish" function

The "Publish" option in the menu will allow you to upload your map to the Steam Workshop. It only works if you have the C&C Remastered game installed through Steam.

If the editor is running in Classic mode (see below), the editor will never ask for your C&C Remaster game folder, however, if it hasn't already been set, it *will* attempt to auto-detect the Steam game folder, and if it succeeds, the Publish function will be available as usual.

If, for some reason, the Steam game folder detection fails, you can get the prompt to manually select your game folder by disabling classic mode and restarting the editor.

### Map land types and object occupancy.

Land types indicate which cells of the map tilesets are passable to different types of units, and which cells can be built on. The option to show them as hashed pattern can be enabled under "View" → "Extra indicators" → "Map land types", or simply by pressing F3. Once enabled, the hashing will be shown both on the map and on the map tile placement preview.

The colors for the different land types can be configured in the config file; see "Colors and transparency" below. These land types exist in the games:

* Clear: Passable for land units, and can be built on. Normally not shown, except in placement previews, where its default color is white.
* Beach: Passable, but can't be built on. Its default color is yellow.
* Rock: Land impassable for all units. Its default color is red.
* Road: Passable for land units, and can be built on. Units move faster on roads. (Red Alert only)
* Rough: Passable, but can't be built on. Its default color is grayish purple. (Red Alert only)
* Water: Passable for ships only. Its default color is light blue.
* River: Water impassable for all units. Its default color is dark blue. (Red Alert only)

The "Map land types" option only evaluates the raw map tiles, though, and does not account for the things placed on top of them. For that, there is a separate option, namely "View" → "Extra indicators" → "Occupied by objects". This will show a hashed pattern over all occupied cells, configured as green by default. On cells containing infantry, the hashing will be light green if the five infantry sub-positions are not all filled up.

---

## Local settings storage

The editor has two kinds of settings; global settings used on every run, and modifiable settings that can get changed during the program run. The global settings are those detailed in the "Configuration" section below. The modifiable settings include things like the game path and window positions, and will automatically get stored under the user-folder. If, for any reason, you would want to clear these settings and start the editor with a clean slate, simply open the File Explorer, paste the following into the address bar and press \[Enter\]:

**\%localappdata\%\\Nyerguds\\**

This should make you end up in the "AppData\\Local\\Nyerguds" folder under your Windows user folder. Removing this folder (or, at least, all folders in there starting with "CnCTDRAMapEditor") will clear all of the editor's user settings.

## Configuration

The file "CnCTDRAMapEditor.exe.config" contains settings to customise the editor. The file is in xml format, meaning it can be opened in any text editor. This section details what its settings do.

### Using classic files:

* **UseClassicFiles**: Disabled by default, so the editor can ask you for your C&C Remastered game folder, but if you don't own the Remaster, or prefer the classic graphics, simply set this to "True".
* **ClassicPathTD** / **ClassicPathRA** / **ClassicPathSS**: Path to load the classic files from for each of the game types when running in Classic Files mode. If the directory entered in this cannot be found, this reverts to predefined subfolders under the editor's location; "Classic\\TD" for Tiberian Dawn and Sole Survivor, and "Classic\\RA" for Red Alert. If these folders are not found either, the editor will check if it is ran from the C&C Remastered folder, by checking for the existence of the classic folders inside the CNCDATA folder. If the data is not present at the given location, the editor will refuse to launch in classic mode.
* **ClassicNoRemasterLogic**: Defaults to True. When enabled, using classic mode will make it stop doing remaster-specific checks (such as briefing screen constraints in RA) or use the Remaster's specific folders under Documents.
* **ClassicProducesNoMetaFiles**: Defaults to False. Suppresses the creation of xml and thumbnail files for multiplayer maps when in Classic Files mode.
* **ClassicEncodesNameAsCp437**: Defaults to True. When in classic mode, special characters in the map name are saved as DOS-437 encoding, so the classic games can read and display them correctly. Note that this never applies to uploaded workshop maps.

Using classic files will not only use the classic graphics, but will also load the classic game text from the respective game's 'CONQUER.ENG' file, and the Red Alert house colors from 'PALETTE.CPS'.

The default "Classic\\TD" and "Classic\\RA" folders are supplied along with the editor, so it is immediately usable in classic mode. The contents of these folders were taken from the official freeware releases of the games, supplemented with some files from the Red Alert expansion packs. For the exact expected contents of the folders, see the "Classic files listing" section below.

The extra theaters available for Tiberian Dawn and Red Alert in the upgraded community releases of the classic games are supported if their mix files are found in the configured folders. To achieve this, you can either copy the theater .mix archives from the classic install folder into into the classic folder provided with the editor (see "Classic files listing" section below for the exact names), or point the **ClassicPathTD** / **ClassicPathRA** folder to your own classic game install folder.

Note that for Red Alert, the editor uses the DOS versions of the infantry sprites, and the community version of Red Alert does not contain those for the expansion pack infantry. To amend this, copy the "lores1.mix" file from "Classic\\RA\\" into the Red Alert game folder. This will not have any effect on the game itself; it only uses the contents of "hires1.mix".

### General editor options

* **LazyInitSteam**: Enabled by default. The link between the editor and Steam is normally initialised on startup, but that link prevents Steam from running the game while the editor is open. With this option, the link with Steam is only initialised at the moment the map publish function is opened, allowing map makers to more easily switch between the editor and the game to test their what they're making.
* **EditorLanguage**: This option can change the language the editor loads for the remastered game text to name the objects in the editor by specifying a culture code in a format such as "EN-US". This only works for languages that are supported by the C&C Remaster as in-game language. When set to "Auto", it will attempt to use the system language, or the nearest supported one that matches it. To force the default English language, you can leave the setting empty, or use "Default" or "None". The supported languages of the game are: EN-US, DE-DE, ES-ES, FR-FR, KO-KR, PL-PL, RU-RU, ZH-CN, ZH-TW.
* **CheckUpdatesOnStartup**: Enabled by default. Will make the editor notify users if a new version is available.
* **EnableDpiAwareness**: Disabled by default. On some machines with high dpi monitors, people might have odd issues where the positioning of the indicators on the map doesn't correctly match the map tiles. If this happens, enabling this option might fix the problem.

### Mods:

* **ModsToLoadTD** / **ModsToLoadRA** / **ModsToLoadSS**: semicolon (or comma) separated list of mod entries for each supported game.

These refer to mods in the format defined by the Command & Conquer Remastered Collection. A mod entry can either be a Steam workshop ID, or a folder name. Steam workshop IDs are looked up in the game's downloaded Workshop items. Folder names will initially be looked up in the mods folder of the respective game in the CnCRemastered\\mods\\ folder under your Documents folder, but if nothing is found there, the loading system will also check the Steam workshop files for a matching mod. Sole Survivor will use Tiberian Dawn mods. Note that mods can only apply graphical changes from the tilesets and house colors xml files; the editor can't read any data from compiled dll files. This mods system is mostly meant to apply graphical fixes to the editor.

The **ModsToLoadTD** and **ModsToLoadSS** settings will have the `GraphicsFixesTD` mod set by default, to complete the incomplete TD Remastered graphics set, meaning the mod will automatically be loaded if found. Similarly, the **ModsToLoadRA** setting will have the `GraphicsFixesRA` mod set. Note that the editor has no way to check whether mods are enabled in the Remastered Collection games, so that makes no difference.

You can find these mods on the Steam workshop ([GraphicsFixesTD](https://steamcommunity.com/sharedfiles/filedetails/?id=2844969675), [GraphicsFixesRA](https://steamcommunity.com/sharedfiles/filedetails/?id=2978875641)) and on ModDB ([GraphicsFixesTD](https://www.moddb.com/games/command-conquer-remastered/addons/graphicsfixestd), [GraphicsFixesRA](https://www.moddb.com/games/cc-red-alert-remastered/addons/graphicsfixesra)).

In classic graphics mode, the editor can still use mods, if they contain classic files in a "ccdata" folder. The 'GraphicsFixesRA' mod has such a classic component, to fix the classic graphics of Einstein and the ant buildings.

### Mix content analysis:

Starting from v1.6.0.0, the editor has the ability to open the original games' .mix archives to open the missions inside it. However, the names of the files inside those archives are only stored as hashed numeric values created with a one-way hashing algorithm. This means that, to identify these files, lists of all the original file names are needed. The system to generate these names and their hash values is controlled by a set of ini files, of which the main definitions file is configured in the settings:

* **MixContentInfoFile**: Contains the definitions of the supported games for which mix file content analysis can be done, and any additional files to be loaded to get all information for each game. By default, this is set to "Classic\mixcontent.ini".

### Defaults:

* **DefaultBoundsObstructFill**: Default for the option "Tools" → "Options" → "Flood fill is obstructed by map bounds".  When enabled, and filling map tiles with \[Ctrl\]+\[Shift\]+\[Click\], the map boundary acts as border blocking the fill spread. This applies both inside and outside the border.
* **DefaultTileDragProtect**: Default for the option "Tools" → "Options" → "Drag-place map tiles without smearing". When placing tiles in map mode, and dragging around the mouse, this option will make sure a new tileset block is only placed after fully leaving the previously-placed blocks inside that one mouse action.
* **DefaultTileDragRandomize**: Default for the option "Tools" → "Options" → "Randomize drag-placed map tiles". When placing a tile and holding down the mouse to drag more, this will make the subsequently placed tiles randomize between equivalents of the same size.
* **DefaultShowPlacementGrid**: Default for the option "Tools" → "Options" → "Show grid when placing / moving". This option enables showing the map grid when in placement mode (and/or holding down \[Shift\]) or when dragging a placed down object to a different location.
* **DefaultOutlineAllCrates**: Default for the option "Tools" → "Options" → "Crate outline indicators show on all crates". When enabled, the crate indicators from the "View" → "Indicators" → "Outlines on overlapped crates" option will show on all crates instead of just those underneath objects or graphics.
* **DefaultCratesOnTop**: Default for the option "Tools" → "Options" → "Show crates on top of other objects".
* **DefaultExportScale**: Default scaling multiplier for the size at which an exported image will be generated through "Tools" → "Export As Image". A negative values will set it to smooth scaling. Defaults to -0.5.
* **DefaultExportScaleClassic**: Default scaling multiplier for exporting images when using classic graphics. Defaults to 1.0.

### Editor fine tuning:

* **ZoomToBoundsOnLoad**: Defaults to True. When enabled, causes the editor to zoom in to the map bounds when loading an existing map.
* **RememberToolData**: Defaults to False. When enabled, the item selections and options on the tool windows will be remembered when opening a different map for the same game.
* **MapScale**: Scaling multiplier for the size at which assets are rendered on the map. Scaling down the rendered map size will make the UI more responsive. Negative values will enable smooth scaling, which gives nicer graphics but will make the UI noticeable _less_ responsive. Defaults to 0.5.
* **MapScaleClassic**: Scaling multiplier when using classic graphics. Defaults to 1.0.
* **PreviewScale**: Scaling multiplier for the size at which assets are rendered on the preview tools. Negative values will enable smooth scaling, but this usually doesn't look good on the upscaled preview graphics. Defaults to 1.
* **PreviewScaleClassic** Scaling multiplier for the preview tools when using classic graphics. Defaults to 5.333 (128/24), which upscales the objects to match the size they have in the Remastered graphics.
* **ObjectToolItemSizeMultiplier**: Floating-point multiplication factor for downsizing the item icons on the selection lists on the tool windows.
* **TemplateToolTextureSizeMultiplier**: Floating-point multiplication factor for the size of tiles shown on the Map tool. This scaling is somehow done relative to the screen size; not sure.
* **MaxMapTileTextureSize**: Maximum for the size of the tiles shown on the Map tool. Leave on 0 to disable.
* **UndoRedoStackSize**: The amount of undo/redo actions stored in memory. Defaults to 100.
* **MinimumClampSize**: Minimum size of the tool window that will automatically be forced to remain in the screen area. If set to 0,0, this will default to the size of the entire tool window.

### Colors and transparency:

General:

* **MapBackColor**: Background color for the map screen, as "R,G,B". This defaults to dark grey, so users can see the actual map outline on Red Alert Interior maps.
* **MapGridColor**: Color for drawing the map grid, as "A,R,G,B". This includes the alpha value, because the grid is semitransparent by default.

For the option "Extra indicators" → "Map terrain types":

* **HashColorLandClear**: The color for cells of the 'Clear' land type. Defaults to transparent white. Note that by default, this one's alpha component is set to 0, to suppress the indicators for this type. However, the actual color information will be used for placement previews of map templates, to indicate all cells in the shape.
* **HashColorLandBeach**: The color for cells of the 'Beach' land type. Defaults to yellow.
* **HashColorLandRock**: The color for cells of the 'Rock' land type. Defaults to dark red.
* **HashColorLandRoad**: The color for cells of the 'Road' land type. Defaults to brown.
* **HashColorLandWater**: The color for cells of the 'Water' land type. Defaults to pale blue.
* **HashColorLandRiver**: The color for cells of the 'River' land type. Defaults to blue.
* **HashColorLandRough**: The color for cells of the 'Rough' land type. Defaults to grayish purple.

For the option "Extra indicators" → "Occupied by objects":

* **HashColorTechnoPart**: The color for cells partially filled with map objects. This is only used for infantry.
* **HashColorTechnoFull**: The color for cells fully filled with map objects; either cells of buildings, terrain or units, or cells fully filled with five infantry units.

Outline colors for unowned objects:

An outline will be shown around objects that are partially or fully behind other objects (or always, in the case of the *DefaultOutlineAllCrates* settings). For owned objects, these outlines are given the color of their owners, but for unowned objects, they are editable here. An outline type can be disabled by adding an alpha factor of 0 in front of the R,G,B color values.

* **OutlineColorCrateWood**: The outline color for wooden crates. Defaults to brown.
* **OutlineColorCrateSteel**: The outline color for steel crates. Defaults to silver.
* **OutlineColorTerrain**: The outline color for Terrain objects (trees and rocks). Defaults to green.
* **OutlineColorSolidOverlay**: The outline color for impassable overlay. Pavement-type overlay is never outlined. Defaults to gray.
* **OutlineColorWall**: The outline color for walls. Defaults to purple. Note that this one is disabled by default (by setting its alpha to 0) because they are very common to have overlaps on, and it is rarely useful to show them.

Alpha transparency factors used:

* **PreviewAlpha**: The alpha factor used when previewing an object to place down on the map. Defaults to 0.5 (50%)
* **UnbuiltAlpha**: The alpha factor used for buildings that are placed on the map, but configured to only be built later by an AI. Defaults to 0.6 (60%)

These two factors will be multiplied for the placement preview of an unbuilt building, meaning, by default, the result will be 30% visible.

### Editor behavior tweaks:

These options are all enabled by default, but can be disabled if you wish. Use these at your own risk. Some of these (air units, craters, harvesting) are related to bugs in the games, so they could be disabled when making maps for a mod in which these issues are fixed.

* **ReportMissionDetection**: When detecting that a file is a classic single player mission file because it matches the classic "SCG01EA"-like name pattern and contains win and lose scripts, a note about it is shown in the mission load analysis. When disabled, this will only be shown if it is not the only remark in the list. Note that missions loaded from .mix archives will always behave as if this option is enabled.
* **EnforceObjectMaximums**: Don't allow saving a map if any of the object amounts exceed the normal internal maximums of the game. Can be disabled in case a mission is specifically meant to be played on a modded game that increases these limits.
* **Ignore106Scripting**: Don't support the extended scripting added by the C&C95 v1.06 patch. If this option is disabled, additional triggers named UUUU, VVVV and WWWW can also be destroyed with "Dstry Trig" actions.
* **ConvertRaObsoleteClear**: Automatically clear tiles with ID 255 on RA Temperate/Snow maps, or on Interior maps if more than 80% of the area outside the map bounds is filled with it, to fix the fact old versions of RA saved that as Clear terrain. This can be disabled to research changes on old maps.
* **BlockingBibs**: Bibs block the placement of other structures. Note that if you disable this, you should be careful not to block the build plan of rebuildable AI structures. Also, the games might have issues with walls overlaying building bibs.
* **DisableAirUnits**: Air unit reading from maps was a disabled feature in the original games. Even though the Remaster re-enabled this, it is buggy and unpredictable, so the editor disables air units by default. Air units put on maps will not appear on the specified cell; they will spawn in the air above it, will either fly off the map or find a nearby building of their House to land at, and (in TD) will usually leave behind an impassable cell on the map under the place where they spawned. Note that any "preplaced" Chinook helicopters that might appear in missions are actually flown in by scripts at the start of the mission.
* **ConvertCraters**: Any craters of the types CR2-CR6 placed in maps are bugged in the games, and revert to the smallest size of CR1. This filters them out and converts them to CR1 craters of the specified size, and removes the other crater types from the Smudge choices list.
* **DisableSquishMark**: The overlay SQUISH (a crushed corpse) exists in Tiberian Dawn, but is normally not usable because the logic to enable it in the game (by putting "Overrun=Pancake" in conquer.ini) is broken, messing up all non-wall overlay spawning. This option can be switched off to support builds of the game where this is fixed.
* **FilterTheaterObjects**: Filter out objects that don't belong in the current map's theater. This affects both map loading, and the items visible in the placement lists. Do not turn this off unless you really know what you're doing; having theater-illegal objects on maps may cause situations that crash the game.
* **WriteClassicBriefing**: In addition to the single-line "Text=" briefing used by the Remaster, also write classic-style briefings into the ini file as "1=", "2=", etc. lines split at human-readable length. This includes the C&C95 v1.06 line break system using ## characters at the end of a line. Any special characters in this are always written in DOS-437 text encoding.
* **ApplyHarvestBug**: The game has a bug where the final harvested stage of a cell yields nothing (or only 3/4th for RA gems). Assume this bug is unfixed when doing the resource calculations.
* **OverlayWallsOnly**: if this option is set to False, walls will show up in the Buildings list as well, from where they can be placed down as player-owned buildings. This allows selling them, but it is generally not advised since it bloats the ini file.
* **NoOwnedObjectsInSole**: Sole Survivor maps normally don't include placed down units, structures or infantry, so loading and saving them is disabled by default. But it seems some official maps do contain decorative civilian buildings, and old betas of the game could read those, so this option can be disabled for research purposes.
* **RestrictSoleLimits**: When analysing / saving Sole Survivor maps, use the original object amount limits of the game, rather than the Remaster's larger values.

### Graphical tweaks:

These don't affect any real behaviour, but change some graphics to look more correct in the editor:

* **FixClassicEinstein**: While the Win95 and remastered versions of Red Alert have Einstein's in-game sprite colored to match how he appears in the briefings, the DOS version (which the editor and the game use) looks identical to Dr. Mobius in Tiberian Dawn. This option makes the editor shuffle around some colors in the classic DOS sprite so it matches that same color scheme. Note that the **GraphicsFixesRA** mod also fixes this.
* **FixConcretePavement**: The connection logic of the "CONC" pavement in Tiberian Dawn is seriously bugged in-game. The editor contains a fixed logic, showing the concrete how it was intended to be, filling in side gaps with filler cells. However, be advised that this new logic does not match the actual game. For this reason, it is disabled by default.
* **DrawSoleTeleports**: On Sole Survivor maps, draw a black area with a blue border over the loaded ROAD graphics to emulate the look of the in-game teleporters.

### Map Size:

These set the size of the map (not the playable area) when creating a new map. Note that maps using non-default settings will not be playable:

* **MapMaxX**: The width of the map in tiles (default value is 64).
* **MapMaxY**: The height of the map in tiles (default value is 64).
* **MapMaxXMega**: The width of the map in tiles for a MegaMap (default value is 128).
* **MapMaxYMega**: The height of the map in tiles for a MegaMap (default value is 128).

## Classic files listing:

The following files can be read from the configured classic data folders, for running the editor in classic mode. They can also be loaded from mod folders. They will be loaded in the listed order, from any available sources. The basic rule in the game is that each file name can only be loaded once, and the first-loaded files have priority, so this also shows which archives can override the contents of which other archives.

Some files have special markings added to them. This is what they mean:

* (*) - Required, though they may not be visible inside the folder if they are embedded inside another archive.
* (1) - Add-ons (the sc*.mix archives). Anything matching the pattern will be read, but they obey the general game rule that each archive name is only read from one location.
* (2) - Archives that might be embedded inside the ''redalert.mix'' or ''main.mix'' archive. (RA only)
* (+) - Extra theaters added in the fan-patched community releases of the games.

Note that there is no support for running the editor for one specific game only, while not having the files for the other game(s) available. All data needs to be present to make the editor start up.

### Tiberian Dawn and Sole Survivor

These are read from the "Classic\\TD" subfolder by default. Note that the TD folder included in the editor has a minor added fix (sc-ptem.mix) which won't be present in a bare TD/Sole install folder.

* cclocal.mix (or local.mix) <sup>(*)</sup>
* sc*.mix <sup>(1)</sup>
* conquer.mix <sup>(*)</sup>
* desert.mix <sup>(*)</sup>
* temperat.mix <sup>(*)</sup>
* winter.mix <sup>(*)</sup>
* snow.mix <sup>(+)</sup>

### Red Alert

These are read from the "Classic\\RA" subfolder by default.

* expand2.mix
* expand.mix
* redalert.mix
* main.mix
* local.mix <sup>(*)</sup> <sup>(2)</sup>
* sc*.mix <sup>(1)</sup>
* general.mix <sup>(2)</sup>
* conquer.mix <sup>(*)</sup> <sup>(2)</sup>
* lores.mix <sup>(*)</sup> <sup>(2)</sup>
* lores1.mix <sup>(2)</sup>
* interior.mix <sup>(*)</sup> <sup>(2)</sup>
* snow.mix <sup>(*)</sup> <sup>(2)</sup>
* temperat.mix <sup>(*)</sup> <sup>(2)</sup>
* winter.mix <sup>(+)</sup>
* desert.mix <sup>(+)</sup>
* jungle.mix <sup>(+)</sup>
* barren.mix <sup>(+)</sup>
* cave.mix <sup>(+)</sup>

The ''hires.mix'' and ''hires1.mix'' archives are not used; like the Red Alert Remaster itself, the editor uses the DOS versions of the infantry.

The expansions data is not strictly required. If given a folder whithout those files, dummy graphics will be shown for the missing objects.
