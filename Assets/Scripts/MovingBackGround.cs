using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackGround : MonoBehaviour
{
    public float Speed;
    private Renderer renderer;
    private Vector2 saveOffSet;

    void Start()
    {
      renderer=GetComponent<MeshRenderer>();  
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Repeat(Time.time * Speed, 1);
        Vector2 offset = new Vector2(x, 0);
        renderer.sharedMaterial.SetTextureOffset("_MainTex",offset);
    }
}
