﻿public class DarkCityLevelInstance : LevelInstance
{
    protected override void Start()
    {
        base.Start();

        GameInstance.GameState.LocationController.Add(Location.Bedrock);
    }
}
