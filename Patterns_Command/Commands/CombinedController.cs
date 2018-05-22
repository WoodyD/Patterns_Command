using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns_Command.Commands {

	public class CombinedController : IController {

		List<IController> _controllers;
		
		public CombinedController(List<IController> controllers) {
			_controllers = controllers;
		}

		public void Execute() {
			foreach (var ctr in _controllers)
				ctr.Execute();
		}

		public void Undo() {
			foreach (var ctr in _controllers)
				ctr.Undo();
		}
		
		public override string ToString() {
			var sb = new StringBuilder();
			foreach (var ctr in _controllers)
				sb.AppendFormat("{0} ", ctr);

			return sb.ToString();
		}
	}
}
