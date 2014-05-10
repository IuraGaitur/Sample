using UnityEngine;
using System.Collections;

public class CollisionScript : MonoBehaviour {

	public int hp = 5;

	public bool isEnemy = true;


	private ScrollingScript scrollBackgr,scrollMain,scrollElem;


	public void DamageHole(int damage){
		hp -= damage;
		if (hp <= 0) {

			Destroy(gameObject);
		}

	}




	void OnTriggerEnter2D(Collider2D collider){
		
		
		BottleScript bottle = collider.gameObject.GetComponent<BottleScript> ();
		CarScript car = collider.gameObject.GetComponent<CarScript> ();
		HoleScript hole = collider.gameObject.GetComponent<HoleScript> ();
		MoneyScript money = collider.gameObject.GetComponent<MoneyScript>(); 
		
		if (bottle != null) {
			
			Destroy(bottle.gameObject);
			scrollBackgr = GameObject.Find("Background").GetComponent<ScrollingScript>();
			//scrollMain = GameObject.Find("Middleground").GetComponent<ScrollingScript>();

			if(scrollBackgr.speed.x <= 15){
			scrollBackgr.speed.x+=5;
			//scrollMain.speed.x+=5;
			}
		}
		
		if (car != null) {
			
			Destroy(car.gameObject);

			Destroy(gameObject);
			
		}
		
		if (hole != null) {
			scrollBackgr = GameObject.Find("Background").GetComponent<ScrollingScript>();
			scrollMain = GameObject.Find("Middleground").GetComponent<ScrollingScript>();
			scrollElem = GameObject.Find("BackgroundElements").GetComponent<ScrollingScript>();

			if(scrollBackgr.speed.x > 5){
				scrollBackgr.speed.x-=3;
				scrollMain.speed.x-=3;
				DamageHole(1);
			}
			
			
		}
		
		if (money != null) {
			
			GameObject moneys = GameObject.Find("Score");
			
			//string text = moneys.text.ToString();
			//int currScore = int.Parse(text.Substring(6));
			//currScore+=3;
			//moneys.text = "Score:"+ currScore.ToString();
			
			Destroy(money.gameObject);
			
		}
		
		
	}


	// Use this for initialization
	void Start () {
	
	}



	// Update is called once per frame
	void Update () {
	
	}
}
