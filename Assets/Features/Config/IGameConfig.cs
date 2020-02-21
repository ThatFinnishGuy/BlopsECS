﻿using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Config, Unique, ComponentName("GameConfig")]
public interface IGameConfig
{
    Vector2Int boardSize { get; }
    Vector2Int shooterPosition { get; }
    uint rowSpawnTimer { get; }
}
