using Patterns_Command.ControlledSystems;
using System.Collections.Generic;

namespace Patterns_Command.Commands {

	public class LightController : IController {

		Light _light;
		Stack<LightState> _states;
		
		public LightController(Light light) {
			_light = light;
			_states = new Stack<LightState>();
			_states.Push(LightState.Off);
		}

		public void Execute() {
			_light.Toggle();
			_states.Push(_light.State);
		}

		public void Undo() {
			if (_states.Count > 0) {
				_states.Pop();
				_light.SetState(_states.Peek());
			}
		}
		
		public override string ToString() {
			return string.Format("[LightController] Toggle light.");
		}
	}
}
