using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States {
	public class StartState : IState {

		private StateManager manager;
		public StartState(StateManager stateManager) {

			manager = stateManager;
			Time.timeScale = 0;
		}
		
		public void StateUpdate() {
			if(Input.GetKeyUp(KeyCode.S)) {
				Application.LoadLevel("Maze01");
				manager.SwitchState(new StateCamera01(manager));
			}
		}

		public void Render() {
			if(GUI.Button(new Rect(280, 300, 200, 60), "START")) {
				Application.LoadLevel("Maze01");
				Time.timeScale = 1;
				manager.SwitchState(new StateCamera01(manager));    
			}
		}
	}
}