using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

     [SerializeField] Color32 hasPackageColor = new Color32 (1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32 (1,1,1,1);

    bool hasPackage;
    [SerializeField]float  DestroyDelay =0.5f;

    SpriteRenderer spriteRenderer;
  void Start(){
   spriteRenderer = GetComponent<SpriteRenderer>();
  }
     


    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D other)
    {
         Debug.Log("ouch");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
      

        if (other.CompareTag("package")&& !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;  
            spriteRenderer.color = hasPackageColor;

            Destroy(other.gameObject, DestroyDelay); 

        }

        if (other.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Package delivered");
            hasPackage = false; 
              spriteRenderer.color = noPackageColor;
        }
    }
}
