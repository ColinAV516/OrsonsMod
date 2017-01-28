using Terraria.ModLoader;

namespace OrsonsMod
{
	class OrsonsMod : Mod
	{
		public OrsonsMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
