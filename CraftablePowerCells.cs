using Terraria.ID;
using Terraria.ModLoader;

namespace CraftablePowerCells
{
	public class CraftablePowerCells : Mod
	{
		public CraftablePowerCells()
		{
		}

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LunarTabletFragment, 2);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.LihzahrdPowerCell, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LihzahrdPowerCell, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.LunarTabletFragment, 2);
            recipe.AddRecipe();
        }
    }
}