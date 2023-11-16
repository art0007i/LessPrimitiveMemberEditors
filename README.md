# LessPrimitiveMemberEditors

A [ResoniteModLoader](https://github.com/resonite-modding-group/ResoniteModLoader) mod for [Resonite](https://resonite.com/) that allows `PrimitiveMemberEditor`s to parse more types than they usually would.
The usecases for this are very niche, so probably don't download this unless you need it for something specific.

Types without the mod:
- Boolean (bool)
- Decimal
- Byte
- Char
- Type
- UInt16 (ushort)
- UInt32 (uint)
- UInt64 (ulong)
- Single (float)
- Double
- String
- SByte
- Int16
- Int32
- Int64
- Uri

Types with the mod:
- All the previously listed types
- Every enum type
- bool2, 3, 4
- uint2, 3, 4
- ulong2, 3, 4
- int2, 3, 4
- long2, 3, 4
- float2, 3, 4
- double2, 3, 4
- float2x2, 3x3, 4x4
- double2x2, 3x3, 4x4
- floatQ
- doubleQ
- DateTime
- TimeSpan
- color
- colorX

## Installation
1. Install [ResoniteModLoader](https://github.com/resonite-modding-group/ResoniteModLoader).
1. Place [LessPrimitiveMemberEditors.dll](https://github.com/art0007i/LessPrimitiveMemberEditors/releases/latest/download/LessPrimitiveMemberEditors.dll) into your `rml_mods` folder. This folder should be at `C:\Program Files (x86)\Steam\steamapps\common\Resonite\rml_mods` for a default install. You can create it if it's missing, or if you launch the game once with ResoniteModLoader installed it will create the folder for you.
1. Start the game. If you want to verify that the mod is working you can check your Resonite logs.