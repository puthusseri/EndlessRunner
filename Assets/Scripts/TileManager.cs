using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
	public GameObject[] tilePrefab;
	private Transform playerTransform;
	private float spawnZ = 0.0f;
	private float tileLength = 23.0f;
	private int amtTilesOnScreen = 6;
    // Start is called before the first frame update
    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
		for(int i =0;i<amtTilesOnScreen; i++)
		{
			SpawnTile();
		}
    }

    // Update is called once per frame
    private void Update()
    {
       if(playerTransform.position.z > (spawnZ = amtTilesOnScreen * tileLength))
	   {
		   SpawnTile();
	   }
    }
	private void SpawnTile(int prefbIndex = -1) {
	
		GameObject go;
		go = Instantiate(tilePrefab [0]) as GameObject;
		go.transform.SetParent(transform);
		go.transform.position = Vector3.forward * spawnZ;
		spawnZ += tileLength;
	}
		
}
