using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CarScript : MonoBehaviour {

	private bool hasSpawn;
	private MoveScript moveScript;

	List<string> carTypes;

	void Awake(){

		//carTypes = getMyCars ();

		//Sprite spriteCar = Resources.Load("fruits_1", typeof(Sprite)) as Sprite;

		//GetComponent(SpriteRenderer).sprite = 

		// Retrieve scripts to disable when not spawn
		//moveScript = GetComponent<MoveScript>();
	}

	// Use this for initialization
	void Start () {
	

		//hasSpawn = false;
		
		// Disable everything
		// -- collider
		//collider2D.enabled = false;
		// -- Moving
		//moveScript.enabled = false;

	}
	
	void Update()
	{
		// 2 - Check if the enemy has spawned.
		/*if (hasSpawn == false)
		{
			if (renderer.IsVisibleFrom(Camera.main))
			{
				Spawn();
			}
		}
		else
		{

			// 4 - Out of the camera ? Destroy the game object.
			if (renderer.IsVisibleFrom(Camera.main) == false)
			{
				Destroy(gameObject);
			}
		}*/
	}
	
	// 3 - Activate itself.
	private void Spawn()
	{
		hasSpawn = true;
		
		// Enable everything
		// -- Collider
		collider2D.enabled = true;
		// -- Moving
		moveScript.enabled = true;


	}

	List<string> getMyCars(){

		List<string> cars = new List<string> ();
		cars.Add("car_1");
		cars.Add("car_2");
		cars.Add("car_3");

		return cars;
	}

}
