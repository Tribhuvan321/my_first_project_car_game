using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    //[SerializeField] GameObject[] allGroundTiles;
    public GameObject groundTile;
    Vector3 nextSpawnPoint;
    [SerializeField] GameObject[] finalTerrain;

    public void SpawnTile(bool spawnItems)
    {
        int GroundTileSpawnIndex = Random.Range(0,2);

        GameObject temp = Instantiate(finalTerrain[GroundTileSpawnIndex], nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;

        if (spawnItems)
        {
            temp.GetComponent<GroundTile>().SpawnObstacle();
            
        }
    }

    private void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            if (i < 3)
            {
                SpawnTile(false);
            }
            else
            {
                SpawnTile(true);
            }
        }
    }
}