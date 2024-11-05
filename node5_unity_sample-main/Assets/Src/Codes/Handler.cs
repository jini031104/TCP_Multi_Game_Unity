using System;
using UnityEngine;

public class Handler
{
    public static void InitalHandler(InitialResponse res)
    {
        try
        {
            GameManager.instance.GameStart();
            GameManager.instance.player.UpdatePositionFromServer(res.x, res.y);
        } catch(Exception e)
        {
            Debug.LogError($"Error InitalHandler: {e.Message}");
        }
    }
}