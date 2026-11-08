# LBoL Logs last updated

| Mod | Date |
| --- | --- |
| AyaPlayerUnit<br />FlandrePlayerUnit | 2026/11/07 |
| lvalonexrumia | 2025/09/06 |
| Momiji | 2024/12/10 |
| PatchouliMod | 2024/10/28 |
| ReimuUnifierMod | 2025/12/28 |
| Sanae_Kochiya | 2024/10/21 |
| Utsuho | 2024/10/18 |
| YoumuMod | 2024/10/15 |


# ProjectGuid

```
3D604077-200F-4D7A-A07C-FE63BEC49776
```


# Steps

| # | Workspace | Tool | Output | Remark |
| - | - | - | - | - |
| 1 | local | dnSpy | mods/{id}/src/dll | unpack dll with `ProjectGuid` |
| 2 | local | Mod files | mods/{id}/src/ | raw files except `.dll` |
| 3 | mods | ExportModImgs | mods/{id}/configs<br />mods/{id}/images<br />mods/{id}/locales | ExportModImgs/Exporters/Exporter.cs<br />specify `id` and `GUID` |
| 4 | mods | configs/PlayerUnit | mods | `docs/configs/{ver}/mods.json` |
| 5 | mods | README | mods/README.md | upsert last updated |
||||||
| 6 | avif | avif | mods/{id}/images | units: `LoadModelOptions`<br />boss: `AddBossNodeIcon` |
| 7 | parser | configs parser | docs/configs | also check and `.cs` for `FriendCostInfo` |
| 8 | parser | locales parser | docs/locales | check hardcoded placeholder and add to configs<br />fix plurals, etc. |
| 9 | lbol-logs-dev | css | index.css | `.c-character-short-name--{id}` |
