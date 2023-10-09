using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateSprite : MonoBehaviour
{
    private bool spriteA = true;
    public Material matA;
    public Material matB;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpriteAnimate());
    }

    private void Update()
    {
        //SpriteAnimate();
    }
    IEnumerator SpriteAnimate()
    {
        yield return new WaitForSeconds(.25f);
        if (spriteA)
        {
            this.gameObject.GetComponent<Renderer>().material = matA;
            spriteA = false;
            Debug.Log("Chomp");
        }
        else
        {
            this.gameObject.GetComponent<Renderer>().material = matB;
            spriteA = true;
            Debug.Log("True");
        }

        StartCoroutine(SpriteAnimate());

    }
}
