using System.Collections.Generic;
using Terraria;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.WorldBuilding;

namespace Ascension.Systems
{
    public class BaseRoguelikeWorldSystem : ModSystem
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref double totalWeight)
        {
            // Reset the world state when a new world is loaded
            tasks.Clear();

            tasks.Add(new PassLegacy("Creating you Ascension world", (progress, _) =>
            {
                progress.Message = "Moving Spawn Point...";
                Main.spawnTileX = Main.maxTilesX / 2;
                Main.spawnTileY = Main.maxTilesY / 2;

                progress.Message = "Creating Platform...";
                int platformWidth = 50;
                int startX = Main.spawnTileX - (platformWidth / 2);
                int platformY = Main.spawnTileY + 2; // slightly below the spawn point

                for (int x = startX; x < startX + platformWidth; x++)
                {
                    WorldGen.PlaceTile(x, platformY, TileID.Stone, mute: true, forced: true);
                }

                // Spawn 2 Torches
                WorldGen.PlaceTile(Main.spawnTileX + 2, platformY - 1, TileID.Torches, mute: true, forced: true, style: 0);
                WorldGen.PlaceTile(Main.spawnTileX - 2, platformY - 1, TileID.Torches, mute: true, forced: true, style: 0);
            }));
        }
    }
}