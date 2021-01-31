using System;

namespace DZ_30_01_21
{
	class ExpertDocumentWorker : ProDocumentWorker
	{
		public override void SaveDocument()
		{
			Console.WriteLine("Документ сохранен в новом формате");
		}

	}
}
