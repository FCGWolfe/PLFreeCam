using PulsarPluginLoader.Chat.Commands;

namespace PLFreeCam
{
	public class FreeCam : IChatCommand
	{
		public string[] CommandAliases()
		{
			return new string[]
			{
				"freecam"
			};
		}

		public string Description()
		{
			return "PULSAR Freecam Plugin!";
		}

		public string UsageExample()
		{
			return "/" + this.CommandAliases()[0];
		}
		public bool PublicCommand()
		{
			return false;
		}
		public bool Execute(string arguments, int executor)
		{
			if (PLCameraSystem.Instance.CurrentCameraMode != null && PLCameraSystem.Instance.CurrentCameraMode.GetType() == typeof(PLCameraMode_Scripted))
			{
				PLCameraSystem.Instance.ChangeCameraMode(new PLCameraMode_LocalPawn());
			}
			else
			{
				PLCameraSystem.Instance.ChangeCameraMode(new PLCameraMode_Scripted());
			}
			return false;
		}
	}
}
