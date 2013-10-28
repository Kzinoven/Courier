using UnityEngine;
using System.Collections;

public static class GameEventManager {

    //Defines generic event classes and their trigger functions.
    //Not yet implemented.
    public delegate void GameEvent();

    //Each type of event will go here and be enumerated/processed by GameEventManager trigger subprocesses.
    public static event GameEvent
        GameStart,
        GameOver;

    public static void TriggerGameStart()
    {
        //Start/restart the game if it isn't already started
        if (GameStart != null)
            GameStart();
    }

    public static void TriggerGameOver()
    {
        //End the game if it hasn't already ended
        if (GameOver != null)
            GameOver();
    }
}
