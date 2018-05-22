using System;

namespace Patterns_Command.ControlledSystems {

	public enum LightState {
		Off = 0,
		Low = 1,
		Medium = 2,
		High = 3
	}
	
	public class Light {

		public LightState State { get; private set; }
		
		public void Toggle(){
			switch(State){
				case LightState.Off:
					State = LightState.Low;
					break;
				case LightState.Low:
					State = LightState.Medium;
					break;
				case LightState.Medium:
					State = LightState.High;
					break;
				case LightState.High:
					State = LightState.Off;
					break;
			}

			PrintState();
			
		}
		
		public void SetState(LightState state){
			State = state;
			PrintState();
		}
		
		private void PrintState(){
			switch (State) {
				case LightState.Off:
					Console.WriteLine("Light off");
					return;
				case LightState.Low:
					Console.WriteLine("Low light");
					return;
				case LightState.Medium:
					Console.WriteLine("Medium light");
					return;
				case LightState.High:
					Console.WriteLine("High light");
					return;
			}
		}
		
	}
}
