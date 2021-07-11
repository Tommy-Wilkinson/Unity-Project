using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerTest : MonoBehaviour
{
    //Keep a reference to a player prefab:
    GameObject playerPrefab;

    //And a reference to spawned players in the scene:
    List<GameObject> spawnedPlayers;

    //Bool if a game round is active or not:
    bool roundActive = false;

    public bool RoundActive
    {
        get { return roundActive; }
        set { roundActive = value; }
    }

    #region Spawn Methods
    //Need a method to spawn players: (overload with a given spawn point)
    public void SpawnPlayer()
    {
        GameObject player = GameObject.Instantiate(playerPrefab, 
            Vector3.zero, 
            Quaternion.identity);

        spawnedPlayers.Add(player);

    }

    public void SpawnPlayer(Vector3 location)
    {
        GameObject player = GameObject.Instantiate(playerPrefab,
            location,
            Quaternion.identity);

        spawnedPlayers.Add(player);

    }

    public void SpawnPlayer(Vector3 offset, Transform parent)
    {
        GameObject player = GameObject.Instantiate(playerPrefab,
            offset,
            Quaternion.identity,
            parent);

        spawnedPlayers.Add(player);

    }

    public void SpawnPlayer(Transform parent)
    {
        GameObject player = GameObject.Instantiate(playerPrefab, parent);

        spawnedPlayers.Add(player);

    }
    #endregion

    public void StartRound(int round_number)
    {
        
        //Possibly make a separate round manager class: call functions from that.


    }


}


