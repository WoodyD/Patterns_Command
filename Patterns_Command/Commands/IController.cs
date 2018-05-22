
namespace Patterns_Command.Commands {

	public interface IController {

		void Execute();
		void Undo();
		
	}
}
