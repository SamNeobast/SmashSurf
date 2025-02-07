using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    [SerializeField] GameObject WallWood;
    [SerializeField] GameObject WallGold;
    [SerializeField] GameObject WallMetal;
    [SerializeField] float timer = 2;
    [SerializeField] List<GameObject> WallsAndCoins = new List<GameObject>();
    [SerializeField] Transform SpawnerRight;
    [SerializeField] Transform SpawnerLeft;
    [SerializeField] Transform SpawnerMiddle;
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            timer = 2;
            Debug.Log("SpawnBlock");
            ChoosingSpawn(SpawnerMiddle);
            ChoosingSpawn(SpawnerLeft);
            ChoosingSpawn(SpawnerRight);
            WallsAndCoins.Clear();
        }
    }

    private void ChoosingSpawn(Transform spawnPosition)
    {
        int randomNumber = Random.Range(0, 4);
        if (randomNumber == 0)
        {
            
        }
        if (randomNumber == 1)
        {
            if (WallsAndCoins.Contains(WallWood))
            {
                return;
            }
            Instantiate(WallWood, spawnPosition);
            WallsAndCoins.Add(WallWood);
        }
        if (randomNumber == 2)
        {
            if (WallsAndCoins.Contains(WallGold))
            {
                return;
            }
            Instantiate(WallGold, spawnPosition);
            WallsAndCoins.Add(WallGold);
        }
        if (randomNumber == 3)
        {
            if (WallsAndCoins.Contains(WallMetal))
            {
                return;
            }
            Instantiate(WallMetal, spawnPosition);
            WallsAndCoins.Add(WallMetal);
        }
    }
}
