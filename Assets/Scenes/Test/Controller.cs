using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public Data data;


    private void Start()
    {
        if (data != null)
        {
            LoadEnemy(data); //Preguntar cual es la funcion de data ahi
        }
    }

    private void LoadEnemy(Data _data)       //preguntar que hace Data _data
    {
       
        foreach(Transform child in this.transform)
        {
            if (Application.isEditor)
                Destroy(child.gameObject);
            else
                Destroy(child.gameObject);
              
        }

        GameObject visuals = Instantiate(data.enemyModel);
        visuals.transform.SetParent(this.transform);
        visuals.transform.localPosition=Vector3.zero;
        visuals.transform.localRotation = Quaternion.identity;
    }
}
