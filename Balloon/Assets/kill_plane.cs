using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill_plane : MonoBehaviour {
    //public GameManager _GameM;
    
    void OnTriggerEnter(Collider other)
    {

        //GameManager.instance.Getscore(1);

        if (other.name == "Balloon_EX(Clone)")
        {
            //GameManager.instance.Getscore(1, 1);
            Destroy(other.gameObject);
        }
        else if (other.name == "Balloon_EX_black(Clone)")
        {
            //GameManager.instance.Getscore(1, 2);
            Destroy(other.gameObject);
        }
        else if (other.name == "Balloon_third(Clone)")
        {
            //GameManager.instance.Getscore(1, 2);
            Destroy(other.gameObject);
        }
        /*
        else if (other.name == "Banana(Clone)")
        {
            //GameManager.instance.Getscore(1, 2);
            Destroy(other.gameObject);
        }
        else if (other.name == "Apple(Clone)")
        {
            //GameManager.instance.Getscore(1, 2);
            Destroy(other.gameObject);
        }
        */

    }

}
