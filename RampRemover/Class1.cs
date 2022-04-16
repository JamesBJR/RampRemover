using System;
using System.Linq;
using MelonLoader;
using UnityEngine;


public class noRamps : MelonMod
{

	public override void OnSceneWasLoaded(int buildIndex, string sceneName)
	{
		if (sceneName == "Elysium")
		{

            (from x in Resources.FindObjectsOfTypeAll<GameObject>()
			 where x.name.Equals("Jump Takeoff - 05 Large")
			 select x).ToList().ForEach(delegate (GameObject x)
			 {
				 
				 UnityEngine.Object.Destroy(x);
             });
			return;
		}

	}

}
