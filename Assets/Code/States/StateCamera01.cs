using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States {
	public class StateCamera01 : IState {

		public StateManager manager;
		public GameObject player;
		public PlayerControl controller;
		public StateCamera01(StateManager stateManager) {

			manager = stateManager;
			if (Application.loadedLevelName != "Maze01") {
				Application.LoadLevel("Maze01");
			}
			
			player = GameObject.Find ("Player");
			
			foreach (GameObject camera in manager.gameData.cameras) {
				if(camera.name != "PlayerView") 
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
			if(GUI.Button(new Rect(Screen.width/2 - 130, 10, 260, 30), "Top View")) {
				manager.SwitchState(new StateCamera02(manager));
			}			
		}
	}
}