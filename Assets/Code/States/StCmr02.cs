using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States {
	public class StCmr02 : ETatsi {

		public MngEtats manager;
		public GameObject player;
		public PlayerControl controller;
		public StCmr02(MngEtats mngEtats) {

			manager = mngEtats;
			if (Application.loadedLevelName != "Maze01") {
				Application.LoadLevel("Maze01");
			}
			
			player = GameObject.Find ("Player");
			
			foreach (GameObject camera in manager.gameData.cameras) {
				if(camera.name != "TopView") 
					camera.SetActive(false);
				else
					camera.SetActive(true);
			}
		}
		
		public void StateUpdate() {
			
			if (manager.gameData.playerHP <= 0) {
			}
			
			if (manager.gameData.score >= 5) {
			}
			
		}

		public void Render() {
			if(GUI.Button(new Rect(Screen.width/2 - 130, 10, 260, 30), "Player View")) {
				manager.SwEtats(new StCmr01(manager));			
			}
		}
	}
}