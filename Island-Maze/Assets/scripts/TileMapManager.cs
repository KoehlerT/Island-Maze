using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapManager : MonoBehaviour {
    public GameObject mapObject;
    public GameObject backgroundObject;
    public TileBase backgroundTile;
    public TileBase[] tiles; //0..leer 1..stein 2..blau 3..grün 4..rot 5..spieler 6..ziel
    Tilemap map;
    Tilemap backTiles;

    // Use this for initialization
    void Start() {
        //Entnimmt die Tilemap Objekte aus den GameObjects
        map = mapObject.GetComponent<Tilemap>();
        backTiles = backgroundObject.GetComponent<Tilemap>();
        //Erstmal alle Entfernen
        map.ClearAllTiles();
        backTiles.ClearAllTiles();
        //Map laden
        LevelMap levelData = LevelMap.getDefaultLevelMap();
        //hintergrund befüllen
        backTiles.BoxFill(new Vector3Int((int)levelData.größe.x, (int)levelData.größe.y, 0), backgroundTile, 0, 0, (int)levelData.größe.x, (int)levelData.größe.y);
        //Tiles Spawnen
        for (int x = 0; x <= levelData.größe.x; x++)
            for (int y = 0; y <= levelData.größe.y; y++)
                map.SetTile(new Vector3Int(x, y, 0), tiles[levelData.tiles[x][y]]); //Tile an Position wird zu einem element aus tiles gesetzt
        //Start und Ziel
        map.SetTile(new Vector3Int((int)levelData.start.x, (int)levelData.start.y, 0), tiles[5]);
        map.SetTile(new Vector3Int((int)levelData.ziel.x, (int)levelData.ziel.y, 0), tiles[6]);
    }
        // Update is called once per frame
        void Update () {
		
	}
}
