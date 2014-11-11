using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States {
	public class StartEtats : ETatsi {

		private MngEtats manager;
		public StartEtats(MngEtats mngEtats) {

			manager = mngEtats;
			Time.timeScale = 0;
		}
		
		public void StateUpdate() {
			if(Input.GetKeyUp(KeyCode.S)) {
				Application.LoadLevel("Maze01");
				manager.SwEtats(new StCmr01(manager));
			}
		}

		public void Render() {
			if(GUI.Button(new Rect(280, 300, 200, 60), "START")) {
				Application.LoadLevel("Maze01");
				Time.timeScale = 1;
				manager.SwEtats(new StCmr01(manager));    
			}
		}
	}
}