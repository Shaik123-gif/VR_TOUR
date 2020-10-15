using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(translatesam());
    }

    // Update is called once per frame
    IEnumerator translatesam()
    {
        
            yield return new WaitForSeconds(3);
            for (int i = 0; i < 9; i++)
            {
                transform.position += new Vector3(0,-1,0);
                yield return new WaitForSeconds(1);
            }
            for(int i=0;i<5;i++)
            {
                transform.position += new Vector3(-1, 0, 0);
                yield return new WaitForSeconds(1);
            }
            for (int i = 0; i < 5; i++)
            {
                transform.position += new Vector3(1, 0, 0);
                yield return new WaitForSeconds(1);
            }
            for (int i = 0; i < 9; i++)
            {
                transform.position += new Vector3(0,1,0);
                yield return new WaitForSeconds(1);
            }
       
    }
}
