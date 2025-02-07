using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    [SerializeField] GameObject HighWall;
    [SerializeField] GameObject ShortWall;
    [SerializeField] GameObject WallWithExit;
    [SerializeField] GameObject Coin;
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
            if (WallsAndCoins.Contains(Coin))
            {
                return;
            }
            Instantiate(Coin, spawnPosition);
            WallsAndCoins.Add(Coin);
        }
        if (randomNumber == 1)
        {
            if (WallsAndCoins.Contains(HighWall))
            {
                return;
            }
            Instantiate(HighWall, spawnPosition);
            WallsAndCoins.Add(HighWall);
        }
        if (randomNumber == 2)
        {
            if (WallsAndCoins.Contains(ShortWall))
            {
                return;
            }
            Instantiate(ShortWall, spawnPosition);
            WallsAndCoins.Add(ShortWall);
        }
        if (randomNumber == 3)
        {
            if (WallsAndCoins.Contains(WallWithExit))
            {
                return;
            }
            Instantiate(WallWithExit, spawnPosition);
            WallsAndCoins.Add(WallWithExit);
        }
    }
}
