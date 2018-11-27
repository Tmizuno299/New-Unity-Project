using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss {

	// Use this for initialization
	private int mp = 53;
	private int mpw = 30;
	public void Magic () {
		if (mp >= 5) {
			this.mp -= 5;
			Debug.Log (this.mpw + "の魔法攻撃ダメージを与えた。残りMPは" + this.mp + "です。");
		}
		else { Debug.Log("MPが足りないため魔法が使えない。");
		}
	}
}


public class Test : MonoBehaviour {
	void Start () {
		Boss lastboss = new Boss ();
		lastboss.Magic ();
	}


}

// Update is called once per frame
