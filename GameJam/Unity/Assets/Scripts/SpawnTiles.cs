using UnityEngine;
using System.Collections;

public class SpawnTiles : MonoBehaviour {
	
	public GameObject BasicTile;
	public GameObject CrossTile;
	public GameObject XTile;
	public GameObject HorizontalTile;
	public GameObject VerticalTile;
	private ArrayList TileList;
	
	// Use this for initialization
	void Start () {
		TileList = new ArrayList();
		CreateTiles();
	}
	
	// Update is called once per frame
	void Update () {
	
		
		
	}
	
	void CreateTiles()
	{
		Vector3 pos;
		//position en bas a gauche
		pos.x = 7.5f;
		pos.y = -7.5f;
		pos.z=5.0f;
		
		print("Instantiating tiles");
		//on déplace de bas en haut et ensuite de droite a gauche.
		for(int i = 0; i < 16; i++)
		{
			for(int j = 0; j < 16; j++)
			{
				GameObject tile = (GameObject)Instantiate(BasicTile, pos, Quaternion.identity);
				//tile.AddComponent("ColorLerp");
				if(tile != null)
					TileList.Add(tile);
				
				pos.y++;
			}
			pos.x--;
			pos.y = -7.5f; //reset y position
		}
	}
}
