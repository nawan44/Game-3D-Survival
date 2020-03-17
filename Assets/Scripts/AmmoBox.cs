using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour {

    void OnTrigger(BoxCollider col) {
        if (col.gameObject.tag == "Player") {
            WeaponController.ammoMag = 90;
        }
    }
}
