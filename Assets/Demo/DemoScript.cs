/************************************************************************************************************************************													   *
* Developed by Mamadou Cisse                                                                                                        *
* Mail => mciissee@gmail.com                                                                                                        *
* Twitter => http://www.twitter.com/IncMce                                                                                          *
* Unity Asset Store catalog: http://u3d.as/riS	                                                                *
*************************************************************************************************************************************/

using UnityEngine;
using InfinityEngine;
using InfinityEngine.ResourceManagement;

public class DemoScript : MonoBehaviour {

    private int count = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PoolManager.Pop(R.gameobject.Cube, new Vector3(0, count, 0), Quaternion.identity);
            count++;
        }
    }
}
