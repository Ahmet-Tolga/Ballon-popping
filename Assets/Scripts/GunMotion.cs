using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GunMotion : MonoBehaviour
{
    // Start is called before the first frame update
    Color[] colors={Color.red,Color.blue,Color.yellow};
    string[] StrColor={"red","blue","yellow"};
    GameObject player;
    Rigidbody2D rgb;
    int score=0;
    public TMP_Text display_score;
    int counter=0;

    void Start()
    {
        rgb=GetComponent<Rigidbody2D> ();
        player=GameObject.Find("Body");
        GetComponent<Renderer> ().material.color=colors[counter%3];
        player.GetComponent<Renderer> ().material.color=colors[counter%3];
        rgb.velocity=new Vector2(0f,50f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            counter+=1;
            GetComponent<Renderer> ().material.color=colors[counter%3];
            gameObject.tag=StrColor[counter%3];
            player.GetComponent<Renderer> ().material.color=colors[counter%3];
        }
        if(Input.GetKey(KeyCode.Space) && transform.position.y>=5){
            transform.position=player.transform.position;
        }

    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag=="bomb"){
            TakeDamage();
            Destroy(other.gameObject);
        }
        else{
            if(other.tag==gameObject.tag){
                AddScore();
                Destroy(other.gameObject);
            }
        }
    }

    void TakeDamage(){
        score-=5;
        display_score.text="Score:"+score;
    }

    void AddScore(){
        score+=5;
        display_score.text="Score:"+score;
    }
}
