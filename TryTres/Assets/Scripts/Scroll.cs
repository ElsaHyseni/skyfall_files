using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public float speed = 0.3f;
    private MeshRenderer mesh_Render;
    // Start is called before the first frame update
    void Awake()
    {
        mesh_Render = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        scroll();
    }

     void scroll() {
        Vector2 offset = mesh_Render.sharedMaterial.GetTextureOffset("_MainTex");
        offset.y += Time.deltaTime * speed;

        mesh_Render.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
