using System;
using System.Collections.Generic;
using Patterns_Command.Commands;
using Patterns_Command.ControlledSystems;

namespace Patterns_Command {
	class Program {

		static void Main(string[] args) {
			RemoteController remote = new RemoteController();
			string input;

			var musicCtr = new MusicController(new Music());
			var lightCtr = new LightController(new Light());

			//remote.SetButtonToCommand(1, new LightController(new Light()));
			//remote.SetButtonToCommand(2, new MusicController(new Music()));

			remote.SetButtonToCommand(1, musicCtr);
			remote.SetButtonToCommand(2, lightCtr);

			remote.SetButtonToCommand(3, new CombinedController(new List<IController> { musicCtr, lightCtr }));

			do {
				Console.WriteLine(remote);
				Console.Write("\nClick key: ");
				
				input = Console.ReadLine();
				int.TryParse(input, out int button);

				remote.PushButton(button);
				//remote.PushButton(button);
				//remote.Undobutton(button);

				Console.Write("\nContinue? y/n: ");
				input = Console.ReadLine();
			
			} while (input == "y");			
			
		}
	}
}
