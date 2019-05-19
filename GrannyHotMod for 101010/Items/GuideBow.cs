using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace GrannyHotMod.Items
{
	public class Streamliner : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("vl antisocial");
		}

		public override void SetDefaults() {
			item.damage = 20;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 1;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true; 
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 4;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("ExampleItem"), 10);
			recipe.AddTile(mod.TileType.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}