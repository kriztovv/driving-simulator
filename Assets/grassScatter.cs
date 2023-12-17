using UnityEngine;

public class grassScatter : MonoBehaviour
{
    public GameObject treePrefab;
    public int maxTrees = 100;
    public Vector3 scatterAreaSize = new Vector3(50f, 0f, 50f);
    public float yPos;
    private Vector3 randomPosition;


    void Start()
    {


        Spawn();
    }


    void Spawn()
    {

        for (int i = 0; i < maxTrees; i++)
        {
        Vector3 randomPosition = new Vector3(
        Random.Range(scatterAreaSize.x / 2f, - scatterAreaSize.x / 2f),
        yPos,
        Random.Range(scatterAreaSize.z / 2f, - scatterAreaSize.z / 2f));
            Instantiate(treePrefab, randomPosition, Quaternion.Euler(0f, Random.Range(0f, 360f), 0f));
        }
    }

    
}