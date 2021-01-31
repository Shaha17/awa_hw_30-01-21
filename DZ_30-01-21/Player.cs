namespace DZ_30_01_21
{
	partial class Program
	{
		class Player : IPlayable, IRecordable
		{
			public void Play()
			{
				System.Console.WriteLine("Play");
			}
			public void Pause()
			{
				System.Console.WriteLine("Pause");
			}
			public void Record()
			{
				System.Console.WriteLine("Record");
			}
			public void Stop()
			{
				System.Console.WriteLine("Stop");
			}
		}
	}
}
