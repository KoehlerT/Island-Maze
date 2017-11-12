using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapManager : MonoBehaviour {
    public GameObject mapObject;
    public GameObject backgroundObject;
    public TileBase backgroundTile;
    public TileBase[] tiles;
    Tilemap map;
    Tilemap backTiles;

	// Use this for initialization
	void Start () {
        //Entnimmt die Tilemap Objekte aus den GameObjects
        map = mapObject.GetComponent<Tilemap>();
        backTiles = backgroundObject.GetComponent<Tilemap>();
        //Erstmal alle Entfernen
        map.ClearAllTiles();
        backTiles.ClearAllTiles();
        //Map laden
        LevelMap levelData = LevelMap.getDefaultLevelMap();
        //hintergrund befüllen
        //Sehr unedel. Ich kann mit Boxfill nicht umgehen
        for (int x = 0; x < levelData.größe.x; x++)
            for (int y = 0; y < levelData.größe.y; y++)
                backTiles.SetTile(new Vector3Int(x, y, 0), backgroundTile);
        //Tiles Spawnen
        for (int x = 0; x < levelData.größe.x; x++)
            for (int y = 0; y < levelData.größe.y; y++)
                map.SetTile(new Vector3Int(x, y, 0), tiles[levelData.tiles[x][y]]); //Tile an Position wird zu einem element aus tiles gesetzt

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
