using UnityEngine;


public class Food : MonoBehaviour
{
    public BoxCollider2D spawnArea; // We use this because Box Collider has bound property

    private void RandomizePosition()
    {
        Bounds bounds = this.spawnArea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y),0.0f);
    }

    private void Start()
    {
        RandomizePosition();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Snake")
        {
            RandomizePosition();
        }
    }

}
