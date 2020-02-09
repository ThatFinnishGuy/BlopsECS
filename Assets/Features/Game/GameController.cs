/*
 *
 * The GameController is responsible for creating and managing all systems.
 *
 ** Brief summary of ECS **
 * Entities: 
 * They represent the individual "things" in you game or program. An entity has neither behavior nor data; instead,
 * it identifies which pieces of data belong together. An entity is essentially an ID.
 * 
 * Components:
 * The data associated with your entities, but organized by the data itself rather than by entity.
 * This difference in organization is one of the key differences between an object-oriented and a data-oriented design.
 *
 * Systems:
 * The logic that transforms the component data from its current state to its next state— for example,
 * a system might update the positions of all moving entities by their velocity times the time interval since the
 * previous frame.
 *  
 */
using System;
using Entitas;

public class GameController
{
    readonly Systems _systems;

    public GameController(Contexts contexts, IGameConfig gameConfig)
    {
        //seed random
        var random = new Random(DateTime.UtcNow.Millisecond); 
        UnityEngine.Random.InitState(random.Next());
        Rand.game = new Rand(random.Next());

        if (!contexts.config.hasGameConfig)
            contexts.config.SetGameConfig(gameConfig);

        //The heart of the program!
        // All logic is contained in all the sub systems of GameSystems
        _systems = new GameSystems(contexts);
    }
    
    public void Initialize()
    {
        // This calls Initialize() on all sub systems
        _systems.Initialize();
    }

    public void Execute()
    {
        // This calls Execute() and Cleanup() on all sub systems
        _systems.Execute();
        _systems.Cleanup();
    }
}

