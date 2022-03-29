using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactable : MonoBehaviour, Iinteract
{
    public PlayerController controller;
    public interactionMechanic interactRef;
    public Material glowMaterial;
    private Color shaderTrans;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        shaderTrans = glowMaterial.color;
        shaderTrans.a = 0;
        shaderTrans.r = 255;
        shaderTrans.g = 0;
        shaderTrans.b = 0;
        glowMaterial.color = shaderTrans;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Entering collision");
            controller.canInteract = true;
            interactRef.toInteract = this;
            shaderTrans.a = 255;
            glowMaterial.color = shaderTrans;
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            //stats.canInteract = false;
            //interactRef.toInteract = null;
            shaderTrans.a = 0;
            glowMaterial.color = shaderTrans;
        }
    }
    public virtual void interact()
    {
        Debug.Log("interacting");
    }
}
