using Patterns_Command.ControlledSystems;
using System.Collections.Generic;
using System;

namespace Patterns_Command.Commands {

	public class MusicController : IController {

		Music _music;
		
		public MusicController(Music music) {
			_music = music;
		}

		public void Execute() {
			_music.Toggle();
		}

		public void Undo() {
			_music.Toggle();
		}
		
		public override string ToString() {
			return string.Format("[MusicController] Toggle music.");
		}
		
	}
}
