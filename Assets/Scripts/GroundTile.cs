using UnityEngine;

public class GroundTile : MonoBehaviour
{
    /*[SerializeField] GameObject Car;
    [SerializeField] Transform _transform;
    private Transform finalTransform;*/
    GroundSpawner groundSpawner;

    [SerializeField] GameObject[] finalObstacles;
    

    private void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();

    }
    private void Update()
    {
        //finalTransform = Car.GetComponent<Transform>();
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile(true);
        Destroy(gameObject, 2);
    }

    public void SpawnObstacle()
    {
        int increment = 0;
        //float difference = Vector3.Distance(finalTransform.position, _transform.position);
        /*if(difference % 50 ==0)
        {
            if(increment <12)
            {
                increment += 1;
            }
        }*/
        
        // Choose a random Prefab to spawn as an Obstacle.
        int obstaclePrefabNumber = Random.Range(0, 6);
        // Choose a random point to spawn the obstacle
        int obstacleSpawnIndex = Random.Range(2, 21+increment);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

        // Spawn the obstace at the position
        Instantiate(finalObstacles[obstaclePrefabNumber], spawnPoint.position, Quaternion.identity, transform);
    }

}