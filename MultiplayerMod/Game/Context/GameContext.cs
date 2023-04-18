﻿namespace MultiplayerMod.Game.Context;

public class GameContext {

    public ToolMenu ToolMenu { get; set; }
    public BuildMenu BuildMenu { get; set; }
    public PlanScreen PlanScreen { get; set; }
    public DebugPaintElementScreen DebugPaintElementScreen { get; set; }

    public static GameContext GetCurrent() => new() {
        ToolMenu = ToolMenu.Instance,
        BuildMenu = BuildMenu.Instance,
        PlanScreen = PlanScreen.Instance,
        DebugPaintElementScreen = DebugPaintElementScreen.Instance
    };

    public void Restore() {
        ToolMenu.Instance = ToolMenu;
        BuildMenu.Instance = BuildMenu;
        PlanScreen.Instance = PlanScreen;
        DebugPaintElementScreen.Instance = DebugPaintElementScreen;
    }

}
