using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphBehaviorScript : MonoBehaviour {
    //public Texture2D tex;
    //private Sprite mySprite;
    //private SpriteRenderer spriteRenderer;
    Color spriteColor;
    float redValue;
    float blueValue;
    float greenValue;
    System.Random rng;
    GameObject vertexGameObject;
    List<GameObject> gameObjects;

    const int NUM_VERTS = 3;

    void Awake()
    {
         
    }

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < NUM_VERTS; i++)
        {

        }

        sprites = new List<Sprite>();
        rng = new System.Random();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.magenta;

        origSprite = Resources.Load<Sprite>("CircleVertexSprite");
        for (int i = 0; i < NUM_VERTS; i++)
        {
            Vector2 pos = new Vector2();
            Quaternion rot = new Quaternion(0, 0, 0, 0);
            //Transform trans;
            pos.x = rng.Next(10, 100);
            pos.y = rng.Next(10, 100);
            Sprite newSprite = Instantiate<Sprite>(origSprite, pos, rot);
            sprites.Add(newSprite);
        }

        spriteRenderer

    }

    private void OnGUI()
    {
        GUI.Label(new Rect(0, 30, 50, 30), "Red: ");
        redValue = GUI.HorizontalSlider(new Rect(35, 25, 200, 30), redValue, 0, 1);

        GUI.Label(new Rect(0, 70, 50, 30), "Green: ");
        greenValue = GUI.HorizontalSlider(new Rect(35, 60, 200, 30), greenValue, 0, 1);

        GUI.Label(new Rect(0, 105, 50, 30), "Blue: ");
        blueValue = GUI.HorizontalSlider(new Rect(35, 95, 200, 30), blueValue, 0, 1);

        spriteColor = new Color(redValue, greenValue, blueValue);

        spriteRenderer.color = spriteColor;


    }

    // Update is called once per frame
    void Update () {
		
	}
}
