using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperSpawn : MonoBehaviour
{
    [SerializeField] public List<GameObject> papers;
    [SerializeField] public GameObject spawnPoint;
   
    void Start()
    {
        papers = new List<GameObject>(Resources.LoadAll<GameObject>("Prefabs"));
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            int randomPrefab = Random.Range(0, papers.Count);
            Instantiate(papers[randomPrefab], spawnPoint.transform.position, Quaternion.Euler(-90,90,0));
        }
        
    }
}
