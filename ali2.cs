using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ali2: MonoBehaviour
{
    int k = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(translatesam());
    }

    // Update is called once per frame
    IEnumerator translatesam()
    {
        while (k <= 1)
        {
            /*for (int i = 0; i < 7; i++)
            {
                transform.position += new Vector3(0, 1, 0);
                yield return new WaitForSeconds(1);
            }*/
            yield return new WaitForSeconds(5);
            for (int i = 0; i < 7; i++)
            {
                transform.position += new Vector3(0, -1, 0);
                yield return new WaitForSeconds(1);
            }
            k++;
        }
        for (int i = 0; i < 2; i++)
        {
            transform.position += new Vector3(-1, 0, 0);
            yield return new WaitForSeconds(1);
        }
        yield return new WaitForSeconds(5);
        for (int i = 0; i < 2; i++)
        {
            transform.position += new Vector3(1, 0, 0);
            yield return new WaitForSeconds(1);
        }


    }
}
