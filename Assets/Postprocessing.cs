using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;
public class Postprocessing : MonoBehaviour
{
    private PostProcessVolume _ppv;
    private Vignette _vignette;


    // Start is called before the first frame update
    void Start()
    {

        _ppv = gameObject.GetComponent<PostProcessVolume>();
        _ppv.profile.TryGetSettings(out _vignette);


    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKey(KeyCode.T))
        {
            _vignette.intensity.value += 0.025f;

        }
        if (Input.GetKey(KeyCode.U))
        {
            _vignette.intensity.value -= 0.025f;

        }
    }
}
