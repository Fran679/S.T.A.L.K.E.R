using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAnimationController : MonoBehaviour
{
    Animation animation;
    void Start()
    {
        animation = this.gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        animation.Play("eating");
    }
}
