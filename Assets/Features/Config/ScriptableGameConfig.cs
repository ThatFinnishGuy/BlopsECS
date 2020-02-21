using UnityEngine;

[CreateAssetMenu(menuName = "Blops/Game Config")]
public class ScriptableGameConfig : ScriptableObject, IGameConfig
{
    [SerializeField] Vector2Int _boardSize; public Vector2Int boardSize => _boardSize;
    [SerializeField] Vector2Int _shooterPosition; public Vector2Int shooterPosition => _shooterPosition;
    [SerializeField] uint _rowSpawnTimer; public uint rowSpawnTimer => _rowSpawnTimer;
}