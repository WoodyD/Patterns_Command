using System;
using System.Collections.Generic;
using System.Text;
using Patterns_Command.Commands;

namespace Patterns_Command {

	public class RemoteController {

		private Dictionary<int, IController> _commands;
		
		public RemoteController() {
			_commands = new Dictionary<int, IController>();
		}
		
		public void SetButtonToCommand(int btn, IController cmd){
			_commands[btn] = cmd;
		}
		
		public void PushButton(int btn){
			if (_commands.ContainsKey(btn))
				_commands[btn].Execute();
		}
		
		public void Undobutton(int btn){
			if (_commands.ContainsKey(btn))
				_commands[btn].Undo();
		}
		
		public override string ToString() {
			var sb = new StringBuilder();

			sb.AppendFormat("[RemoteController]\n");

			foreach(var button in _commands.Keys){
				sb.AppendFormat("{0}\t{1}\n", button, _commands[button]);
			}

			return sb.ToString();
		}
		
	}
}
