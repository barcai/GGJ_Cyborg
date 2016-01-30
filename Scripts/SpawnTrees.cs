using UnityEngine;
using System.Collections;

public class SpawnTrees : MonoBehaviour {

    public Vector2 range = new Vector2(0f, 0f);
    public Vector2 density = new Vector2(1f, 1f);

    public GameObject[] prefabs;

    void Start () {
        float posX = range.x;

        while (posX <= range.y)
        {
            // Spawn tree at pos
            GameObject prefab = prefabs[Random.Range(0, prefabs.Length)];

            GameObject instance = GameObject.Instantiate(prefab);
            instance.transform.parent = this.transform;
            float posY = instance.transform.position.y + instance.GetComponent<SpriteRenderer>().sprite.bounds.size.y / 2f - 2f + Random.Range(0, 0.3f);
            instance.transform.position = new Vector3(posX, posY, instance.transform.position.z);


            posX += Random.Range(density.x, density.y);
        }
	}
}
