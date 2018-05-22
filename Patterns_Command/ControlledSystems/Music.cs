using System;

namespace Patterns_Command.ControlledSystems {

	public enum GeneralState{
		Off = 0,
		On = 1
	}

	public class Music {

		public GeneralState State { get; private set; }
		
		public void Toggle(){
			switch(State){
				case GeneralState.Off:
					State = GeneralState.On;
					break;
				case GeneralState.On:
					State = GeneralState.Off;
					break;
			}

			PrintState();
		}
		
		private void PrintState() {
			switch (State) {
				case GeneralState.Off:
					Console.WriteLine("Music is off");
					break;
				case GeneralState.On:
					Console.WriteLine("Music is on");
					break;
			}
		}
	}
}
