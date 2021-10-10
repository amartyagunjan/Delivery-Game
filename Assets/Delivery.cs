using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    SpriteRenderer spriteRenderer ;
    
    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D()
    {
        Debug.Log("oh! it hurts");
    }

    void OnTriggerEnter2D(Collider2D other ) {
        if(other.tag == "package" && hasPackage == false){
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Debug.Log("Package collected!");
            Destroy(other.gameObject,  0.1f);
        }
        else if(other.tag == "customer" && hasPackage == true){
            Debug.Log("package delivered!");
            spriteRenderer.color = noPackageColor;
            hasPackage = false;
        }
    }
}
