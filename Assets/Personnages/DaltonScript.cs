using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DaltonScript : MonoBehaviour
{
    [SerializeField] string nom;
    [SerializeField] Tilemap map;
    [SerializeField] TileBase spriteTile;

    [SerializeField] public int odeurPied = 0;
    [SerializeField] public int odeurBouffe = 0;

    [SerializeField] GameObject goOdeurPied;
    [SerializeField] GameObject goOdeurBouffe;

    Grid grid;
    Rigidbody2D rb;

    List<string> directions = new List<string>();
    string dirChoisi; 

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        grid = map.GetComponentInParent<Grid>();
        
        directions.Add("N");
        directions.Add("S");
        directions.Add("E");
        directions.Add("O");

        dirChoisi = aleaStrings(directions);

    }

    private void Update(){
        
        var tilePos = grid.WorldToCell(transform.position);
        map.SetTile(tilePos, spriteTile);
    }

   private void OnTriggerEnter2D(Collider2D collision) 
   {
        StartCoroutine(delay(collision));
        antiDemiTour(this.dirChoisi);

        if((collision.tag == "PointIn") && (nom == "Joe" || nom == "Jack" || nom == "William"))
        {
            collision.tag = "PointDalton";
            odeurPied--;
        }
        if ((collision.tag == "PointIn" || collision.tag == "PointDalton") && nom == "Averell")
        {
            collision.tag = "PointAverell";
            odeurPied--;
            odeurBouffe--;
        }
    }

    IEnumerator delay(Collider2D collision)
    {
        //yield on a new YieldInstruction that waits for 3 seconds.
        yield return new WaitForSeconds(1);
        
        seDeplace(this.dirChoisi, collision );
        this.dirChoisi = aleaStrings(antiDemiTour(this.dirChoisi));
    }

    List<string> antiDemiTour(string dirPrecedente)
    {
        switch (dirPrecedente)
        {
            case "N":
                directions.Clear();
                directions.Add("N");
                directions.Add("O");
                directions.Add("E");
                break;
            case "S":
                directions.Clear();
                directions.Add("O");
                directions.Add("S");
                directions.Add("E");
                break;
            case "E":
                directions.Clear();
                directions.Add("N");
                directions.Add("S");
                directions.Add("E");
                break;
            case "O":
                directions.Clear();
                directions.Add("N");
                directions.Add("S");
                directions.Add("O");
                break;
            default:
                directions.Clear();
                directions.Add("N");
                directions.Add("S");
                directions.Add("E");
                directions.Add("O");
                break;
        }

        return directions;
    }

    void seDeplace(string direction, Collider2D collision)
    {
        Vector2 temp1 = new Vector2(0, 2.54f);
        Vector2 temp2 = new Vector2(2.54f, 0);
        Vector3Int temp3 = new Vector3Int(0, 1, 0);
        Vector3Int temp4 = new Vector3Int(1, 0, 0);
        var tilePos = grid.WorldToCell(transform.position);

        switch (direction)
        {
            case "N":
                if(collision.tag == "PointIn" || collision.tag == "PointDalton" || collision.tag == "PointAverell")
                {  
                    rb.MovePosition(rb.position + temp1);
                    map.SetTile(tilePos + temp3, spriteTile);
                }
                break;
            case "S":
                if (collision.tag == "PointIn" || collision.tag == "PointDalton" || collision.tag == "PointAverell")
                {
                    rb.MovePosition(rb.position - temp1);
                    map.SetTile(tilePos - temp3, spriteTile);
                }

                break;
            case "E":
                if (collision.tag == "PointIn" || collision.tag == "PointDalton" || collision.tag == "PointAverell")
                {
                    rb.MovePosition(rb.position + temp2);
                    map.SetTile(tilePos + temp4, spriteTile);
                }

                break;
            case "O":
                if (collision.tag == "PointIn" || collision.tag == "PointDalton" || collision.tag == "PointAverell")
                {
                    rb.MovePosition(rb.position - temp2);
                    map.SetTile(tilePos - temp4, spriteTile);
                }
                break;
            default:
                
            break;
        }
    }

    public string aleaStrings(List<string> choixList)
    {
        string choix = choixList[Random.Range(0, choixList.Count)];
        return choix;
    }
}