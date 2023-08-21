using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DottledLine : MonoBehaviour
{

    public GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        var dashline = new GameObject($"Dashed Line", typeof(SpriteRenderer));        
        var sprite = Sprite.Create(new Texture2D(500, 500), new Rect(0, 0, 30, 100), new Vector2(0,0));
            
        var Mycolor = new Color(1f, 0.8705882353f, 0.1843137255f, 1f);

        for (float i = 0; i < camera.GetComponent<Camera>().orthographicSize + 10;){   
            var y = new GameObject($"Dashed Line {i}", typeof(SpriteRenderer));
            y.GetComponent<SpriteRenderer>().color = Mycolor;
            y.GetComponent<SpriteRenderer>().sprite = sprite;
            y.transform.position = Vector3.up * i;
        
        
            y.transform.SetParent(dashline.transform);


            var x = new GameObject($"Dashed Line {i}", typeof(SpriteRenderer));
            x.GetComponent<SpriteRenderer>().color = Mycolor;
            x.GetComponent<SpriteRenderer>().sprite = sprite;
            x.transform.position = Vector3.down * i;
        
            x.transform.SetParent(dashline.transform);


            i = i + 1.8f;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
