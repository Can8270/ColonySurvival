﻿using Pipliz.APIProvider.Science;
using Server.Science;

namespace Pipliz.BaseResearch.Implementations
{
	[AutoLoadedResearchable]
	public class BronzeAnvil : BaseResearchable
	{
		public BronzeAnvil ()
		{
			key = "pipliz.baseresearch.bronzeanvil";
			icon = "gamedata/textures/icons/bronzeanvil.png";
			iterationCount = 3;
			AddIterationRequirement("bronzeingot");
			AddIterationRequirement("coppertools");
			AddIterationRequirement("coppernails");
		}

		public override void OnResearchComplete (ScienceManagerPlayer manager)
		{
			RecipeStorage.GetPlayerStorage(manager.Player).SetRecipeAvailability("pipliz.crafter.bronzeanvil", true, "pipliz.crafter");
			RecipePlayer.UnlockOptionalRecipe(manager.Player, "pipliz.player.bronzeanvil");
		}
	}
}
