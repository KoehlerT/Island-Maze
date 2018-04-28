using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LevelMap{
    /*Enthält alle nötigen informationen über ein level
     * Also:
     * Startpunkt, Zielpunkt, Größe, Ort der Verschiedenen Steine
     * Eventuell später auch Schwierigkeitsgrad, Vorschau usw.
     */
    



    public Vector2 start { get; private set; }
    public Vector2 ziel { get; private set; }
    public Vector2 größe { get; private set; } //Ausdehnung in X und Y richtung
    public int[][] tiles { get; private set; } //int gibt den Typen der Tile an

	public LevelMap(Vector2 größe, Vector2 start, Vector2 ziel)
    {
        this.start = start;
        this.ziel = ziel;
        this.größe = größe;
        tiles = new int[(int)größe.x][];
        for (int i = 0; i < tiles.Length; i++)
            tiles[i] = new int[(int)größe.y];

    }
    public LevelMap(Vector2 größe, Vector2 start, Vector2 ziel, int[][] tbarr)
    {
        this.tiles = tbarr;
        this.start = start;
        this.ziel = ziel;
        this.größe = größe;

    }


    //Beispiel. Dient nur zu testzwecken
    public static LevelMap getDefaultLevelMap()
    {
     
        int[][] tbarr = new int[5][];
        for (int i = 0; i < tbarr.Length; i++)
        {
            tbarr[i] = new int[5];
            for (int j = 0; j < tbarr[i].Length; j++)
            {
                tbarr[i][j] = 0;
            }
        }
        tbarr[0][1] = 1; tbarr[1][1] = 1; tbarr[2][0] = 2; tbarr[2][1] = 4; tbarr[3][4] = 4;
        return new LevelMap(new Vector2(4, 4), new Vector2(0, 0), new Vector2(4, 4), tbarr);
    }
}
