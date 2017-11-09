using UnityEngine;
using System.Collections;

public class LevelCreator : MonoBehaviour {

    public GameObject tile_prefab;
    GameObject[][] tiles;
	// Use this for initialization
	void Start () {
        tiles = new GameObject[5][];
        for (int i = 0; i < tiles.Length; i++)
        {
            tiles[i] = new GameObject[5];
            for (int j = 0; j < tiles[i].Length; j++)
            {
                GameObject tile = Instantiate(tile_prefab);
                tile.transform.position = new Vector2(i*1.2f, j*1.2f);
                tile.transform.SetParent(this.gameObject.transform);
                tiles[i][j] = tile;
            }
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
