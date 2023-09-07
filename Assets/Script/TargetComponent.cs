using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetComponent : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Projectile")
        {
            gameObject.SetActive(false);
            // gameObject.transform.parent gives you access to the 
            gameObject.transform.parent.GetComponent<Renderer>().material.color = Color.red;
            Invoke("UnhideTarget", 5.0f);
            GameManager.Instance.IncrementScore();
            // TODO a score and hide target
        }
    }

    public void UnhideTarget()
    {
        gameObject.SetActive(true);
        gameObject.transform.parent.GetComponent<Renderer>().material.color = Color.green;
    }
}