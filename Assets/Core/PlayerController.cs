using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerControllerState { BEFORE_GAME = 0, DICE = 1, CHOICE_PAWN = 2, WAIT = 3, AFTER_GAME = 4 };

public enum Team { GREEN = 0, BLUE = 1, YELLOW = 2, RED = 3 };

[System.Serializable]
public struct Player
{
    public PlayerController Controller;
    public Team Team;
}

public class PlayerController : MonoBehaviour
{
    private PlayerControllerState _state;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
