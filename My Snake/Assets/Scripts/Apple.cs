using UnityEngine;

public class Apple : MonoBehaviour
{
    [SerializeField] private BoxCollider2D gridArea;

    private void Start()
    {
        RandomizeSpawn();        
    }
    private void RandomizeSpawn()
    {
        Bounds SpawnBounds = gridArea.bounds;

        float x = Random.Range(SpawnBounds.min.x, SpawnBounds.max.x);
        float y = Random.Range(SpawnBounds.min.y, SpawnBounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0f);    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            RandomizeSpawn();
        }
    }
}
